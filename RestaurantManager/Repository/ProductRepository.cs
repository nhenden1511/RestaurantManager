using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class ProductRepository : BaseRepository<Product>
    {
        static readonly Lazy<ProductRepository> _instance = new Lazy<ProductRepository>();

        public static ProductRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public List<Product> GetProductByGroup(int groupId)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<Product>().Where(p=>p.GroupId==groupId && !p.IsDelete).ToList();
                    return result;
                }
            }
        }

        public List<Product> GetProductToInventory(int groupId)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    if (groupId == 0)
                    {
                        return db.Table<Product>().Where(p => !p.IsDelete && p.Total!=0).ToList();
                    }
                    else
                    {
                        return db.Table<Product>().Where(p => !p.IsDelete && p.Total != 0 && p.GroupId==groupId).ToList();
                    }
                }
            }
        }
    }
}
