using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGitProjectTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aa = this.txtUseName.Text;
            if(aa == "4444")
            {
                this.button1.Text = "你好";
            }
            else
            {
                this.button1.Text = "HELLO";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             
        }
    }
}
