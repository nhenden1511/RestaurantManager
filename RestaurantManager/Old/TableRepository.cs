using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class TableRepository : BaseRepository<Table>
    {
        static readonly Lazy<TableRepository> _instance = new Lazy<TableRepository>();

        public static TableRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public List<Table> GetTableByAreaId(int id)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<Table>().Where(p=>p.AreaId==id).ToList();
                    return result;
                }
            }
        }
    }
}
