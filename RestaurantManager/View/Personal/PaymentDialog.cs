using RestaurantManager.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.View.Personal
{
    public partial class PaymentDialog : Form
    {
        private readonly string _tableId;
        private readonly string _tableName;
        private OrderFunction _orderFunction;
        private DataTable dt;


        public PaymentDialog(string tableId,string tableName)
        {
            InitializeComponent();
            _orderFunction = new OrderFunction(DbConnect.XConnect());
            _tableId = tableId;
            _tableName = tableName;
            _txtTable.Text = _tableName;
            _date.Format = DateTimePickerFormat.Custom;
            _date.CustomFormat = "dd-MM-yyyy";
            GetOrder();
        }
        private void GetOrder(int row = -1)
        {
            if (_tableId == "") return;
            _dgOrderDetail.Rows.Clear();
            dt = _orderFunction.LoadOrderByTableId(Convert.ToInt32(_tableId));
            _dgOrderDetail.ColumnCount = 4;
            _dgOrderDetail.RowHeadersVisible = false;
            _dgOrderDetail.Columns[0].Name = "Tên Món";
            _dgOrderDetail.Columns[1].Name = "Số Lượng";
            _dgOrderDetail.Columns[1].Width = 60;
            _dgOrderDetail.Columns[2].Width = 70;
            _dgOrderDetail.Columns[2].Name = "Giá";
            _dgOrderDetail.Columns[3].Name = "Thành Tiền";
            foreach (DataRow item in dt.Rows)
            {
                string total = item["isGive"].ToString();
                var number = Convert.ToInt32(item["number"]);
                var price = Convert.ToInt32(item["price"]);
                if (item["isGive"].ToString() == "False")
                    total = (number * price).ToString();
                else
                    total = "Món Tặng";
                string[] rows = new string[] { item["viandName"].ToString(), number.ToString(), price.ToString(), total };
                _dgOrderDetail.Rows.Add(rows);
            }

            //_dgOrderDetail.DataSource = dt;
            //_dgOrderDetail.AllowUserToAddRows = false;
            //_dgOrderDetail.RowHeadersVisible = false;
            //_dgOrderDetail.Columns[0].Visible = false;
            //_dgOrderDetail.Columns[1].Visible = false;
            //_dgOrderDetail.Columns[2].Visible = false;

            //_dgOrderDetail.Columns[3].Width = 175;
            //_dgOrderDetail.Columns[3].HeaderText = "Tên Món";
            //_dgOrderDetail.Columns[4].Width = 50;
            //_dgOrderDetail.Columns[4].HeaderText = "SL";
            //_dgOrderDetail.Columns[5].Width = 80;
            //_dgOrderDetail.Columns[5].HeaderText = "Đơn Giá";
            //_dgOrderDetail.Columns[6].Width = 80;
            //_dgOrderDetail.Columns[6].HeaderText = "Thành Tiền";

            //_dgOrderDetail.Columns[7].Visible = false;
            //_dgOrderDetail.ReadOnly = true;
            Contant.UpdateFont(_dgOrderDetail);
            _dgOrderDetail.ReadOnly = true;
        }
    }
}
