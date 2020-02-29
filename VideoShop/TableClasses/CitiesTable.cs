using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.Classes;

namespace VideoShop.TableClasses
{
    class CitiesTable
    {
        private int result;
        private string query;
        private Connection cn = new Connection();
        public bool Insert(Cities c)
        {
            cn.InitializeConnections();

            query = "EXEC CITIES_INS @name";
            SqlCommand comm = new SqlCommand(query, cn.returnConnection());

            comm.Parameters.Add("@name", c.getCity());
            result = comm.ExecuteNonQuery();
            if(result < 0)
            {
                return false;
            }
            return true;
        }
        public bool Update(Cities c)
        {
            //to do
            query = "EXEC CITIES_UPD @name";
            SqlCommand comm = new SqlCommand(query, cn.returnConnection());

            comm.Parameters.Add("@name", c.getCity());

            if (comm.ExecuteNonQuery() != 0)
            {
                return false;
            }
            return true;
        }
        public bool Delete(Cities c)
        {
            //to do
            query = "";
            SqlCommand comm = new SqlCommand(query, cn.returnConnection());

            comm.Parameters.Add("@name", c.getCity());

            if(comm.ExecuteNonQuery() != 0)
            {
                return false;
            }

            return true;
        }
    }
}
