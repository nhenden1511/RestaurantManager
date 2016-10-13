using RestaurantManager.Position;
using RestaurantManager.Server;
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
        private ViandFunction _viandFunction;
        public AddVianddialog(string genusId,string genusName, ViandFunction viandFunction)
        {
            InitializeComponent();
            _viandFunction = viandFunction;
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
            var genusId = Convert.ToInt32(_txtGenusId.Text);
            var price = Convert.ToInt32(_txtPrice.Text.Replace(".",""));
            if (_viandFunction.AddTable(genusId, name, price))
            {
                MessageBox.Show("Thêm Món Ăn Mới Thành Công!");
                _txtViand.Text = null;
                DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Không Thêm Được Món Ăn Mới!");

            }
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
