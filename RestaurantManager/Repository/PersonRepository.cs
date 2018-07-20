using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class PersonRepository : BaseRepository<Person>
    {
        static readonly Lazy<PersonRepository> _instance = new Lazy<PersonRepository>();

        public static PersonRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public Person GetByName(string name)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<Person>().Where(p => p.UserName == name).FirstOrDefault();
                    return result;
                }
            }
        }

        public Person CheckByAdmin()
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<Person>().Where(p => p.IsAddmin == true).FirstOrDefault();
                    return result;
                }
            }
        }
    }
}
