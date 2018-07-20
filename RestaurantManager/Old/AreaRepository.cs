using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class AreaRepository : BaseRepository<Area>
    {
        static readonly Lazy<AreaRepository> _instance = new Lazy<AreaRepository>();

        public static AreaRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public List<Area> GetFullArea()
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<Area>().ToList();
                    return result;
                }
            }
        }
    }
}
