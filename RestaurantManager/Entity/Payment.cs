using System;
using System.Collections.Generic;
using System.Linq;
using SQLite.Net.Attributes;
using System.Threading.Tasks;
using static RestaurantManager.UtillEnum;

namespace RestaurantManager
{
    public class Payment : Entity 
    {
        public Payment()
        {

        }
        public int Total { get; set; }
        public int Sale { get; set; }
        public int Ship { get; set; }
        public int Bonus { get; set; }
        public string Customer { get; set; }
        public PaymentType PaymentType { get; set; }
        private DateTime _time;
        public DateTime Time
        {
            get
            {
                return _time.ToDeserialize();
            }
            set { _time = value; }
        }
        public Payment(int total, int sale, int ship, int bonus,string customer)
        {
            Total = total;
            Sale = sale;
            Ship = ship;
            Bonus = bonus;
            Customer = customer;
            Time = DateTime.Now;
        }
    }
}
