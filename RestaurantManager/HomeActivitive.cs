using RestaurantManager.Position;
using RestaurantManager.Server;
using RestaurantManager.View.Manager;
using RestaurantManager.View.Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class HomeActivitive : Form
    {
        public HomeActivitive()
        {
            InitializeComponent();
            _grList.Font = Contant.GroupFont();
            _grSearch.Font = Contant.GroupFont();
            _grStatistic.Font = Contant.GroupFont();
            _grTable.Font = Contant.GroupFont();
        }

        private void HomeActivitive_Load(object sender, EventArgs e)
        {
            CheckSize();
            GetListView();
            GetTable();
        }

        private void HomeActivitive_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void _btnArea_Click(object sender, EventArgs e)
        {
            var _areaFunction = new AreaFunction(DbConnect.XConnect());
            var areaDialog = new AreaDialog(_areaFunction);
            areaDialog.ShowDialog();
        }

        private void _btnConnect_Click(object sender, EventArgs e)
        {
            DbConnect.Connect();
        }

        private void _btnTable_Click(object sender, EventArgs e)
        {
            var tableDialog = new TableDialog(new TableFunction(DbConnect.XConnect()), new AreaFunction(DbConnect.XConnect()));
            tableDialog.ShowDialog();
        }
        private void GetTable()
        {
            var _tableFunction = new TableFunction(DbConnect.XConnect());
            DataTable dt = _tableFunction.LoadTable();
           
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row[2].ToString();
                item.SubItems.Add(row["Id"].ToString());
                item.SubItems.Add(row["AreaId"].ToString());
                item.SubItems.Add(row["Name"].ToString());
                string trangthai = row["Status"].ToString();
                if (trangthai == "1")
                {
                    item.ImageIndex = 0;
                }
                else
                    item.ImageIndex = 0;

                _lvTable.Items.Add(item);
            }
        }

        private void _lvTable_DoubleClick(object sender, EventArgs e)
        {
            var dialog = new ManagerTable(_txtTable.Text,_txtTableName.Text);
            //dialog.Text = _txtTableName.Text;
            dialog.ShowDialog();
        }

        private void _lvTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvTable.SelectedItems.Count == 0)
                return;
            ListViewItem item = _lvTable.SelectedItems[0];
            _txtTable.Text = item.SubItems[1].Text.ToString().Trim();
            _txtTableName.Text = item.SubItems[3].Text.ToString().Trim();
        }

        private void GetListView()
        {
            _imageTable.ImageSize = Contant.ImageSize();
            _imageTable.Images.Add("pic1", Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\image\MB__home.png"));
            _lvTable.LargeImageList = _imageTable;
            _imageTable.ColorDepth = ColorDepth.Depth32Bit;
            _lvTable.Font = Contant.ImageFont();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _lvTable.Clear();
            GetTable();
        }

        private void _btnGenusViand_Click(object sender, EventArgs e)
        {
            var genusDialog = new GenusDialog(new GenusFunction(DbConnect.XConnect()));
            genusDialog.Show();
        }

        private void _btnViand_Click(object sender, EventArgs e)
        {
            var viandDialog = new ViandDialog(new GenusFunction(DbConnect.XConnect()), new ViandFunction(DbConnect.XConnect()));
            viandDialog.Show();
        }

        private void HomeActivitive_Resize(object sender, EventArgs e)
        {
            CheckSize();
        }

        private void CheckSize()
        {
            _grTable.Size = new Size(this.Width - 300, this.Height - 160);
            _grTable.Left = 270;
            _grTable.Top = 110;
        }
    }
}
