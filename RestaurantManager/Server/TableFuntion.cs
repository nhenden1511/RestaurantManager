using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Position
{
    public class TableFunction
    {
        private readonly SQLiteConnection _sqlite;
        public TableFunction(SQLiteConnection sqlite)
        {
            _sqlite = sqlite;
        }
        public bool AddTable(int areaID,string name)
        {
            //try
            //{
                string sql = "INSERT INTO Tables (AreaId,Name,Status)   VALUES('" + areaID + "','" + name + "',0); ";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlite);
                    command.ExecuteNonQuery();
                return true;
            //}
            //catch
            //{
            //    return false;
            //}
        }

        public DataTable LoadTable()
        {
            string sql = "select * from Tables";
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, _sqlite);
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadTableByAreaId(int areaId)
        {
            string sql = "select * from Tables where AreaId='"+areaId+"';";
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, _sqlite);
            da.Fill(dt);
            return dt;
        }

        public bool UpdateTable(int id,string name)
        {
            try
            {
                string sql = "UPDATE Tables SET Name = '" + name + "' WHERE id = '" + id + "' ";
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
                string sql = "DELETE FROM Tables WHERE id = '" + id + "' AND Status ==0; ";
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
