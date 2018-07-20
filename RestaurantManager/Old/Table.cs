using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Table :Entity
    {
        public string Name { get; set; }

        [Indexed(Name = "AREA_INDEX")]
        public int AreaId { get; set; }


        //[Ignore, JsonIgnore]
        //public IList<Product> Children { get; set; }
    }
}
