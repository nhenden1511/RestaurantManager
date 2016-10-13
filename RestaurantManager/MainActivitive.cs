using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using RestaurantManager.Position;
using System.Runtime.Remoting.Contexts;

namespace RestaurantManager
{
    public partial class LoginActivitive : Form
    {
        public LoginActivitive()
        {
            InitializeComponent();
            var dialog = new HomeActivitive();
            this.Hide();
            dialog.ShowDialog();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            var _employee = new EmployeeFunction(DbConnect.XConnect());
            //var abc = _employee.AddEmployee("admin", "admin", "admin", "HaoNguyen", true);
            //if (abc)
            //    MessageBox.Show("Finish");
            var dt = _employee.LoadEmployee();
            var dialog = new HomeActivitive();
            this.Hide();
            dialog.Show();
        }
    }
}
