using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class OrderRepository : BaseRepository<Order>
    {
        static readonly Lazy<OrderRepository> _instance = new Lazy<OrderRepository>();

        public static OrderRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public override int Insert(Order o)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<Order>().Where(p => p.ProductId == o.ProductId).FirstOrDefault();
                    if(result==null||result.Price!=o.Price) return base.Insert(o);
                    result.Number = result.Number + o.Number;
                    result.Total = result.Number * result.Price;
                    return base.Update(result);
                }
            }
        }

        public ReportModel SaveAndGetReport(int _sale = 0, int _ship = 0, int _bonus = 0, string _customer = null)
        {
            var resuilt = new ReportModel();
            var total = 0;
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var order = GetAll();

                    foreach(var each in order)
                    {
                        var product = new ProductModel();
                        product.Number = each.Number;
                        product.Price = each.Price.ToPrice();
                        product.Total = each.Total.ToPrice();
                        product.Product = each.GroupCode + "-" + each.ProductCode;
                        resuilt.Product.Add(product);
                        total += each.Total;
                    }


                    var info = new ReportInfomation();
                    info.Bonus = _bonus.ToPrice();
                    info.Sale = _sale.ToPrice();
                    info.Ship = _ship.ToPrice();
                    info.Payment = (total - _sale + _ship +_bonus).ToPrice();
                    info.Time = DateTime.Now.ToString("hh:mm:ss tt --- dd/MM/yyyy");
                    info.Customer = _customer;
                    resuilt.Information.Add(info);
                }
            }
            resuilt.Payment = new Payment(total - _sale + _ship + _bonus, _sale, _ship, _bonus,_customer);
            //PaymentRepository.Instance.SavePayment(payment);

            return resuilt;
        }

        //public void SavePayment(ReportModel vm)
        //{
        //    var pay = vm.Information.First();
        //    var payment = new Payment(pay.Total.ToInt(), pay.Sale.ToInt(), pay.Ship.ToInt());
        //}

        public void SaveOrder(int id, int number, int price)
        {
            var entity = this.GetById(id);
            if (entity == null) return;

            var product = ProductRepository.Instance.GetById(entity.ProductId);
            product.Total = product.Total + entity.Number - number;
            ProductRepository.Instance.Update(product);

            if (number <= 0) Delete(entity);
            entity.Number = number;
            entity.Price = price;
            entity.Total = number * price;
            this.Update(entity);
        }
        public bool CheckExistOrder()
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var data = GetAll();
                    if(data==null || !data.Any())
                    {
                        return false;
                    }
                    return true;
                }
            }
        }
    }
}
