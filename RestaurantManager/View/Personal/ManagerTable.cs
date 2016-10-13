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

namespace RestaurantManager.View.Personal
{
    public partial class ManagerTable : Form
    {
        public ManagerTable()
        {
            InitializeComponent();
            CheckSize();
            _grGenus.Font = Contant.GroupFont();
            _grViand.Font = Contant.GroupFont();
            _grProperty.Font = Contant.GroupFont();
            _grDetail.Font = Contant.GroupFont();
            GetGenus();
            _lvGenus.View = System.Windows.Forms.View.List;
            _lvViand.View = System.Windows.Forms.View.Details;

        }

        private void GetGenus()
        {
            var _genusFunction = new GenusFunction(DbConnect.XConnect());
            DataTable dt = _genusFunction.LoadGenus();

            foreach (DataRow rowGenus in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = rowGenus[1].ToString();
                item.SubItems.Add(rowGenus[0].ToString());
                item.SubItems.Add(rowGenus[1].ToString());
                _lvGenus.Items.Add(item);
            }
            if(_lvGenus.Items.Count>0)
            _lvGenus.Items[0].Selected = true;
        }

        private void GetViand()
        {
            _lvViand.Clear();
            var _viandFunction = new ViandFunction(DbConnect.XConnect());
            var _genusId = Convert.ToInt32(_txtGenusId.Text);
            DataTable dt = _viandFunction.LoadViandByGenusId(_genusId);
            _lvViand.Columns.Add("Tên Món", 200);
            
            foreach (DataRow rowViand in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = rowViand[2].ToString();
                item.SubItems.Add(rowViand["Id"].ToString());
                item.SubItems.Add(rowViand["GenusId"].ToString());
                item.SubItems.Add(rowViand["Name"].ToString());
                item.SubItems.Add(rowViand["Price"].ToString());
                _lvViand.Items.Add(item);
            }
            if (_lvViand.Items.Count > 0)
                _lvViand.Items[0].Selected = true;
        }
        private void ManagerTable_Resize(object sender, EventArgs e)
        {
            CheckSize();
        }
        public void CheckSize()
        {
            var x = this.Width/20;
            var y = this.Height;
            var t = x / 5;

            _grGenus.Size = new Size(x*3, y - 130);
            _grGenus.Left = t;
            _grGenus.Top = 10;

            _grViand.Size = new Size(x * 5, y - 130);
            _grViand.Left = x * 3 + 2*t;
            _grViand.Top = 10;

            _grProperty.Size = new Size(x  * 5, y - 130);
            _grProperty.Left = x  * 8 + 3*t;
            _grProperty.Top = 10;

            _grDetail.Size = new Size(x  * 6, y - 130);
            _grDetail.Left = x * 13 + 4*t;
            _grDetail.Top = 10;
        }

        private void _lvGenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvGenus.SelectedItems.Count == 0)
                return;
            ListViewItem item = _lvGenus.SelectedItems[0];
            _txtGenusId.Text = item.SubItems[1].Text.ToString().Trim();
        }

        private void _txtGenusId_TextChanged(object sender, EventArgs e)
        {
            if (_txtGenusId.Text.Trim() == "") return;
            GetViand();
        }

    }
}
