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
    public partial class AddVianddialog : Form
    {
        public AddVianddialog(string genusId,string genusName)
        {
            InitializeComponent();
            _txtGenusId.Hide();
            _txtGenusId.Text = genusId;
            _txtArea.Text = genusName;
            this.StartPosition = FormStartPosition.CenterParent;

            #region Set Style
            _lbPrice.Font = Contant.LabelFont();
            _lbViandName.Font = Contant.LabelFont();
            _btnAdd.Font = Contant.ButtonFont();
            _txtArea.Font = Contant.TexboxFont();
            _txtPrice.Font = Contant.TexboxFont();
            _txtViand.Font = Contant.TexboxFont();
            _grGenus.Font = Contant.GroupFont();
            #endregion
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            InsertViand();
            _txtViand.Select();
        }

        private void InsertViand()
        {
            var name = _txtViand.Text;
            if (name.Trim() == "") return;
            if (_txtPrice.Text.Trim() == "") return;

            var price = Convert.ToInt32(_txtPrice.Text.Replace(".",""));
            var viand = new Viand() { Name = name, Price = price, GenusId = _txtGenusId.ToInt() };
            DataHelper.Instance.InsertViand(viand);
                _txtViand.Text = null;
                DialogResult = DialogResult.Yes;
        }

        private void _txtViand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                InsertViand();
        }

        private void _txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                InsertViand();
        }
        

        private void _txtPrice_TextChanged(object sender, EventArgs e)
        {
            _txtPrice.Text = Contant.NumberToMoney(_txtPrice.Text);
            _txtPrice.SelectionStart = _txtPrice.TextLength- 4;
        }
    }
}
