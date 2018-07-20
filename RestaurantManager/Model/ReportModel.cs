using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class ReportModel
    {
        public ReportModel()
        {
            Product = new List<ProductModel>();
            Information = new List<ReportInfomation>();
        }

        public IList<ProductModel> Product { get; set; }
        public IList<ReportInfomation> Information { get; set; }
        public Payment Payment { get; set; }
    }
}
