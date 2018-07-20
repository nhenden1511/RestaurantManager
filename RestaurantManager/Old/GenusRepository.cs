using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class GenusRepository : BaseRepository<Genus>
    {
        static readonly Lazy<GenusRepository> _instance = new Lazy<GenusRepository>();

        public static GenusRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
