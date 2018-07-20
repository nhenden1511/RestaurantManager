using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class PaymentDetailRepository : BaseRepository<PaymentDetail>
    {
        static readonly Lazy<PaymentDetailRepository> _instance = new Lazy<PaymentDetailRepository>();

        public static PaymentDetailRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public IList<PaymentDetail> GetBypaymentId(int payId)
        {
            var resuilt = new List<PaymentDetail>();
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.Table<PaymentDetail>().Where(p => p.PaymentId == payId).ToList();
                }
            }
        }
        
    }
}
