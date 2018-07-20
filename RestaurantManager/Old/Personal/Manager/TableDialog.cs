using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.View.Manager
{
    public partial class TableDialog : Form
    {
        private int _rowTable;
        public TableDialog()
        {
            InitializeComponent();
            Contant.UpdateFont(_dgTable);
            this.StartPosition = FormStartPosition.CenterParent;

            #region Set Style
            _lbArea.Font = Contant.LabelFont();
            _lbTable.Font = Contant.LabelFont();
            _lbTableName.Font = Contant.LabelFont();
            _btnUpdate.Font = Contant.ButtonFont();
            _btnDelete.Font = Contant.ButtonFont();
            _btnAddTable.Font = Contant.ButtonFont();
            _txtTable.Font = Contant.TexboxFont();
            _grUpdate.Font = Contant.GroupFont();
            #endregion
        }

        private void TableDialog_Load(object sender, EventArgs e)
        {
            GetArea();
            GetTable(0);
            _rowTable = 0;
        }
        private void GetArea(int row = -1)
        {
            Utill.GetArea(_dgArea);
        }

        private void GetTable(int row = -1)
        {
            if (_txtAreaId.Text.Trim() == "") return;
            Utill.GetTable(_dgTable, _txtAreaId.ToInt());
            _txtTable.ReadOnly = true;
        }

        private void _dgArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            _txtAreaId.Text = _dgArea.Rows[e.RowIndex].Cells[0].Value.ToString();
            _txtAreaName.Text = _dgArea.Rows[e.RowIndex].Cells[1].Value.ToString();
            GetTable(0);
            if (_dgTable.Rows.Count == 0)
            {
                _txtTable.Text = "";
                _txtTableId.Text = "";
            }
        }

        private void _btnAddTable_Click(object sender, EventArgs e)
        {
            if (_txtAreaId.Text == "") return;
            var tableDialog = new AddTableDialog(_txtAreaId.Text,_txtAreaName.Text);
            DialogResult result = tableDialog.ShowDialog();
            while (result == DialogResult.Yes)
            {
                _rowTable = _dgTable.Rows.Count;
                GetTable(_rowTable);
                result = tableDialog.ShowDialog();
            }
        }

        private void _dgTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            _rowTable = e.RowIndex;
            _txtTableId.Text= _dgTable.Rows[_rowTable].Cells[0].Value.ToString();
            _txtTable.Text= _dgTable.Rows[_rowTable].Cells[1].Value.ToString();
            _txtTable.ReadOnly = true;
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (_txtTableId.Text.Trim() == "") return;
            var table = DataHelper.Instance.GetTableById(_txtTableId.ToInt());
            if (table != null) DataHelper.Instance.DeleteTable(table);
            GetTable();
        }

        private void _btnUpdate_Click(object sender, EventArgs e)
        {
            var name = _txtTable.Text;
            if (name.Trim() == "") {
                MessageBox.Show("Bạn chưa nhập tên bàn!");
                return; }
            var table = DataHelper.Instance.GetTableById(_txtTableId.ToInt());
            DataHelper.Instance.UpdateTable(table);
            GetTable(_rowTable);
        }

        private void _txtTable_MouseClick(object sender, MouseEventArgs e)
        {
            _txtTable.ReadOnly = false;
        }
    }
}
