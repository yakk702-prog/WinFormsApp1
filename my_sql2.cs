using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class my_sql2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=YASMIN\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True");
        public SqlCommand cmd = new SqlCommand();
        public string txt1, txt2, txt3;
        public my_sql2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                txt1 = textBox1.Text;
                cmd.CommandText = "delete from Employees where EmployeeID = '" + txt1 + "' ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void my_sql2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                txt1 = textBox1.Text;
                txt2 = textBox2.Text;
                txt3 = textBox3.Text;
                if(txt1 != "" && txt2 != "" && txt3 != "")
                {
                    cmd.CommandText = "update Employees set FirstName = '" + txt2 + "', LastName = '" + txt3 + "' where EmployeeID = '" + txt1 + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Please fill all the fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                txt2 = textBox2.Text;
                txt3 = textBox3.Text;
                cmd.CommandText = "insert into Employees ( FirstName, LastName) values ( '" + txt2 + "', '" + txt3 + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
