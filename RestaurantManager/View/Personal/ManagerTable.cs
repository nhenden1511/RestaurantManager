using RestaurantManager.Position;
using RestaurantManager.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.View.Personal
{
    public partial class ManagerTable : Form
    {
        private string _tableId;
        private string _tableName;
        private OrderFunction _orderFunction;
        private DataTable dt;
        public ManagerTable(string tableId,string tableName)
        {
            InitializeComponent();
            this.Text = tableName;
            _orderFunction = new OrderFunction(DbConnect.XConnect());
            _tableId = tableId;
            _tableName = tableName;
            _txtTableName.Text = tableName;
            CheckSize();
            _grGenus.Font = Contant.GroupFont();
            _grViand.Font = Contant.GroupFont();
            _grProperty.Font = Contant.GroupFont();
            _grDetail.Font = Contant.GroupFont();
            GetGenus();
            _lvGenus.View = System.Windows.Forms.View.List;
            _lvViand.View = System.Windows.Forms.View.List;
            GetOrder();

        }

        private void GetGenus()
        {
            var _genusFunction = new GenusFunction(DbConnect.XConnect());
            DataTable dt = _genusFunction.LoadGenus();

            foreach (DataRow rowGenus in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = rowGenus[1].ToString();
                item.SubItems.Add(rowGenus[0].ToString());
                item.SubItems.Add(rowGenus[1].ToString());
                _lvGenus.Items.Add(item);
            }
            if(_lvGenus.Items.Count>0)
            _lvGenus.Items[0].Selected = true;
        }

        private void GetViand()
        {
            _lvViand.Clear();
            var _viandFunction = new ViandFunction(DbConnect.XConnect());
            var _genusId = Convert.ToInt32(_txtGenusId.Text);
            DataTable dt = _viandFunction.LoadViandByGenusId(_genusId);
            _lvViand.Columns.Add("Tên Món", 200);
            
            foreach (DataRow rowViand in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = rowViand[2].ToString();
                item.SubItems.Add(rowViand["Id"].ToString());
                item.SubItems.Add(rowViand["GenusId"].ToString());
                item.SubItems.Add(rowViand["Name"].ToString());
                item.SubItems.Add(rowViand["Total"].ToString());
                _lvViand.Items.Add(item);
            }
            if (_lvViand.Items.Count > 0)
                _lvViand.Items[0].Selected = true;
        }
        private void ManagerTable_Resize(object sender, EventArgs e)
        {
            CheckSize();
        }
        public void CheckSize()
        {
            var x = this.Width/20;
            var y = this.Height;
            var t = x / 5;

            _grGenus.Size = new Size(x*3, y - 130);
            _grGenus.Left = t;
            _grGenus.Top = 10;

            _grViand.Size = new Size(x * 5, y - 130);
            _grViand.Left = x * 3 + 2*t;
            _grViand.Top = 10;

            _grProperty.Size = new Size(x  * 5, y - 130);
            _grProperty.Left = x  * 8 + 3*t;
            _grProperty.Top = 10;

            _grDetail.Size = new Size(x  * 6, y - 130);
            _grDetail.Left = x * 13 + 4*t;
            _grDetail.Top = 10;
        }
        private void _lvGenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvGenus.SelectedItems.Count == 0)
                return;
            ListViewItem item = _lvGenus.SelectedItems[0];
            _txtGenusId.Text = item.SubItems[1].Text.ToString().Trim();
        }
        private void _txtGenusId_TextChanged(object sender, EventArgs e)
        {
            if (_txtGenusId.Text.Trim() == "") return;
            GetViand();
        }
        private void _lvViand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvGenus.SelectedItems.Count == 0)
                return;
            ListViewItem item = _lvViand.SelectedItems[0];
            _txtViandId.Text = item.SubItems[1].Text.ToString().Trim();
            _txtViandName.Text = item.SubItems[0].Text.ToString().Trim();
            _txtPrice.Text = item.SubItems[4].Text.ToString().Trim();
        }

        private void numericUpDown1_TabIndexChanged(object sender, EventArgs e)
        {
            _txtTolal.Text = (Convert.ToInt32(_txtPrice.Text) * Convert.ToDecimal(_txtNumber.Value)).ToString();
        }

        private void _txtNumber_ValueChanged(object sender, EventArgs e)
        {
            _txtTolal.Text = (Convert.ToInt32(_txtPrice.Text) * Convert.ToDecimal(_txtNumber.Value)).ToString();
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            var listViand = dt.AsEnumerable().Select(r => r.Field<Int64>("viandId")).ToArray();
            var viandId =Convert.ToInt32(_txtViandId.Text);
            if (listViand.Contains(viandId))
                Update();
            else
                Insert();
        }

        private void GetOrder(int row = -1)
        {
            if (_tableId=="") return;
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
                string[] rows = new string[] { item["viandName"].ToString(), number.ToString(), price.ToString(),total };
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
        private void Insert()
        {
            var tableId = Convert.ToInt32(_tableId);
            var viandId = Convert.ToInt32(_txtViandId.Text);
            var viandName = _txtViandName.Text;
            var number = _txtNumber.Value;
            var price = Convert.ToInt32(_txtPrice.Text);
            var total = (price * number).ToString();
            if (_orderFunction.AddOrder(tableId, viandId, viandName, number, price, total, 0))
            {
                MessageBox.Show("Thêm Món Ăn Thành Công");
                GetOrder();
            }
            else
                MessageBox.Show("Không Thêm Được Món Ăn");
        }
        private void Update()
        {
            var tableId = Convert.ToInt32(_tableId);
            var viandId = Convert.ToInt32(_txtViandId.Text);
            var number = _txtNumber.Value;
            if (_orderFunction.UpdateOrder(tableId, viandId, number))
            {
                MessageBox.Show("Thêm Món Ăn Thành Công");
                GetOrder();
            }
            else
                MessageBox.Show("Không Thêm Được Món Ăn");
        }

        private void _btnPayment_Click(object sender, EventArgs e)
        {
            var paymentDiaglog = new PaymentDialog(_tableId, _tableName);
            paymentDiaglog.Show();
        }
    }
}
