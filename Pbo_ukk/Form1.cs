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

namespace Pbo_ukk
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(
            "Data Source=MYPCPRO;Initial Catalog=db_ukk;Integrated Security=True;TrustServerCertificate=True;"
            );
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                connection.Open();
                string query = "SELECT FullName FROM dbo.[table] WHERE username=@Username AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader fl = cmd.ExecuteReader();
                if (fl.Read())
                {
                    string fullname = fl["FullName"].ToString();
                    MessageBox.Show("Login berhasil", "Suksess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HomeForm home = new HomeForm(fullname);
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username dan Password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fl.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("terjadi kesalahan" + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
