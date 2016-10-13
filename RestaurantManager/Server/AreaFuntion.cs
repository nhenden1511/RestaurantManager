using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Position
{
    public class AreaFunction
    {
        private readonly SQLiteConnection _sqlite;
        public AreaFunction(SQLiteConnection sqlite)
        {
            _sqlite = sqlite;
            //_sqlite.Open();
        }
        public bool AddArea(string name)
        {
            try
            {
                string sql = "INSERT INTO Area (Name)  VALUES('" + name + "'); ";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlite);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable LoadArea()
        {
            string sql = "select * from Area";
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, _sqlite);
            da.Fill(dt);
            return dt;
        }

        public bool UpdateArea(int id,string name)
        {
            try
            {
                string sql = "UPDATE Area SET Name = '" + name + "' WHERE id = '" + id + "' ";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlite);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteArea(int id)
        {
            try
            {
                string sql = "DELETE FROM Area WHERE id = '"+id+"'; ";
                //sql += "DELETE FROM Tables WHERE AreaId='" + id + "';";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlite);
                command.ExecuteNonQuery();
                //_sqlite.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
