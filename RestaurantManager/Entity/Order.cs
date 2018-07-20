using System;
using System.Collections.Generic;
using System.Linq;
using SQLite.Net.Attributes;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Order : Entity 
    {
        public Order()
        {

        }
        public int ProductId { get; set; }
        public string GroupName { get; set; }
        public string GroupCode { get; set; }
        public string ProductCode { get; set; }
        public int Number { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
        public int GroupId { get; set; }


        public Order(int pId, string pName, int pNumber, int pPrice, int groupId)
        {
            ProductId = pId;
            ProductName = pName;
            Number = pNumber;
            Price = pPrice;
            GroupId = groupId;
        }

    }
}
