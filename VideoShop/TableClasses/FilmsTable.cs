using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.Classes;

namespace VideoShop.TableClasses
{
    class FilmsTable
    {
        private bool result;
        private string query;

        public bool Insert(Films f)
        {
            query = "EXEC FILMS_INS @producer, @leading, @film_name, @genreID, @filmYear";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@producer", f.getProducer());
            comm.Parameters.AddWithValue("@leading", f.getLeading());
            comm.Parameters.AddWithValue("@film_name", f.getName());
            comm.Parameters.AddWithValue("@genreID", f.getName());
            comm.Parameters.AddWithValue("@filmYear", f.getYear());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }

            f.setID(returnID());

            comm.Dispose();
            result = true;
            return result;
        }

        public bool Update(Films f)
        {
            query = "EXEC FILMS_UPD @id, @prod, @lead, @name, @genre, @year";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", f.getID());
            comm.Parameters.AddWithValue("@prod", f.getProducer());
            comm.Parameters.AddWithValue("@lead", f.getLeading());
            comm.Parameters.AddWithValue("@name", f.getName());
            comm.Parameters.AddWithValue("@genre", f.getName());
            comm.Parameters.AddWithValue("@year", f.getYear());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }

        public bool Delete(Films f)
        {
            query = "DELETE FROM FILMS WHERE ID = @id";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", f.getID());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }

        public bool Select(List<Films> films)
        {
            SqlDataReader sr;
            query = "SELECT * FROM FILMS";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            sr = comm.ExecuteReader();
            while (sr.Read())
            {
                films.Add(new Films(sr.GetInt32(0), sr.GetString(1), sr.GetString(2), sr.GetString(3), sr.GetInt32(4), Int32.Parse(sr.GetString(5)) ) );
            }

            sr.Close();
            comm.Dispose();
            return true;

        }
        private int returnID()
        {
            decimal id = 0;
            SqlDataReader sr;
            query = "SELECT IDENT_CURRENT('FILMS') AS LASTID";
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
