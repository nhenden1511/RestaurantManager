using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class PaymentDetail:Entity
    {
        public PaymentDetail()
        {

        }
        public int PaymentId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set;}
        public int Number { get; set;}
        public PaymentDetail(int payId, int productId, int price, int number)
        {
            PaymentId = payId;
            ProductId = productId;
            Price = price;
            Number = number;
        }
    }
}
