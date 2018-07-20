using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class ProductGroup : Entity 
    {
        public ProductGroup()
        {

        }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Image { get; set; }
        public ProductGroup(string name, string code)
        {
            Name = name;
            Code = code;
        }
    }
}
