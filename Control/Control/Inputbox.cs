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
    public partial class Inputbox : Form {
        public Inputbox(string text, string title, string deflaut = "") {
            InitializeComponent();
            label1.Text = text;
            this.Text = title;
            textBox1.Text = deflaut;
        }

        private string msg;

        private void button1_Click(object sender, EventArgs e)
        {
            msg = textBox1.Text;
        }

        public string GetMsg() {
            return msg;
        }
    }
}
