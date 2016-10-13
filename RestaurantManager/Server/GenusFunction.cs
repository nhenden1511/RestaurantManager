using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Position
{
    public class GenusFunction
    {
        private readonly SQLiteConnection _sqlite;
        public GenusFunction(SQLiteConnection sqlite)
        {
            _sqlite = sqlite;
            //_sqlite.Open();
        }
        public bool AddGenus(string name)
        {
            try
            {
                string sql = "INSERT INTO Genus (Name)  VALUES('" + name + "'); ";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlite);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable LoadGenus()
        {
            string sql = "select * from Genus";
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, _sqlite);
            da.Fill(dt);
            return dt;
        }

        public bool UpdateGenus(int id, string name)
        {
            try
            {
                string sql = "UPDATE Genus SET Name = '" + name + "' WHERE id = '" + id + "' ";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlite);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGenus(int id)
        {
            try
            {
                string sql = "DELETE FROM Genus WHERE id = '" + id + "'; ";
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
