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
        
        public bool Insert(Cities c)
        {
            query = "EXEC CITIES_INS @name";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection() );

            comm.Parameters.AddWithValue("@name", c.getCity());
          
            if(comm.ExecuteNonQuery() != 0)
            {
                return false;
            }
            comm.Dispose();
            return true;
        }
        public bool Update(Cities c)
        {
            //to do
            query = "EXEC CITIES_UPD @name";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@name", c.getCity());

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
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@name", c.getCity());

            if(comm.ExecuteNonQuery() != 0)
            {
                return false;
            }

            return true;
        }

        public bool Select(List<Cities> cities)
        {
            SqlDataReader sr;
            query = "SELECT * FROM CITIES";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            sr = comm.ExecuteReader();
            while (sr.Read())
            {
                cities.Add(new Cities(sr.GetInt32(0), sr.GetString(1)));
            }

            sr.Close();
            comm.Dispose();
            return true; 
            
        }
        private int returnID()
        {
            SqlDataAdapter sr;
            query = "select IDENT_CURRENT('CITIES') AS LASTID"
        }
       

        /*old connection class 
         private string connString;
        private SqlConnection cnn ;

        public Connection()
        {
            connString = "Data Source=DESKTOP-U6A27FU\\IVANSQL; Initial Catalog=VideoShop; User ID=sa; Password=123456";
        }
        //dobyr nachin za connection? 
        public SqlConnection returnConnection()
        {
            return cnn;
        }
        public bool InitializeConnections()
        {
            cnn = new SqlConnection(connString);
            try
            {
                cnn.Open();
                return true;
            }
            catch(Exception e){
                return false;
            }
        }
        public void CloseConnection()
        {
            cnn.Close();
        }
        
        public bool InsertIntoTables(Object c)
        {
            int result = 0;
            string query;
            

            if (c == null)
            {
                return false;
            }
            
            switch (c.GetType().Name)
            {
                case "Cities":
                    {
                        

                        break;
                    }

                default:
                    break;
            }

           
            if (result < 0)
            {
                return false;
            }


            return true;
            
        }
          */
    }
}
