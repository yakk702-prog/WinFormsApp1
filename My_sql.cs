using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;

namespace WinFormsApp1
{
    public partial class My_sql : Form
    {
        public My_sql()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=YASMIN\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select * from Employees";
                dr=cmd.ExecuteReader();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
