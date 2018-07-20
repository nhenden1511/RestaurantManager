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
            if (name.Trim() == "")
            {
                MessageBox.Show("Bạn chưa đặt tên khu vực!");
                return;
            }
            var area = new Area() { Name = name, };
            DataHelper.Instance.InsertArea(area);
            _txtAdd.Text = "";
            DialogResult = DialogResult.Yes;
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
