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
    public partial class TableDialog : Form
    {
        private readonly TableFunction _tableFunction;
        private readonly AreaFunction _areaFunction;
        private int _rowTable;
        public TableDialog(TableFunction tableFunction, AreaFunction areaFunction)
        {
            InitializeComponent();
            _tableFunction = tableFunction;
            _areaFunction = areaFunction;
            Contant.UpdateFont(_dgTable);

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
            DataTable dt = _areaFunction.LoadArea();
            _dgArea.DataSource = dt;
            _dgArea.RowHeadersVisible = false;
            _dgArea.AllowUserToAddRows = false;
            _dgArea.Columns[0].Visible = false;
            _dgArea.Columns[1].Width = 140;
            _dgArea.Columns[1].HeaderText = "Tên Khu Vưc";
            _dgArea.ReadOnly = true;
            if (_dgArea.RowCount > 0)
            {
                    _txtAreaId.Text = _dgArea.Rows[0].Cells[0].Value.ToString();
                    _dgArea.Rows[0].Selected = true;
                    _txtAreaName.Text = _dgArea.Rows[0].Cells[1].Value.ToString();
            }
            Contant.UpdateFont(_dgArea);
        }

        private void GetTable(int row = -1)
        {
            if (_txtAreaId.Text.Trim() == "") return;
            DataTable dt = _tableFunction.LoadTableByAreaId(Convert.ToInt32(_txtAreaId.Text));
            _dgTable.DataSource = dt;
            _dgTable.AllowUserToAddRows = false;
            _dgTable.RowHeadersVisible = false;
            _dgTable.Columns[0].Visible = false;
            _dgTable.Columns[1].Visible = false;
            _dgTable.Columns[2].Width = 175;
            _dgTable.Columns[2].HeaderText = "Tên Bàn";
            _dgTable.Columns[3].Visible = false;
            _dgTable.ReadOnly = true;
            if (_dgTable.Rows.Count != 0)
            {

                if (row != 0)
                {
                    _dgTable.Rows[0].Selected = false;
                    _dgTable.Rows[row].Selected = true;
                }
                else _dgTable.Rows[0].Selected = true;

                _txtTableId.Text = _dgTable.Rows[row].Cells[0].Value.ToString();
                _txtTable.Text = _dgTable.Rows[row].Cells[2].Value.ToString();
            }
            Contant.UpdateFont(_dgTable);
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
            _txtTable.Text= _dgTable.Rows[_rowTable].Cells[2].Value.ToString();
            _txtTable.ReadOnly = true;
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (_txtTableId.Text.ToString().Trim() == "") return;
            if(!_tableFunction.DeleteTable(Convert.ToInt32(_txtTableId.Text)))
                MessageBox.Show("Không Xóa Được Bàn Này!");
            if (_rowTable == _dgTable.Rows.Count - 1 && _rowTable != 0)
                _rowTable = _rowTable - 1;

            GetTable(_rowTable);
            if (_dgTable.RowCount == 0)
            {
                _txtTable.Text = "";
                _txtTableId.Text = "";
            }
        }

        private void _btnUpdate_Click(object sender, EventArgs e)
        {
            var name = _txtTable.Text;
            if (_txtTableId.Text.Trim() == "") return;
            var id = Convert.ToInt32(_txtTableId.Text);
            if (!_tableFunction.UpdateTable(id, name))
            {
                MessageBox.Show("Không Sửa Được Tên Bàn!");
                return;
            }
            GetTable(_rowTable);
            _txtTable.ReadOnly = true;
        }

        private void _txtTable_MouseClick(object sender, MouseEventArgs e)
        {
            _txtTable.ReadOnly = false;
        }
    }
}
