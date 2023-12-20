using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lat4.KONEKSI;

namespace Lat4
{
    public partial class Login : Form
    {
        KONEKSI KONN = new KONEKSI();
        private SqlCommand cmd;
        private SqlDataReader rd;
        public static string UsernameKu;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            bool isConnected = KONN.IsConnectionValid();

            if (isConnected)
            {
                MessageBox.Show("Koneksi berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal terhubung dengan database.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Employee where id='" + USER.Text + "' and password='" + textBox2.Text + "'" ,conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            
            if(rd.HasRows)
            {
                UsernameKu = USER.Text;
                MAINMENU k = new MAINMENU();
                k.Show();
                this.Hide();
                MessageBox.Show("Selamat Datang");
               
            }
            else
            {
                MessageBox.Show("Password/Username Salah");
            }
            conn.Close();
            rd.Close();
        }
    }
}
