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
    public partial class GenusDialog : Form
    {
        private readonly GenusFunction _genusFunction;
        private int row;
        public GenusDialog(GenusFunction genusFunction)
        {
            _genusFunction = genusFunction;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            #region Set Style
            _lbGenus.Font = Contant.LabelFont();
            _lbGenusName.Font = Contant.LabelFont();
            _btnUpdate.Font = Contant.ButtonFont();
            _btnDelete.Font = Contant.ButtonFont();
            _btnAddGenus.Font = Contant.ButtonFont();
            _txtGenus.Font = Contant.TexboxFont();
            _grUpdate.Font = Contant.GroupFont();
            #endregion
            GetGenus();
            row = 0;
        }

        private void GenusDialog_Load(object sender, EventArgs e)
        {
            _txtGenus.Text = _dgGenus.Rows[0].Cells[1].Value.ToString();
            _txtId.Text = _dgGenus.Rows[0].Cells[0].Value.ToString();
        }
        private void GetGenus(int row = 0)
        {
            DataTable dt = _genusFunction.LoadGenus();
            _dgGenus.DataSource = dt;
            _dgGenus.RowHeadersVisible = false;
            _dgGenus.AllowUserToAddRows = false;
            _dgGenus.Columns[0].Visible = false;
            _dgGenus.Columns[1].Width = 240;
            _dgGenus.Columns[1].HeaderText = "Tên Loại Món";
            _dgGenus.ReadOnly = true;
            if (_dgGenus.Rows.Count != 0)
            {
                _dgGenus.Rows[row].Selected = true;
                if (row != 0)
                    _dgGenus.Rows[0].Selected = false;
                _txtId.Text = _dgGenus.Rows[row].Cells[0].Value.ToString();
                _txtGenus.Text = _dgGenus.Rows[row].Cells[1].Value.ToString();
            }
            Contant.UpdateFont(_dgGenus);
        }

        private void _btnAddGenus_Click(object sender, EventArgs e)
        {
            var dialog = new AddGenusDialog();
            DialogResult result = dialog.ShowDialog();
            while (result == DialogResult.Yes)
            {
                row = _dgGenus.Rows.Count;
                GetGenus(row);
                result = dialog.ShowDialog();
            }
        }

        private void _btnUpdate_Click(object sender, EventArgs e)
        {
            var name = _txtGenus.Text;
            if (_txtId.Text.Trim() == "") return;
            var id = Convert.ToInt32(_txtId.Text);
            if (!_genusFunction.UpdateGenus(id, name))
                MessageBox.Show("Không Sửa Được Tên Bàn!");
            GetGenus(row);
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (_txtId.Text.Trim() == "") return;
            DialogResult deleteConfirm = MessageBox.Show("Những món nằm trong Loại Món này cũng sẽ bị xóa theo. \n Bạn có chắc chắn muốn xóa Loại Món này? \n ", "Xác nhận xóa Loại Món",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deleteConfirm == DialogResult.No)
                return;

            if (!_genusFunction.DeleteGenus(Convert.ToInt32(_txtId.Text)))
                MessageBox.Show("Không Xóa Được Loại Món Này!");
            if (row == _dgGenus.Rows.Count - 1 && row != 0)
                row = row - 1;

            GetGenus(row);
            if (_dgGenus.RowCount == 0)
            {
                _txtGenus.Text = "";
                _txtId.Text = "";
            }
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _dgGenus_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            row = e.RowIndex;
            _txtGenus.Text = _dgGenus.Rows[row].Cells[1].Value.ToString();
            _txtId.Text = _dgGenus.Rows[row].Cells[0].Value.ToString();
        }
    }
}
