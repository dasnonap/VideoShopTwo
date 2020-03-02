using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.Classes;

namespace VideoShop.TableClasses
{
    class SeriesTable
    {
        private bool result;
        private string query;

        public bool Insert(Series s)

        {
            query = "EXEC SERIES_INS @producer, @leading, @series_name, @season, @genreID, @seriesYear";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@producer", s.getProd());
            comm.Parameters.AddWithValue("@leading", s.getLead());
            comm.Parameters.AddWithValue("@series_name", s.getName());
            comm.Parameters.AddWithValue("@genreID", s.getGenre());
            comm.Parameters.AddWithValue("@seriesYear", s.getYear());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }

            s.setSeriesID(returnID());

            comm.Dispose();
            result = true;
            return result;
        }


        public bool Update(Series s)
        {
            query = "EXEC SERIES_UPD @id, @prod, @lead, @name, @season, @genre, @year";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", s.getSeriesID());
            comm.Parameters.AddWithValue("@prod", s.getProd());
            comm.Parameters.AddWithValue("@lead", s.getLead());
            comm.Parameters.AddWithValue("@name", s.getName());
            comm.Parameters.AddWithValue("@season", s.getSeason());
            comm.Parameters.AddWithValue("@genre", s.getGenre());
            comm.Parameters.AddWithValue("@year", s.getYear());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }

        public bool Delete(Series s)
        {
            query = "DELETE FROM SERIES WHERE ID = @id";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", s.getSeriesID());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }

        public bool Select(List<Series> series)
        {
            SqlDataReader sr;
            query = "SELECT * FROM SERIES";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            sr = comm.ExecuteReader();
            while (sr.Read())
            {
                series.Add(new Series(sr.GetInt32(0), sr.GetString(1), sr.GetString(2), sr.GetString(3), sr.GetInt32(4), sr.GetInt32(5), Int32.Parse( sr.GetString(6) ) ) );
            }

            sr.Close();
            comm.Dispose();
            return true;

        }
        private int returnID()
        {
            decimal id = 0;
            SqlDataReader sr;
            query = "SELECT IDENT_CURRENT('SERIES') AS LASTID";
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
