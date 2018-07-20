using System;
using System.Collections.Generic;
using SQLite.Net.Attributes;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Product : Entity 
    {
        public Product()
        {

        }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Image { get; set; }
        public int Cost { get; set; }
        public uint Price { get; set; }
        public uint Prices { get; set; }
        public int Total { get; set; }
        public int GroupId { get; set; }
        public Product(int groupId, string name, string code, uint price, uint prices, int cost)
        {
            GroupId = groupId;
            Name = name;
            Code = code;
            Price = price;
            Prices = prices;
            Cost = cost;
        }
    }
}
