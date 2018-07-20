using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.View
{
    public partial class AddProduct : Form
    {
        public static readonly AddProduct _instance = new AddProduct();
        private static bool icheck;
        static string _imageUrl;
        static string _fileName;
        public static AddProduct Instance
        {
            get
            {
                return _instance;
            }
        }
        public void Reload()
        {
            icheck = false;
            Utill.ComboGroup(_cbbGroup);
            icheck = true;
        }
        public AddProduct()
        {
            InitializeComponent();
            icheck = false;
            Utill.ComboGroup(_cbbGroup);
            icheck = true;
        }

        private void _cbbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = _cbbGroup.SelectedItem as ProductGroup;
            _txtGroupId.Text = data.Id.ToString();
            if(icheck)
            DataHelper.Instance.SetDefaultProductGroup(data.Id);
        }

        private void _btnImage_Click(object sender, EventArgs e)
        {
            this._openImage.ShowDialog();
            _fileName = this._openImage.FileName;

            if (_fileName == "openFileDialog1") return;

            Image myImage = Image.FromFile(_fileName);

            _picShow.Image = myImage;

            //save picture
            _openImage.Title = "Select a Image";
            _openImage.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            string appPath = Utill.PathImage() + @"\"+_txtGroupId.Text + @"\"; 
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---
            _imageUrl = appPath + _openImage.SafeFileName + "_" + DateTime.Now.ToBinary() + ".jpg";
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            AddNewProduct();
        }
        private void AddNewProduct()
        {
            var name = _txtName.Text;
            var code = _txtCode.Text;
            var cost = _txtCost.Text.ToInt();
            uint price = _txtPrice.ToUInt();
            uint prices = _txtPrices.ToUInt();
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(code))
            {
                MessageBox.Show("Bạn chưa nhập Tên hoặc Mã nhóm sản phẩm!");
                return;
            }
            if (price == 0 || prices == 0 || cost == 0)
            {
                MessageBox.Show("Bạn chưa nhập đủ giá sản phẩm!");
                return;
            }

            var product = new Product(_txtGroupId.ToInt(), name, code, price, prices, cost);
            product.Total = _txtTotal.ToInt();
            if (_imageUrl != null)
            {
                product.Image = _imageUrl;
            }
            DataHelper.Instance.InsertProduct(product);
            if (_fileName != null && _imageUrl != null) File.Copy(_fileName, _imageUrl, true);

            _txtName.Text = "";
            _txtCode.Text = "";
            _txtPrice.Text = "";
            _txtPrices.Text = "";
            _txtTotal.Text = "";
            _txtCost.Text = "";
            _imageUrl = null;
            _picShow.Image = null;
            _txtName.Select();
            this.Close();
            DialogResult = DialogResult.Yes;
        }

        #region Set Format
        private void _txtCost_TextChanged(object sender, EventArgs e)
        {
            _txtCost.ToPrice();
        }
        private void _txtPrice_TextChanged(object sender, EventArgs e)
        {
            _txtPrice.ToPrice();
        }
        private void _txtPrices_TextChanged(object sender, EventArgs e)
        {
            _txtPrices.ToPrice();
        }
        private void _txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }
        private void _txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }
        private void _txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }
        private void _txtPrices_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }
        #endregion
    }
}
