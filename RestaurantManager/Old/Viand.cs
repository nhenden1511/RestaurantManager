using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Viand : Entity
    {
        public string Name { get; set; }

        [Indexed(Name = "GENUS_INDEX")]
        public int GenusId { get; set; }

        public int Price { get; set;}
        //[Ignore, JsonIgnore]
        //public IList<Product> Children { get; set; }
    }
}
