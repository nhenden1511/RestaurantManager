using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Position
{
    class EmployeeFunction
    {
        private readonly SQLiteConnection _sqlite;
        public EmployeeFunction(SQLiteConnection sqlite)
        {
            _sqlite = sqlite;
        }
        public bool AddEmployee(string user, string pass, string position,string name,bool isAdmin)
        {
            string sql = "INSERT INTO Employee (Username, Pass, Position,Name,isAdmin)  VALUES('" + user + "', '" + pass + "', '" + position + "','" + name + "'," + 1 + "); ";
            SQLiteCommand command = new SQLiteCommand(sql, _sqlite);
            command.ExecuteNonQuery();
            return true;
        }

        public DataTable LoadEmployee()
        {
            string sql = "select * from Employee";
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql,_sqlite);
            da.Fill(dt);
            return dt;
        }
    }
}
