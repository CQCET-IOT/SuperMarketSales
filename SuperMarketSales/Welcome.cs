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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void ll_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 退出应用程序
            Application.Exit();
        }

        private void ll_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form login = new Login();
            // 测试login.Show()，体验差别
            login.ShowDialog();
        }
    }
}