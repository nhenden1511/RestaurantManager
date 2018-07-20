using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.View.Manager
{
    public partial class AddGenusDialog : Form
    {
        public AddGenusDialog()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            InsertGenus();
            _txtAdd.Select();
        }

        private void InsertGenus()
        {
            var name = _txtAdd.Text;
            if (name.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại món!");
                return;
            }
            var genus = new Genus() { Name = name };

            DataHelper.Instance.InsertGenus(genus);
                _txtAdd.Text = null;
                DialogResult = DialogResult.Yes;
        }

        private void _txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                InsertGenus();
                _txtAdd.Select();
            }
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void AddGenusDialog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
