using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using RestaurantManager.View;
using System.Windows.Forms;
using static RestaurantManager.UtillEnum;

namespace RestaurantManager
{
    public partial class HomeActivitive : Form
    {
        private bool _isExit =false;
        public PaymentType _paymentType = PaymentType.None;
        public HomeActivitive()
        {
            InitializeComponent();
            DbInitialization.InitSQLitePlatform(new SQLite.Net.Platform.Win32.SQLitePlatformWin32(), System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal));

            //var loginDialog = new LoginActivitive();
            //var result = loginDialog.ShowDialog();

            //if (result == DialogResult.Cancel)
            //{
            //    _isExit = true;
            //}

            _txtTotal.Text = Utill.GetListViewOrder(_lvOrder).ToPrice();
            Utill.GetListViewHome(_lvProductGroup, _image);
            Pay();
            _paymentType = ContentRepository.Instance.GetPaymentType();
            if (!OrderRepository.Instance.CheckExistOrder()) _paymentType = PaymentType.None;
        }

        private void _btnProductGroup_Click_1(object sender, EventArgs e)
        {
            var productGroup = new ProductGroupDialog();
            productGroup.ShowDialog();
        }
        
        private void _btnProduct_Click(object sender, EventArgs e)
        {
            var productDialog = new ProductDialog();
            productDialog.Reload();
            productDialog.ShowDialog();
        }
        private void _lvProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvProductGroup.SelectedItems.Count == 0)
                return;
            ListViewItem item = _lvProductGroup.SelectedItems[0];
            _txtGroupId.Text = item.SubItems[1].Text;
        }
        private void _lvProductGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var groupId = _txtGroupId.ToInt();
            if (groupId == 0) return;
            var orderDialog = new OrderDialog(groupId, _paymentType);
            DialogResult result = orderDialog.ShowDialog();
            if (result == DialogResult.Yes)
            {
                _txtTotal.Text = Utill.GetListViewOrder(_lvOrder).ToPrice();
                Pay();
                _paymentType = ContentRepository.Instance.GetPaymentType();
            }
        }
        private void _btnPay_Click(object sender, EventArgs e)
        {
            if (_txtPayment.ToInt() == 0 ||_paymentType==PaymentType.None) return;
            var paymentDialog = new PaymentReportDialog(_paymentType, _txtShip.ToInt(), _txtSale.ToInt(), _txtBonus.ToInt(),_txtCustomer.Text);
            DialogResult result = paymentDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ClearAll();
                //if (!OrderRepository.Instance.CheckExistOrder()) _paymentType = PaymentType.None;
            }
        }

        private void ClearAll()
        {
            _txtBonus.Text = "";
            _txtSale.Text = "";
            _txtShip.Text = "";
            _txtPayment.Text = "";
            _txtCustomer.Text = "";
            _paymentType = PaymentType.None;
            _txtTotal.Text = Utill.GetListViewOrder(_lvOrder).ToPrice();
            ClearProduct();
        }
        private void ClearProduct()
        {
            _txtNumber.Text = "";
            _txtOrderId.Text = "";
            _txtPrice.Text = "";
            _txtProductName.Text = "";
        }
        private void _lvOrder_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;

                using (var headerFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold))
                {
                    e.DrawBackground();
                    e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
                    e.Graphics.DrawString(e.Header.Text, headerFont,
                        Brushes.Black, e.Bounds, sf);
                    e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
                    e.DrawText();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _txtTotal.Text = Utill.GetListViewOrder(_lvOrder).ToPrice();
            Utill.GetListViewHome(_lvProductGroup, _image);
            Pay();

        }

        private void _lvOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvOrder.SelectedItems.Count == 0)
                return;
            ListViewItem item = _lvOrder.SelectedItems[0];
            _txtProductName.Text = item.SubItems[2].Text;
            _txtNumber.Text = item.SubItems[3].Text;
            _txtPrice.Text = item.SubItems[4].Text;
            _txtOrderId.Text = item.SubItems[6].Text;
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            _txtNumber.ReadOnly = true;
            _txtPrice.ReadOnly = true;
            _btnExit.Hide();
            _btnSave.Hide();
        }

        private void _txtNumber_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _txtNumber.ReadOnly = false;
            _btnExit.Show();
            _btnSave.Show();
        }

        private void _txtPrice_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _txtPrice.ReadOnly = false;
            _btnExit.Show();
            _btnSave.Show();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            if (_txtOrderId.ToInt() == 0) return;
            DataHelper.Instance.SaveOrder(_txtOrderId.ToInt(), _txtNumber.ToInt(), _txtPrice.ToInt());
            _txtNumber.ReadOnly = true;
            _txtPrice.ReadOnly = true;
            _btnExit.Hide();
            _btnSave.Hide();
            _txtTotal.Text = Utill.GetListViewOrder(_lvOrder).ToPrice();
            Pay();
            if (!OrderRepository.Instance.CheckExistOrder()) _paymentType = PaymentType.None;
        }

        private void Pay()
        {
            _txtPayment.Text = (_txtTotal.ToInt() + _txtShip.ToInt() - _txtSale.ToInt() +_txtBonus.ToInt()).ToPrice();
        }

        private void _btnCheck1_Click(object sender, EventArgs e)
        {
            var checkDialog = new CheckCount1();
            checkDialog.ShowDialog();
        }
        #region Format
        private void _txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }
        private void _txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }
        private void _txtPrice_TextChanged(object sender, EventArgs e)
        {
            _txtPrice.ToPrice();
        }
        private void _txtShip_TextChanged(object sender, EventArgs e)
        {
            _txtShip.ToPrice();
            Pay();
        }
        private void _txtSale_TextChanged(object sender, EventArgs e)
        {
            _txtSale.ToPrice();
            Pay();
        }
        private void _txtBonus_TextChanged(object sender, EventArgs e)
        {
            _txtBonus.ToPrice();
            Pay();
        }
        private void _txtBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }
        private void _txtShip_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }
        private void _txtSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            var dialogCheckCount = new CheckCountByDate();
            dialogCheckCount.ShowDialog();
        }

        private void HomeActivitive_Load(object sender, EventArgs e)
        {
            if(_isExit)
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var inventory = new ProductInventoryDialog();
            inventory.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])//your specific tabname
            //{
            //    MessageBox.Show("ss");
            //    tabControl1.SelectedTab = tabControl1.TabPages["tabPage3"];
                
            //}
        }
    }
}
