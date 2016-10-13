using RestaurantManager.Position;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.View.Manager
{
    public partial class AddAreaDialog : Form
    {
        public AddAreaDialog()
        {
            InitializeComponent();
            
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            InsertArea();
            _txtAdd.Select();
        }

        private void InsertArea()
        {
            var name = _txtAdd.Text;
            var _areaFunction = new AreaFunction(DbConnect.XConnect());
            if (_areaFunction.AddArea(name))
            {
                MessageBox.Show("Thêm Khu Vực Thành Công!");
                _txtAdd.Text = null;
                DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Không Thêm Được Khu Vực Mới!");

            }
        }

        private void _txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                InsertArea();
                _txtAdd.Select();
            }
        }
    }
}
