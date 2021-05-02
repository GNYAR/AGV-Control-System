using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public partial class Urlbox : Form
    {
        // 網外 59.124.226.9:6592
        // 網內 192.168.101.234:50100
        private string ip = "";
        private string port = "";
        public Urlbox()
        {
            InitializeComponent();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            ip = "59.124.226.9";
            port = "6592";
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            ip = "192.168.101.234";
            port = "50100";
        }

        public string getIP()
        {
            return ip;
        }
        public string getPort()
        {
            return port;
        }
    }
}
