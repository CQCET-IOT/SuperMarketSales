using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketSales
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            // 收银员
            if (this.rb_Oper.Checked)
            {
                if (this.tb_User.Text == "test" && this.tb_Pwd.Text == "test")
                {
                    MessageBox.Show("收银员登录成功");
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
            }
            else // 库管员
            {
                if (this.tb_User.Text == "admin" && this.tb_Pwd.Text == "admin")
                {
                    MessageBox.Show("库管员登录成功");
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
            }
        }
    }
}