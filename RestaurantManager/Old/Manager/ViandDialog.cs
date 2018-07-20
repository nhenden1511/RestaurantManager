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
    public partial class ViandDialog : Form
    {
        private int _rowTable;
        public ViandDialog()
        {
            InitializeComponent();
            Contant.UpdateFont(_dgViand);

            #region Set Style
            _lbGenus.Font = Contant.LabelFont();
            _lbViand.Font = Contant.LabelFont();
            _lbViandName.Font = Contant.LabelFont();
            _lbPrice.Font = Contant.LabelFont();
            _btnUpdate.Font = Contant.ButtonFont();
            _btnDelete.Font = Contant.ButtonFont();
            _btnAddViand.Font = Contant.ButtonFont();
            _txtViand.Font = Contant.TexboxFont();
            _txtPrice.Font = Contant.TexboxFont();
            _grUpdate.Font = Contant.GroupFont();
            #endregion
        }

        private void ViandDialog_Load(object sender, EventArgs e)
        {
            GetGenus();
            GetViand(0);
            _rowTable = 0;
        }

        private void GetGenus(int row = -1)
        {
            Utill.GetGenus(_dgGenus);
        }

        private void GetViand(int row = -1)
        {
            if (_txtGenusId.Text.Trim() == "") return;
            Utill.GetViand(_dgViand, _txtGenusId.ToInt());
        }

        private void _dgGenus_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            _txtGenusId.Text = _dgGenus.Rows[e.RowIndex].Cells[0].Value.ToString();
            _txtGenusName.Text = _dgGenus.Rows[e.RowIndex].Cells[1].Value.ToString();
            GetViand(0);
            if (_dgViand.Rows.Count == 0)
            {
                _txtViand.Text = "";
                _txtViandId.Text = "";
                _txtPrice.Text = "";
            }
        }

        private void _btnAddViand_Click(object sender, EventArgs e)
        {
            if (_txtGenusId.Text == "") return;
            var tableDialog = new AddVianddialog(_txtGenusId.Text, _txtGenusName.Text);
            DialogResult result = tableDialog.ShowDialog();
            while (result == DialogResult.Yes)
            {
                _rowTable = _dgViand.Rows.Count;
                GetViand(_rowTable);
                result = tableDialog.ShowDialog();
            }
        }

        private void _dgViand_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == -1) return;
            //_rowTable = e.RowIndex;
            //_txtViandId.Text = _dgViand.Rows[_rowTable].Cells[0].Value.ToString();
            //_txtViand.Text = _dgViand.Rows[_rowTable].Cells[2].Value.ToString();
            //_txtPrice.Text = _dgViand.Rows[_rowTable].Cells[3].Value.ToString();
            //_txtViand.ReadOnly = true;
            //_txtPrice.ReadOnly = true;
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (_txtViandId.Text.ToString().Trim() == "") return;
            var viand = DataHelper.Instance.GetViandById(_txtViandId.ToInt());
            DataHelper.Instance.DeleteViand(viand);

            if (_rowTable == _dgViand.Rows.Count - 1 && _rowTable != 0)
                _rowTable = _rowTable - 1;

            GetViand(_rowTable);
            if (_dgViand.RowCount == 0)
            {
                _txtViand.Text = "";
                _txtViandId.Text = "";
                _txtPrice.Text = "";
            }
        }

        private void _btnUpdate_Click(object sender, EventArgs e)
        {
            if (_txtViandId.Text.Trim() == "") return;
            if (_txtPrice.Text.Trim() == "") return;
            var name = _txtViand.Text;
            var price = Convert.ToInt32(_txtPrice.Text.Replace(".", ""));
            var id = _txtViandId.ToInt();
            var viand = DataHelper.Instance.GetViandById(id);
            if (viand != null)
            {
                viand.Name = name;
                viand.Price = price;
                DataHelper.Instance.UpdateViand(viand);
            }
            GetViand(_rowTable);
            _txtViand.ReadOnly = true;
        }

        private void _txtViand_MouseClick(object sender, MouseEventArgs e)
        {
            _txtViand.ReadOnly = false;
            _txtPrice.ReadOnly = false;
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _txtPrice_MouseClick(object sender, MouseEventArgs e)
        {
            _txtPrice.ReadOnly = false;
        }

        private void _txtPrice_TextChanged(object sender, EventArgs e)
        {
            _txtPrice.Text = Contant.NumberToMoney(_txtPrice.Text);
            _txtPrice.SelectionStart = _txtPrice.TextLength - 4;
        }
    }
}
