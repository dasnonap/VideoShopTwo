using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.Classes;

namespace VideoShop.TableClasses
{
    class StaffPosTable
    {
        private bool result;
        private string query;

        public bool Insert(StaffPositions c)
        {
            query = "EXEC POSITIONS_INS @desc";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@desc", c.getPosName());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }

            c.setPosID(returnID());

            comm.Dispose();
            result = true;
            return result;
        }


        public bool Update(StaffPositions c)
        {
            query = "EXEC POSITIONS_UPD @id, @desc";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", c.getPosID());
            comm.Parameters.AddWithValue("@desc", c.getPosName());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }

        public bool Delete(StaffPositions c)
        {
            query = "DELETE FROM POSITIONS WHERE POS_ID = @id";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            comm.Parameters.AddWithValue("@id", c.getPosID());

            if (comm.ExecuteNonQuery() < 0)
            {
                result = false;
            }
            comm.Dispose();

            result = true;
            return result;
        }


        public bool Select(List<StaffPositions> positions)
        {
            SqlDataReader sr;
            query = "SELECT * FROM POSITIONS";
            SqlCommand comm = new SqlCommand(query, Connection.Instance.returnConnection());

            sr = comm.ExecuteReader();
            while (sr.Read())
            {
                positions.Add(new StaffPositions(sr.GetInt32(0), sr.GetString(1)));
            }

            sr.Close();
            comm.Dispose();
            return true;

        }
        private int returnID()
        {
            decimal id = 0;
            SqlDataReader sr;
            query = "SELECT IDENT_CURRENT('POSITIONS') AS LASTID";
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
