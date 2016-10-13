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
    public partial class AreaDialog : Form
    {
        private readonly AreaFunction _areaFunction;
        private int row;
        public AreaDialog(AreaFunction areaFunction)
        {
            _areaFunction = areaFunction;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            #region Set Style
            _lbArea.Font = Contant.LabelFont();
            _lbAreaName.Font = Contant.LabelFont();
            _btnUpdate.Font = Contant.ButtonFont();
            _btnDelete.Font = Contant.ButtonFont();
            _btnAddArea.Font = Contant.ButtonFont();
            _txtArea.Font = Contant.TexboxFont(); 
            _grUpdate.Font = Contant.GroupFont();
            #endregion
            GetArea();
            row = 0;
        }


        private void AreaDialog_Load(object sender, EventArgs e)
        {
            _txtArea.Text = _dgArea.Rows[0].Cells[1].Value.ToString();
            _txtId.Text = _dgArea.Rows[0].Cells[0].Value.ToString();
        }
        private void GetArea(int row = 0)
        {
            DataTable dt = _areaFunction.LoadArea();
            _dgArea.DataSource = dt;
            _dgArea.RowHeadersVisible = false;
            _dgArea.AllowUserToAddRows = false;
            _dgArea.Columns[0].Visible = false;
            _dgArea.Columns[1].Width = 240;
            _dgArea.Columns[1].HeaderText = "Tên Khu Vưc";
            _dgArea.ReadOnly = true;
            if (_dgArea.Rows.Count != 0)
            {
                _dgArea.Rows[row].Selected = true;
                if (row != 0)
                    _dgArea.Rows[0].Selected = false;
                _txtId.Text = _dgArea.Rows[row].Cells[0].Value.ToString();
                _txtArea.Text = _dgArea.Rows[row].Cells[1].Value.ToString();
            }
            Contant.UpdateFont(_dgArea);
        }

        private void _btnAddArea_Click(object sender, EventArgs e)
        {
            var dialog = new AddAreaDialog();
            DialogResult result = dialog.ShowDialog();
            while (result == DialogResult.Yes)
            {
                row = _dgArea.Rows.Count;
                GetArea(row);
                result = dialog.ShowDialog();
            }
        }

        private void _btnUpdate_Click(object sender, EventArgs e)
        {
            var name = _txtArea.Text;
            if (_txtId.Text.Trim() == "") return;
            var id = Convert.ToInt32(_txtId.Text);
            if (!_areaFunction.UpdateArea(id,name))
                MessageBox.Show("Không Sửa Được Tên Bàn!");
            GetArea(row);
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (_txtId.Text.Trim() == "") return;
            DialogResult deleteConfirm = MessageBox.Show("Những bàn nằm trong Khuc Vực này cũng sẽ bị xóa theo. \n Bạn có chắc chắn muốn xóa Khu Vực này? \n ", "Xác nhận xóa Khu Vực",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deleteConfirm == DialogResult.No)
                return;

            if (!_areaFunction.DeleteArea(Convert.ToInt32(_txtId.Text)))
                MessageBox.Show("Không Xóa Được Khu Vực Này!");
            if (row == _dgArea.Rows.Count - 1&&row!=0)
                row = row - 1;
            
            GetArea(row);
            if (_dgArea.RowCount == 0)
            {
                _txtArea.Text = "";
                _txtId.Text = "";
            }
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _dgArea_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            row = e.RowIndex;
            _txtArea.Text = _dgArea.Rows[row].Cells[1].Value.ToString();
            _txtId.Text = _dgArea.Rows[row].Cells[0].Value.ToString();
        }
    }
}
