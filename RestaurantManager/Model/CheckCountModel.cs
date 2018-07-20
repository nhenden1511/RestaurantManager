using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class CheckCountModel
    {
        public CheckCountModel()
        {
            Payment = new List<Payment>();
        }

        public int CountShop { get; set;}
        public int SumShop { get; set; }
        public int PriceShop { get; set; }
        public int SumAllShop { get; set; }
        public IList<Payment> Payment { get; set; }

        public int CountOnline { get; set; }
        public int SumOnline { get; set; }
        public int PriceOnline { get; set; }
        public int SumAllOnline { get; set; }

        public int CountMuti { get; set; }
        public int SumMuti { get; set; }
        public int PriceMuti { get; set; }
        public int SumAllMuti { get; set; }
    }
}
