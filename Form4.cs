using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.ToString() == "weekdays")
            {
                comboBox2.Items.Add("Monday");
                comboBox2.Items.Add("Tuesday");
                comboBox2.Items.Add("Wednesday");
                comboBox2.Items.Add("Thursday");
                comboBox2.Items.Add("Friday");
                comboBox2.Items.Add("Saturday");
                comboBox2.Items.Add("Sunday");
            }
            else if (comboBox1.SelectedItem.ToString() == "year")
            {
                for (int i = 2000; i <= 2024; i++)
                {
                    comboBox2.Items.Add(i.ToString());
                }
                comboBox2.SelectedIndex = 0;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 400;
            for (i = 0; i <= 400; i++)
            {
                progressBar1.Value = i;
            }
            comboBox1.Items.Add("weekdays");
            comboBox1.Items.Add("year");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var;
            var=comboBox1.Text+ "selected item is " + comboBox2.Text;
            MessageBox.Show(var);
        }
    }
}
