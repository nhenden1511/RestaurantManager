using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Person : Entity 
    {
        public Person()
        {

        }
        public string UserName { get; set; }
        public string Passcode { get; set; }
        public bool IsAddmin { get; set; }
    }
}
