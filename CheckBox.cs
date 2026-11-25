using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "";
            if (checkBox1.Checked)
                a += checkBox1.Text;
            if (checkBox2.Checked)
                a += checkBox2.Text;
            if (checkBox3.Checked)
                a += checkBox3.Text;

            MessageBox.Show(a + " is selected ");
        }
    }
}
