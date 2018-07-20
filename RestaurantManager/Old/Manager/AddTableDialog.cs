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
    public partial class AddTableDialog : Form
    {
        public AddTableDialog(string areaId, string areaName)
        {
            InitializeComponent();
            _txtAreaId.Hide();
            _txtAreaId.Text = areaId.ToString();
            _txtArea.Text = areaName;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void _btnAddTable_Click(object sender, EventArgs e)
        {
            InsertTable();
            _txtTable.Select();
        }
        private void InsertTable()
        {
            var name = _txtTable.Text;
            if (name.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên bàn!");
                return;
            }
            var table = new Table() { Name = name, AreaId = _txtAreaId.ToInt() };
            DataHelper.Instance.InsertTable(table);
            _txtTable.Text = null;
            DialogResult = DialogResult.Yes;
        }

        private void _txtTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                InsertTable();
        }
    }
}
