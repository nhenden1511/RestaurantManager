using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class ProductModel
    {
        public ProductModel()
        {
        }
        public string Product { get; set; }
        public int Number { get; set; }
        public string Price { get; set; }
        public string Total { get; set; }

    }
}
