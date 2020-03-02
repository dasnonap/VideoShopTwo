using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.Classes;

namespace VideoShop.TableClasses
{
    class CountriesTable
    {
        private bool result;
        private string query;

        public bool Insert(Countries c)
        {
            query = "EXEC COUNTRIES_INS @name";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@name", c.getCountry() );

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }

            c.setCountryID(returnID());

            comm.Dispose();
            result = true;
            return result;
        }

        public bool Update(Countries c)
        {
            query = "EXEC COUNTRIES_UPD @id, @name";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", c.getCountryID());
            comm.Parameters.AddWithValue("@name", c.getCountry());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }

        public bool Delete(Countries c)
        {
            query = "DELETE FROM COUNTRIES WHERE COUNTRY_ID = @id";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", c.getCountryID());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }

        public bool Select(List<Countries> countries)
        {
            SqlDataReader sr;
            query = "SELECT * FROM COUNTRIES";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            sr = comm.ExecuteReader();
            while (sr.Read())
            {
                countries.Add(new Countries(sr.GetInt32(0), sr.GetString(1)));
            }

            sr.Close();
            comm.Dispose();
            return true;

        }
        private int returnID()
        {
            decimal id = 0;
            SqlDataReader sr;
            query = "SELECT IDENT_CURRENT('COUNTRIES') AS LASTID";
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
