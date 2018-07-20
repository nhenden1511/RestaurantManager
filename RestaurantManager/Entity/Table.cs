using System;
using System.Collections.Generic;
using System.Linq;
using SQLite.Net.Attributes;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Table : Entity 
    {
        public Table()
        {

        }
        public string TableName { get; set; }
    }
}
