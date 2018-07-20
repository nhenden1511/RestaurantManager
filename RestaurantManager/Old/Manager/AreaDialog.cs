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
        private int row;
        public AreaDialog()
        {
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
        }


        private void AreaDialog_Load(object sender, EventArgs e)
        {
            _txtArea.Text = _dgArea.Rows[0].Cells[1].Value.ToString();
            _txtId.Text = _dgArea.Rows[0].Cells[0].Value.ToString();
        }
        private void GetArea(int row = 0)
        {
            Utill.GetArea(_dgArea);
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
            if (_txtArea.Text.Trim() == "") MessageBox.Show("Bạn chưa nhập tên bàn!");
            var area = DataHelper.Instance.GetAreaById(_txtId.ToInt());
            if (area == null) return;
            area.Name = _txtArea.Text;
            DataHelper.Instance.UpdateArea(area);
            GetArea();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (_txtId.Text.Trim() == "") return;
            DialogResult deleteConfirm = MessageBox.Show("Những bàn nằm trong Khu Vực này cũng sẽ bị xóa theo. \n Bạn có chắc chắn muốn xóa Khu Vực này? \n ", "Xác nhận xóa Khu Vực",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deleteConfirm == DialogResult.No)
                return;
            var area = DataHelper.Instance.GetAreaById(_txtId.ToInt());
            if (area == null) return;
            DataHelper.Instance.DeleteArea(area);
            GetArea();
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
