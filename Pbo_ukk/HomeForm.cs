using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pbo_ukk
{
    public partial class HomeForm : Form
    {
        public HomeForm(string fullnama)
        {
            InitializeComponent();
            lbnama.Text = "Selamat Datang," + fullnama;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1  login = new Form1();
            login.Show();

        }
    }
}
