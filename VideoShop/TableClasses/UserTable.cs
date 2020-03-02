using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.Classes;

namespace VideoShop.TableClasses
{
    class UserTable
    {
        private bool result;
        private string query;

        public bool Insert(Users c)
        {
            query = "EXEC USERS_INS @userName, @password, @email, @countryID";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@userName", c.getUserName());
            comm.Parameters.AddWithValue("@password", c.getPass());
            comm.Parameters.AddWithValue("@email", c.getEmail());
            comm.Parameters.AddWithValue("@countryID", c.getCountryID());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }

            c.setUserID(returnID());

            comm.Dispose();
            result = true;
            return result;
        }


        public bool Update(Users c)
        {
            query = "EXEC USERS_UPD_NAME @id, @name";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", c.getUserID());
            comm.Parameters.AddWithValue("@name", c.getUserName());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }

        public bool Delete(Users c)
        {
            query = "DELETE FROM [USERS] WHERE USER_ID = @id";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", c.getUserID());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }

        public bool Select(Users c)
        {
           /* SqlDataReader sr;
            query = "SELECT * FROM [USERS] WHERE USER_ID = @id";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", c.getUserID());

            sr = comm.ExecuteReader();
            while (sr.Read())
            {
                .Add(new Countries(sr.GetInt32(0), sr.GetString(1)));
            }

            sr.Close();
            comm.Dispose();
            return true;
            to do
             */

        }
        private int returnID()
        {
            decimal id = 0;
            SqlDataReader sr;
            query = "SELECT IDENT_CURRENT('USERS') AS LASTID";
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
