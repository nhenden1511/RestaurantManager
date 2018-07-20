using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class AddProductGroup : Form
    {
        static readonly AddProductGroup _instance = new AddProductGroup();
        static string _imageUrl;
        static string _fileName;
        public AddProductGroup()
        {
            InitializeComponent();
            _txtName.Select();
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            AddNewProductGroup();
        }

        private void AddNewProductGroup()
        {
            var name = _txtName.Text;
            var code = _txtCode.Text;
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(code))
            {
                MessageBox.Show("Bạn chưa nhập Tên hoặc Mã nhóm sản phẩm!");
                return;
            }

            var productGroup = new ProductGroup(name, code);
            if (_imageUrl != null)
            {
                productGroup.Image = _imageUrl;
            }
            DataHelper.Instance.InsertProductGroup(productGroup);
            if (_fileName != null && _imageUrl != null) File.Copy(_fileName, _imageUrl, true);
            _txtName.Text = "";
            _txtCode.Text = "";
            _picShow.Image = null;
            _txtName.Select();
            this.Close();
            DialogResult = DialogResult.Yes;
        }

        private void _btnImage_Click(object sender, EventArgs e)
        {
            this._openImage.ShowDialog();
            _fileName = this._openImage.FileName;

            if (_fileName== "_openImage") return;

            Image myImage = Image.FromFile(_fileName);

            _picShow.Image = myImage;

            //save picture
            _openImage.Title = "Select a Image";
            _openImage.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            string appPath = Utill.PathImage();
            if (Directory.Exists(appPath) == false)                                              
            {                                                                                    
                Directory.CreateDirectory(appPath);                                              
            }                                                                                         
            _imageUrl = appPath + _openImage.SafeFileName+"_"+ DateTime.Now.ToBinary()+".jpg"; 
        }

        private void AddProductGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AddNewProductGroup();
            }
        }

        private void _txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AddNewProductGroup();
            }
        }
    }
}
