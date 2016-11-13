using System.Data;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Server
{
    public class OrderFunction
    {
        private readonly SQLiteConnection _sqlite;
        public OrderFunction(SQLiteConnection sqlite)
        {
            _sqlite = sqlite;
        }
        public bool AddOrder(int tableId,int viandId,string viandName,decimal number,int price,string total,int isGive)
        {
            try
            {
                string sql = "INSERT INTO [Order] (isGive,Total,Price,number,viandName, viandId, TableId)VALUES";
                sql+="("+isGive+",'"+total+"',"+price+","+number+",'"+viandName+"',"+viandId+","+tableId+");";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlite);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateOrder(int tableId, int viandId,decimal number)
        {
            try
            {
                string sql = "UPDATE [Order] SET number = number+"+number+" WHERE tableId = " + tableId + " AND viandId = " + viandId + ";";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlite);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable LoadOrderByTableId(int tableId)
        {
            string sql = "select * from [Order] where tableId='" + tableId + "';";
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, _sqlite);
            da.Fill(dt);
            return dt;
        }
    }
}
