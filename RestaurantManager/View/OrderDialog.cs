using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RestaurantManager.UtillEnum;

namespace RestaurantManager.View
{
    public partial class OrderDialog : Form
    {
        private static int _groupId;
        private static bool _isMuti=false;
        public PaymentType _paymentType = PaymentType.None;
        private bool _isChangeType;
        public int Group
        {
            get { return _groupId; }
            set { _groupId = value; }
        }
        public OrderDialog(int groupId, PaymentType paymentType)
        {
            InitializeComponent();
            _paymentType = paymentType;
            if (_paymentType == PaymentType.None) _isChangeType = true;
            _groupId = groupId;
            _txtGroupId.Text = _groupId.ToString();
            Utill.ComboGroup(_cbbGroup, _groupId);
            _btnSingle.BackColor = Color.CornflowerBlue;

            Utill.SetLabel(new List<Label>() { label1, label2, label3, label4, label5 });
            Utill.SetTexbox(new List<TextBox>() { _txtCode, _txtName, _txtPrice });

            if (_paymentType == PaymentType.PaymentShop)
            {
                _btnSingle.BackColor = Color.CornflowerBlue;
                _btnSingleOnline.BackColor = Color.WhiteSmoke;
                _btnMuti.BackColor = Color.WhiteSmoke;
            }
            else if(_paymentType == PaymentType.PaymentOnline)
            {
                _btnSingle.BackColor = Color.WhiteSmoke;
                _btnSingleOnline.BackColor = Color.CornflowerBlue;
                _btnMuti.BackColor = Color.WhiteSmoke;
            }
            if (_paymentType == PaymentType.PaymentMutiple)
            {
                _btnSingleOnline.BackColor = Color.WhiteSmoke;
                _btnSingle.BackColor = Color.WhiteSmoke;
                _btnMuti.BackColor = Color.CornflowerBlue;
                _isMuti = true;
            }
            Utill.GetListViewProduct(_lvProduct, _groupId, _isMuti, 0, true);
        }

        private void _lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvProduct.SelectedItems.Count == 0)
                return;
            ListViewItem item = _lvProduct.SelectedItems[0];
            _txtCode.Text = item.SubItems[0].Text;
            _txtName.Text = item.SubItems[1].Text;
            _txtPrice.Text = item.SubItems[2].Text;
            _txtProductId.Text = item.SubItems[3].Text;
            _txtImage.Text = item.SubItems[4].Text;
            _txtTotal.Text = item.SubItems[5].Text;
            if (_txtImage.Text != null)
            {
                try
                {
                    Image myImage = Image.FromFile(_txtImage.Text);
                    _picShow.Image = myImage;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    _picShow.Image = null;
                }

            }
            else
            {
                _picShow.Image = null;
            }
            _txtPrice.ReadOnly = true;
        }

        private void _btnSingle_Click(object sender, EventArgs e)
        {
            if (!_isChangeType) return;
            _btnSingle.BackColor = Color.CornflowerBlue;
            _btnSingleOnline.BackColor = Color.WhiteSmoke;
            _btnMuti.BackColor = Color.WhiteSmoke;
            _isMuti = false;
            Utill.GetListViewProduct(_lvProduct, _groupId, _isMuti, _txtProductId.ToInt(),true);
            _paymentType = PaymentType.PaymentShop;
        }
        private void _btnSingleOnline_Click(object sender, EventArgs e)
        {
            if (!_isChangeType) return;
            _btnSingle.BackColor = Color.WhiteSmoke;
            _btnSingleOnline.BackColor = Color.CornflowerBlue;
            _btnMuti.BackColor = Color.WhiteSmoke;
            _isMuti = false;
            Utill.GetListViewProduct(_lvProduct, _groupId, _isMuti, _txtProductId.ToInt(), true);
            _paymentType = PaymentType.PaymentOnline;
        }
        private void _btnMuti_Click(object sender, EventArgs e)
        {
            if (!_isChangeType) return;
            _btnSingleOnline.BackColor = Color.WhiteSmoke;
            _btnSingle.BackColor = Color.WhiteSmoke;
            _btnMuti.BackColor = Color.CornflowerBlue;
            _isMuti = true;
            _paymentType = PaymentType.PaymentMutiple;

            Utill.GetListViewProduct(_lvProduct, _groupId, _isMuti, _txtProductId.ToInt(),true);
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (_txtPrice.Check())
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm!");
                return;
            }
            if (_txtNumber.ToInt()==0)
            {
                MessageBox.Show("Bạn chưa chọn số lượng bán!");
                return;
            }
            if (_txtNumber.ToInt() > _txtTotal.ToInt())
            {
                MessageBox.Show("Sản phẩm này không đủ số lượng trong kho!");
                return;
            }
            var order = new Order(_txtProductId.ToInt(),_txtName.Text,_txtNumber.ToInt(),_txtPrice.ToInt(),_groupId);
            DataHelper.Instance.InsertOrder(order);
            if (_paymentType == PaymentType.None) _paymentType = PaymentType.PaymentShop;
            ContentRepository.Instance.UpdatePaymentType(_paymentType);
            Clear();
            Utill.GetListViewProduct(_lvProduct, _groupId,false,0,true);
            DialogResult = DialogResult.Yes;
        }

        private void Clear()
        {
            _txtCode.Text = "";
            _txtGroupId.Text = "";
            _txtImage.Text = "";
            _txtName.Text = "";
            _txtNumber.Text = "";
            _txtPrice.Text = "";
            _txtProductId.Text = "";
            _txtTotal.Text = "";
            _txtPrice.ReadOnly = true;

        }

        private void _btnChange_Click(object sender, EventArgs e)
        {
            _txtPrice.ReadOnly = false;
        }

        private void _cbbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = _cbbGroup.SelectedItem as ProductGroup;
            _txtGroupId.Text = data.Id.ToString();
            _groupId= data.Id;
            Utill.GetListViewProduct(_lvProduct, _groupId,false,0,true);
            Clear();
        }

        private void _lvProduct_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void _txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }

        private void _txtPrice_TextChanged(object sender, EventArgs e)
        {
            _txtPrice.ToPrice();
        }
    }
}
