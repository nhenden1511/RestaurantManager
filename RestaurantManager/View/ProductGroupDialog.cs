using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class ProductGroupDialog : Form
    {
        public static readonly ProductGroupDialog _instance = new ProductGroupDialog();
        static string _imageUrl;
        static string _fileName;
        private Image myImage;
        public static ProductGroupDialog Instance
        {
            get
            {
                return _instance;
            }
        }
        public ProductGroupDialog()
        {
            InitializeComponent();
            Utill.GridProductGroup(_dgListProductGroup);
            _btnChangPic.Hide();
            _txtCode.ReadOnly = true;
            _txtName.ReadOnly = true;
        }


        private void _btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new AddProductGroup();
            DialogResult result = dialog.ShowDialog();
            while (result == DialogResult.Yes)
            {
                Utill.GridProductGroup(_dgListProductGroup);
                result = dialog.ShowDialog();
            }
        }

        private void ProductGroupDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void _dgListProductGroup_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var row = e.RowIndex;
            _txtId.Text = _dgListProductGroup.Rows[row].Cells[0].Value.ToString();
            _txtName.Text = _dgListProductGroup.Rows[row].Cells[2].Value.ToString();
            _txtCode.Text = _dgListProductGroup.Rows[row].Cells[1].Value.ToString();
            if (_dgListProductGroup.Rows[row].Cells[3].Value != null)
            {
                _imageUrl = _dgListProductGroup.Rows[row].Cells[3].Value.ToString();
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
            _btnSave.Hide();
            _btnChangPic.Hide();
            _txtCode.ReadOnly = true;
            _txtName.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _btnChangPic.Show();
            _btnSave.Show();
            _txtCode.ReadOnly = false;
            _txtName.ReadOnly = false;
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            var id = _txtId.ToInt();
            var group = DataHelper.Instance.GetProductGroupById(id);
            if (group == null) return;
            if (_txtCode.Check())
            {
                MessageBox.Show("Bạn chưa nhập mã nhóm sản phẩm!");
                return;
            }
            if (_txtName.Check())
            {
                MessageBox.Show("Bạn chưa nhập tên nhóm sản phẩm!");
                return;
            }

            group.Code = _txtCode.Text;
            group.Name = _txtName.Text;

            if (_imageUrl != null)
            {
                group.Image = _imageUrl;
                if(_fileName!=null)
                File.Copy(_fileName, _imageUrl, true);
            }
            DataHelper.Instance.UpdateProductGroup(group);

            _btnSave.Hide();
            _btnChangPic.Hide();
            _txtCode.ReadOnly = true;
            _txtName.ReadOnly = true;
            Utill.GridProductGroup(_dgListProductGroup);

        }

        private void _btnChangPic_Click(object sender, EventArgs e)
        {
            this._openImage.ShowDialog();
            _fileName = this._openImage.FileName;

            if (_fileName == "_openImage"|| _fileName == "openFileDialog1") return;
            try
            {
                Image myImage = Image.FromFile(_fileName);
            }
            catch(Exception ex)
            { }
            _picShow.Image = myImage;

            //save picture
            _openImage.Title = "Select a Image";
            _openImage.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            string appPath = Utill.PathImage();
            if (Directory.Exists(appPath) == false)                                             
            {                                                                                   
                Directory.CreateDirectory(appPath);                                             
            }                                                                                      
            _imageUrl = appPath + _openImage.SafeFileName + "_" + DateTime.Now.ToBinary() + ".jpg";
        }

        private void ProductGroupDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
