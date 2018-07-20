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
        private int row;
        public GenusDialog()
        {
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
            Utill.GetGenus(_dgGenus);
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
            if (_txtId.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại món!");
                return;
            }
            var genus = DataHelper.Instance.GetGenusById(_txtId.ToInt());
            genus.Name = name;
            DataHelper.Instance.UpdateGenus(genus);
            GetGenus(row);
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            var name = _txtGenus.Text;
            if (_txtId.Text.Trim() == "") return;

            var genus = DataHelper.Instance.GetGenusById(_txtId.ToInt());
            DataHelper.Instance.DeleteGenus(genus);
            GetGenus(row);
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
