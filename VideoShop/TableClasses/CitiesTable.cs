﻿using System;
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
        private bool result;
        private string query;
        public bool Insert(Cities c)
        {
            query = "EXEC CITIES_INS @name";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@name", c.getCity());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }

            c.setID(returnID());

            comm.Dispose();
            result = true;
            return result;
        }
        public bool Update(Cities c)
        {
            //to do
            query = "EXEC CITIES_UPD @id, @name";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", c.getId());
            comm.Parameters.AddWithValue("@name", c.getCity());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;


        }
        public bool Delete(Cities c)
        {
            //to do
            query = "DELETE FROM CITIES WHERE CITY_ID = @id";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", c.getId());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
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
            decimal id = 0;
            SqlDataReader sr;
            query = "SELECT IDENT_CURRENT('CITIES') AS LASTID";
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

