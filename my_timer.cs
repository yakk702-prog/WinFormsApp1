using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class my_timer : Form
    {
        int second = 0;
        public my_timer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            timer1.Interval = 1000;
            second = second + 1;
            if (second >= 10)
            {
                timer1.Stop();
                BackColor = Color.LightPink;
                MessageBox.Show("exiting from timer ");
            }
        }

        private void my_timer_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToString();
            
        }
    }
}

    
   
   