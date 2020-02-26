using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    //connection strings
    
    class Connection
    {
        private String connString;
        private SqlConnection cnn ;

        //dobyr nachin za connection? 
        private void InitializingString()
        {
            connString = "Data Source=DESKTOP-U6A27FU\\IVANSQL; Initial Catalog=VideoShop; User ID=sa; Password=123456";

        }
        public bool InitializeConnections()
        {
            InitializingString();
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
                        query = "EXEC CITIES_INS @name";
                        SqlCommand comm = new SqlCommand(query, cnn);

                        Cities newCity = c as Cities;
                        
                        comm.Parameters.Add( "@name", newCity.getCity() );
                        result = comm.ExecuteNonQuery();

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

    }
}
