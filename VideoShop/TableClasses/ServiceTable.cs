using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.Classes;

namespace VideoShop.TableClasses
{
    class ServiceTable
    {
        private bool result;
        private string query;

        public bool Insert(ServicesNames c)
        {
            query = "EXEC SERVICES_INS @name, @price";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@name", c.getServName());
            comm.Parameters.AddWithValue("@float", c.getServPrice());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }

            c.setServID(returnID());

            comm.Dispose();
            result = true;
            return result;
        }

        public bool Update(ServicesNames c)
        {
            query = "EXEC SERVICES_UPD @id, @serviceName, @servicePrice";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", c.getServID());
            comm.Parameters.AddWithValue("@serviceName", c.getServName());
            comm.Parameters.AddWithValue("@servicePrice", c.getServPrice());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }

        public bool Delete(ServicesNames c)
        {
            query = "DELETE FROM [SERVICES] WHERE ID = @id";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", c.getServID());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }

        public bool Select(List<ServicesNames> services)
        {
            SqlDataReader sr;
            query = "SELECT * FROM [SERVICES]";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            sr = comm.ExecuteReader();
            while (sr.Read())
            {
                services.Add(new ServicesNames(sr.GetInt32(0), sr.GetString(1), sr.GetDouble(2) ) );
            }
       
            sr.Close();
            comm.Dispose();
            return true;

        }
        private int returnID()
        {
            decimal id = 0;
            SqlDataReader sr;
            query = "SELECT IDENT_CURRENT('SERVICES') AS LASTID";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            sr = comm.ExecuteReader();
            while (sr.Read())
            {
                id = sr.GetDecimal(0);
            }

            return Int32.Parse(id.ToString());

        }
    }
}
