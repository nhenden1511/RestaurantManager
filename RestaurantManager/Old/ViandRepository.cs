using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class ViandRepository : BaseRepository<Viand>
    {
        static readonly Lazy<ViandRepository> _instance = new Lazy<ViandRepository>();

        public static ViandRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public List<Viand> GetViandByGenusId(int id)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<Viand>().Where(p=>p.GenusId==id).ToList();
                    return result;
                }
            }
        }
    }
}
