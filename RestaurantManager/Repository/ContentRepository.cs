using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RestaurantManager.UtillEnum;

namespace RestaurantManager
{
    public class ContentRepository : BaseRepository<Content>
    {
        static readonly Lazy<ContentRepository> _instance = new Lazy<ContentRepository>();

        public static ContentRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public List<Content> GetFullProduct()
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<Content>().ToList();
                    return result;
                }
            }
        }
        public PaymentType GetPaymentType()
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<Content>().Where(p => p.Key == Contant.PAYMENTTYPE).FirstOrDefault();
                    if (result == null)
                    {
                        return PaymentType.None;
                    }
                    else
                    {
                        return (PaymentType)(Convert.ToInt32(result.Value));
                    }
                }
            }
        }

        public void UpdatePaymentType(PaymentType type)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<Content>().Where(p => p.Key == Contant.PAYMENTTYPE).FirstOrDefault();
                    if (result == null)
                    {
                        this.Insert(new Content() { Key = Contant.PAYMENTTYPE, Value = ((int)type).ToString(), });
                    }
                    else
                    {
                        result.Value = ((int)type).ToString();
                        Update(result);
                    }
                }
            }
        }

    }
}
