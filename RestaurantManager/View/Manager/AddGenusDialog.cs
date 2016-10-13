using RestaurantManager.Position;
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
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            InsertGenus();
            _txtAdd.Select();
        }

        private void InsertGenus()
        {
            var name = _txtAdd.Text;
            var _genusFunction = new GenusFunction(DbConnect.XConnect());
            if (_genusFunction.AddGenus(name))
            {
                MessageBox.Show("Thêm Loại Món Thành Công!");
                _txtAdd.Text = null;
                DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Không Thêm Được Loại Món Mới!");

            }
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
