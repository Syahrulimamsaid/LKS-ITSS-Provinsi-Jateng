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

namespace Lat4
{
    public partial class MAINMENU : Form
    {
        KONEKSI KONN = new KONEKSI();
        private SqlCommand cmd;
        private SqlDataReader rd;
        public MAINMENU()
        {
            InitializeComponent();
        }

        private void MAINMENU_Load(object sender, EventArgs e)
        {
            TampilUsername();
            timer1.Start();
        }
        
        public void TampilUsername()
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Employee where id='" + Login.UsernameKu + "';", conn);
            {
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    label1.Text = "Welcome, [ " + rd[1].ToString() + " ]";
                }
                rd.Close();
                conn.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("[dddd], dd-MM-yyyy, HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterMember G = new MasterMember()
            {
                TopLevel = false, TopMost = true
            };
            G.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(G);
            G.Show();
            MasterVehicle L = new MasterVehicle();
            L.Hide();
            Payment d = new Payment();
            d.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MasterVehicle G = new MasterVehicle()
            {
                TopLevel = false,
                TopMost = true
            };
            G.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(G);
            G.Show();
            MasterMember L = new MasterMember();
            L.Hide();
            Payment d = new Payment();
            d.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Payment G = new Payment()
            {
                TopLevel = false,
                TopMost = true
            };
            G.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(G);
            G.Show();
            MasterVehicle L = new MasterVehicle();
            L.Hide();
            MasterMember d = new MasterMember();
            d.Hide();
        }
    }
}
