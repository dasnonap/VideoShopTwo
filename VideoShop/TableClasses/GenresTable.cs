using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.Classes;

namespace VideoShop.TableClasses
{
    class GenresTable
    {
        private bool result;
        private string query;

        public bool Insert(Genres g)
        {
            query = "EXEC GENRES_INS @name";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@name", g.getGenreName());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }

            g.setGenreID(returnID());

            comm.Dispose();
            result = true;
            return result;
        }


        public bool Update(Genres g)
        {
            query = "EXEC GENRES_UPD @id, @name";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", g.getGenreID());
            comm.Parameters.AddWithValue("@name", g.getGenreName());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }


        public bool Delete(Genres g)
        {
            query = "DELETE FROM GENRES WHERE COUNTRY_ID = @id";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", g.getGenreID());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }


        public bool Select(List<Genres> genres)
        {
            SqlDataReader sr;
            query = "SELECT * FROM GENRES";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            sr = comm.ExecuteReader();
            while (sr.Read())
            {
                genres.Add(new Genres(sr.GetInt32(0), sr.GetString(1)));
            }

            sr.Close();
            comm.Dispose();
            return true;

        }
        private int returnID()
        {
            decimal id = 0;
            SqlDataReader sr;
            query = "SELECT IDENT_CURRENT('GENRES') AS LASTID";
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
