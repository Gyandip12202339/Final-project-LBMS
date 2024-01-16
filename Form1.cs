using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_based_project


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=LAPTOP-NU78ASUU\\MSSQLSERVER01;Initial Catalog=library;Integrated Security=True";
        private string sp_Login;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_Login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataReader dr = cmd.ExecuteReader();
                 if (dr.Read())
            {
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();
                
            }
                 else 
            
            {
                MessageBox.Show("Login Failed!! Please Try again");
            }
           
           

        }
    }
}
