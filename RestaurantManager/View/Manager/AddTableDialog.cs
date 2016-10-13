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
            var areaId = _txtAreaId.Text;
            var _tableFunction = new TableFunction(DbConnect.XConnect());
            if (_tableFunction.AddTable(Convert.ToInt32(areaId),name))
            {
                MessageBox.Show("Thêm Khu Vực Thành Công!");
                _txtTable.Text = null;
                DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Không Thêm Được Khu Vực Mới!");

            }
        }

        private void _txtTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                InsertTable();
        }
    }
}
