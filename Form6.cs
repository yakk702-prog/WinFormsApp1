using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(textBox1.Text);
            int fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            textBox2.Text = "" + fact;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(textBox1.Text);
            int fact = 1;
            int i = 1;
            while (i <= x)
            {
                fact = fact * i;
                i++;
            }
            textBox2.Text = "" + fact;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
