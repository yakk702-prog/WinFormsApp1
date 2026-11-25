using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mark;
            mark = int.Parse(textBox1.Text);
            if (mark >= 85 && mark <= 100)
                label3.Text = "Excellent";
            else if (mark >= 75)
                label3.Text = "Very Good";
            else if (mark >= 65)
                label3.Text = " Good";
            else
                label3.Text = " field";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = " ";
        }
    }
}
