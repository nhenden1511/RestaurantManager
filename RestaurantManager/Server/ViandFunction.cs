using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Server
{
    public class ViandFunction
    {
        private readonly SQLiteConnection _sqlite;
        public ViandFunction(SQLiteConnection sqlite)
        {
            _sqlite = sqlite;
        }
        public bool AddTable(int genusID, string name,int price)
        {
            try
            {
                string sql = "INSERT INTO Viand (GenusId,Name,price)   VALUES(" + genusID + ",'" + name + "'," + price + "); ";
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

        public DataTable LoadViandByGenusId(int genusId)
        {
            string sql = "select * from Viand where GenusId='" + genusId + "';";
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, _sqlite);
            da.Fill(dt);
            return dt;
        }

        public bool UpdateTable(int id, string name,int price)
        {
            try
            {
                string sql = "UPDATE Viand SET Name = '" + name + "',Price = '" + price + "' WHERE id = '" + id + "' ";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlite);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteTable(int id)
        {
            try
            {
                string sql = "DELETE FROM Viand WHERE id = '" + id + "' ";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlite);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
