using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}
