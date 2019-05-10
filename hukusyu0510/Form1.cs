using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hukusyu0510
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
        }
    }
}
