using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RestaurantManager.UtillEnum;

namespace RestaurantManager
{
    public class PaymentRepository : BaseRepository<Payment>
    {
        static readonly Lazy<PaymentRepository> _instance = new Lazy<PaymentRepository>();

        public static PaymentRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        //public override int Insert(Order o)
        //{
        //    lock (DbInitialization.Lockdb)
        //    {
        //        using (var db = NewConnection())
        //        {
        //            var result = db.Table<Order>().Where(p => p.ProductId == o.ProductId).FirstOrDefault();
        //            if(result==null||result.Price!=o.Price) return base.Insert(o);
        //            result.Number = result.Number + o.Number;
        //            result.Total = result.Number * result.Price;
        //            return base.Update(result);
        //        }
        //    }
        //}

        public void SavePayment(Payment entity)
        {
            this.Insert(entity);
            var order = OrderRepository.Instance.GetAll();
            foreach(var each in order)
            {
                var detail = new PaymentDetail(entity.Id, each.ProductId, each.Price, each.Number);
                PaymentDetailRepository.Instance.Insert(detail);
            }
            OrderRepository.Instance.DeleteAll();
        }
        public ReportModel GetReportDetail(int payId)
        {
            var resuilt = new ReportModel();
            var payment = this.GetById(payId);
            var order = PaymentDetailRepository.Instance.GetBypaymentId(payId);
            var total = 0;

            foreach (var each in order)
            {
                var product = new ProductModel();
                product.Number = each.Number;
                product.Price = each.Price.ToPrice();
                product.Total = (each.Number * each.Price).ToPrice();

                var pr = ProductRepository.Instance.GetById(each.ProductId);
                var gr = ProductGroupRepository.Instance.GetById(pr.GroupId);


                product.Product = gr.Code + "-" + pr.Code;
                resuilt.Product.Add(product);
                total += (each.Number * each.Price);
            }


            var info = new ReportInfomation();
            info.Bonus = payment.Bonus.ToPrice();
            info.Sale = payment.Sale.ToPrice();
            info.Ship = payment.Ship.ToPrice();
            info.Payment = payment.Total.ToPrice();
            info.Customer = payment.Customer;
            info.Time = payment.Time.ToString("hh:mm:ss tt --- dd/MM/yyyy");
            resuilt.Information.Add(info);

            return resuilt;
        }

        public CheckCountModel GetCheckCount(DateTime t1, DateTime t2)
        {
            var model = new CheckCountModel();
            var allProduct = new List<Product>();
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    model.Payment = db.Table<Payment>().Where(p => t1.Date < p.Time && p.Time < t2.Date).ToList();
                }
            }
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    allProduct = db.Table<Product>().ToList();
                }
            }

            var listShop = model.Payment.Where(p => p.PaymentType == PaymentType.PaymentShop).ToList();
            var listOnline = model.Payment.Where(p => p.PaymentType == PaymentType.PaymentOnline).ToList();
            var listMuti = model.Payment.Where(p => p.PaymentType == PaymentType.PaymentMutiple).ToList();

            model.CountShop = listShop.Count;
            foreach(var each in listShop)
            {
                model.SumShop += each.Total;
                var product = PaymentDetailRepository.Instance.GetBypaymentId(each.Id); //ToDo CHeck Perfomance
                foreach(var item in product)
                {
                    model.PriceShop += item.Number * allProduct.Where(p=>p.Id==item.ProductId).FirstOrDefault().Cost;
                }
            }
            model.SumAllShop = model.SumShop - model.PriceShop;


            model.CountOnline = listOnline.Count;
            foreach (var each in listOnline)
            {
                model.SumOnline += each.Total;
                var product = PaymentDetailRepository.Instance.GetBypaymentId(each.Id); //ToDo CHeck Perfomance
                foreach (var item in product)
                {
                    model.PriceOnline += item.Number * allProduct.Where(p => p.Id == item.ProductId).FirstOrDefault().Cost;
                }
            }
            model.SumAllOnline = model.SumOnline - model.PriceOnline;


            model.CountMuti = listMuti.Count;
            foreach (var each in listMuti)
            {
                model.SumMuti += each.Total;
                var product = PaymentDetailRepository.Instance.GetBypaymentId(each.Id); //ToDo CHeck Perfomance
                foreach (var item in product)
                {
                    model.PriceMuti += item.Number * allProduct.Where(p => p.Id == item.ProductId).FirstOrDefault().Cost;
                }
            }
            model.SumAllMuti = model.SumMuti - model.PriceMuti;


            return model;
        }

    }
}
