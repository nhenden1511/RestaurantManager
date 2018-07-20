using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.View
{
    public partial class ProductDialog : Form
    {
        private static bool check;
        static string _imageUrl;
        static string _fileName;
        static int _groupId;
        public void Reload()
        {
            check = false;
            Utill.ComboGroup(_cbbGroup);
            check = true;
        }
        public ProductDialog()
        {
            InitializeComponent();
            Utill.ComboGroup(_cbbGroup);
            _groupId = _txtGroupId.ToInt();
            if (_groupId != 0) Utill.GridProduct(_dgProduct, _groupId);
            check = true;
            _btnSave.Hide();
            _btnDelete.Hide();
            _btnImage.Hide();
            _txtCode.ReadOnly = true;
            _txtName.ReadOnly = true;
            _txtPrice.ReadOnly = true;
            _txtPrices.ReadOnly = true;
            _txtTotal.ReadOnly = true;
        }

        private void _cbbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = _cbbGroup.SelectedItem as ProductGroup;
            _txtGroupId.Text = data.Id.ToString();
            _groupId = data.Id;
            if (check)
            DataHelper.Instance.SetDefaultProductGroup(data.Id);
            Utill.GridProduct(_dgProduct, data.Id);
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            //var addProduct = AddProduct.Instance;
            //addProduct.Reload();
            //addProduct.ShowDialog();
            var dialog = new AddProduct();
            DialogResult result = dialog.ShowDialog();
            while (result == DialogResult.Yes)
            {
                Utill.GridProduct(_dgProduct, _groupId);
                result = dialog.ShowDialog();
            }
        }

        private void _dgProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var row = e.RowIndex;
            _txtProductId.Text = _dgProduct.Rows[row].Cells[0].Value.ToString();
            _txtCode.Text = _dgProduct.Rows[row].Cells[1].Value.ToString();
            _txtName.Text = _dgProduct.Rows[row].Cells[2].Value.ToString();
            _txtPrice.Text = _dgProduct.Rows[row].Cells[3].Value.ToString();
            _txtPrices.Text = _dgProduct.Rows[row].Cells[4].Value.ToString();
            _txtTotal.Text = _dgProduct.Rows[row].Cells[6].Value.ToString();
            _txtBasePrice.Text = _dgProduct.Rows[row].Cells[7].Value.ToString();
            if (_dgProduct.Rows[row].Cells[5].Value != null)
            {
                _imageUrl = _dgProduct.Rows[row].Cells[5].Value.ToString();
                try
                {
                    Image myImage = Image.FromFile(_imageUrl);
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
            _btnDelete.Hide();
            _btnSave.Hide();
            _btnImage.Hide();
            _txtCode.ReadOnly = true;
            _txtName.ReadOnly = true;
            _txtPrice.ReadOnly = true;
            _txtPrices.ReadOnly = true;
        }

        private void _btnChange_Click(object sender, EventArgs e)
        {
            if (_txtGroupId.ToInt() == 0) return;
            _btnSave.Show();
            _btnImage.Show();
            _btnDelete.Show();
            _txtCode.ReadOnly = false;
            _txtName.ReadOnly = false;
            _txtPrice.ReadOnly = false;
            _txtPrices.ReadOnly = false;
            _txtTotal.ReadOnly = false;
        }

        private void _btnImage_Click(object sender, EventArgs e)
        {
            this._openImage.ShowDialog();
            _fileName = this._openImage.FileName;

            if (_fileName == "_openImage" || _fileName == "openFileDialog1") return;

            Image myImage = Image.FromFile(_fileName);

            _picShow.Image = myImage;

            //save picture
            _openImage.Title = "Select a Image";
            _openImage.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            string appPath = Utill.PathImage() + @"\" + _txtGroupId.Text + @"\";
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---
            _imageUrl = appPath + _openImage.SafeFileName + "_" + DateTime.Now.ToBinary() + ".jpg";
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            var id = _txtProductId.ToInt();
            var product = DataHelper.Instance.GetProduct(id);
            if (product == null) return;
            var price = _txtPrice.ToUInt();
            var prices = _txtPrices.ToUInt();
            if (_txtCode.Check())
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm!");
                return;
            }
            if (_txtName.Check())
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm!");
                return;
            }
            if (price == 0 || prices == 0)
            {
                MessageBox.Show("Bạn chưa nhập giá sản phẩm!");
                return;
            }
            product.Code = _txtCode.Text;
            product.Name = _txtName.Text;
            product.Price = price;
            product.Prices = prices;
            product.Total = _txtTotal.ToInt();

            if (_imageUrl != null && _fileName!=null)
            {
                product.Image = _imageUrl;
                File.Copy(_fileName, _imageUrl, false);
            }
            DataHelper.Instance.UpdateProduct(product);

            _btnSave.Hide();
            _btnDelete.Hide();
            _btnImage.Hide();
            _txtCode.ReadOnly = true;
            _txtName.ReadOnly = true;
            _txtPrice.ReadOnly = true;
            _txtTotal.ReadOnly = true;
            _txtPrices.ReadOnly = true;
            _fileName = null;
            _imageUrl = null;
            Utill.GridProduct(_dgProduct,_txtGroupId.ToInt());

        }

        private void _txtPrice_TextChanged(object sender, EventArgs e)
        {
            _txtPrice.ToPrice();
        }

        private void _txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }

        private void _txtPrices_TextChanged(object sender, EventArgs e)
        {
            _txtPrices.ToPrice();
        }

        private void _txtPrices_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }

        private void _txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IsNumber();
        }

        private void _txtBasePrice_TextChanged(object sender, EventArgs e)
        {
            _txtBasePrice.ToPrice();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            var delete = new DeleteProductDialog(_txtProductId.ToInt(), _txtCode.Text);
            DialogResult deleteDialog = delete.ShowDialog();
            if (deleteDialog == DialogResult.OK)
            {
                Reload();
            }
        }
    }
}
