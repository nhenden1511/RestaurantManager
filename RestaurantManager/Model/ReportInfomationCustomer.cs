using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class ReportInfomationCustomer
    {
        public ReportInfomationCustomer()
        {
        }
        public string Time { get; set; }

        public string Bonus { get; set; }
        public string Sale { get; set; }
        public string Ship { get; set; }
        public string Payment { get; set; }
        public string Customer { get; set; }
    }
}
