using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Threading;

namespace Lat4
{
    public partial class Payment : Form
    {
        KONEKSI KONN = new KONEKSI();
        private SqlCommand cmd;
        private SqlDataReader rd;
        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable dt;
        private string MemberID, VehicleID, MembershipID, HourlyID, ParDaID, VehicleTypeID1, VehicleTypeID;

        private void PLATE_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();

            VEHICLETYPE.Enabled = false;

            cmd = new SqlCommand("select count(*) from Vehicle where license_plate='" + PLATE.Text + "'", conn);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                cmd = new SqlCommand("select * from Vehicle where license_plate='" + PLATE.Text + "';", conn);
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        VehicleID = rd[1].ToString();
                        MemberID = rd[2].ToString();
                    }
                    rd.Close();
                }

                cmd = new SqlCommand("select * from Member where id='" + MemberID + "';", conn);
                {
                    SqlDataReader rd1 = cmd.ExecuteReader();
                    while (rd1.Read())
                    {
                        OWNER.Text = rd1[2].ToString();
                        MembershipID = rd1[1].ToString();
                    }
                    rd1.Close();
                }

                cmd = new SqlCommand("select * from Membership where id='" + MembershipID + "';", conn);
                {
                    SqlDataReader rd2 = cmd.ExecuteReader();
                    while (rd2.Read())
                    {
                       MEMBERTYPE.Text = rd2[1].ToString();
                    }
                    rd2.Close();
                }

                cmd = new SqlCommand("select * from VehicleType where id='" + VehicleID + "';", conn);
                {
                    SqlDataReader rd3 = cmd.ExecuteReader();
                    while (rd3.Read())
                    {
                        VEHICLETYPE.Text = rd3[1].ToString();
                    }
                    rd3.Close();
                }

            }
            else
            {
                VEHICLETYPE.Enabled = true;
                VehicleType();
            }
        }

        private void DATEIN_TextChanged(object sender, EventArgs e)
        {
            DateTime DateIn, DateOut, TimeIn, TimeOut, In, Out;
            if(DateTime.TryParse(DATEIN.Text, out DateIn) && DateTime.TryParse(DATEOUT.Text, out DateOut) && DateTime.TryParse(TIMEIN.Text, out TimeIn) && DateTime.TryParse(TIMEOUT.Text, out TimeOut))
            {
                In = new DateTime(DateIn.Year, DateIn.Month, DateIn.Day, TimeIn.Hour, TimeIn.Minute, TimeIn.Second);
                Out = new DateTime(DateOut.Year, DateOut.Month, DateOut.Day, TimeOut.Hour, TimeOut.Minute, TimeOut.Second);

                TimeSpan Hasil = Out - In;
                double Durasi = Hasil.TotalHours;

                PARDUR.Text = Durasi.ToString();
            }
            else
            {

            }
        }

        private void TIMEIN_TextChanged(object sender, EventArgs e)
        {
            DateTime DateIn, DateOut, TimeIn, TimeOut, In, Out;
            if (DateTime.TryParse(DATEIN.Text, out DateIn) && DateTime.TryParse(DATEOUT.Text, out DateOut) && DateTime.TryParse(TIMEIN.Text, out TimeIn) && DateTime.TryParse(TIMEOUT.Text, out TimeOut))
            {
                In = new DateTime(DateIn.Year, DateIn.Month, DateIn.Day, TimeIn.Hour, TimeIn.Minute, TimeIn.Second);
                Out = new DateTime(DateOut.Year, DateOut.Month, DateOut.Day, TimeOut.Hour, TimeOut.Minute, TimeOut.Second);

                TimeSpan Hasil = Out - In;
                double Durasi = Hasil.TotalHours;

                PARDUR.Text = Durasi.ToString();
            }
            else
            {

            }
        }

        private void DATEOUT_TextChanged(object sender, EventArgs e)
        {
            DateTime DateIn, DateOut, TimeIn, TimeOut, In, Out;
            if (DateTime.TryParse(DATEIN.Text, out DateIn) && DateTime.TryParse(DATEOUT.Text, out DateOut) && DateTime.TryParse(TIMEIN.Text, out TimeIn) && DateTime.TryParse(TIMEOUT.Text, out TimeOut))
            {
                In = new DateTime(DateIn.Year, DateIn.Month, DateIn.Day, TimeIn.Hour, TimeIn.Minute, TimeIn.Second);
                Out = new DateTime(DateOut.Year, DateOut.Month, DateOut.Day, TimeOut.Hour, TimeOut.Minute, TimeOut.Second);

                TimeSpan Hasil = Out - In;
                double Durasi = Hasil.TotalHours;

                PARDUR.Text = Durasi.ToString();
            }
            else
            {

            }
        }

        private void TIMEOUT_TextChanged(object sender, EventArgs e)
        {
            DateTime DateIn, DateOut, TimeIn, TimeOut, In, Out;
            if (DateTime.TryParse(DATEIN.Text, out DateIn) && DateTime.TryParse(DATEOUT.Text, out DateOut) && DateTime.TryParse(TIMEIN.Text, out TimeIn) && DateTime.TryParse(TIMEOUT.Text, out TimeOut))
            {
                In = new DateTime(DateIn.Year, DateIn.Month, DateIn.Day, TimeIn.Hour, TimeIn.Minute, TimeIn.Second);
                Out = new DateTime(DateOut.Year, DateOut.Month, DateOut.Day, TimeOut.Hour, TimeOut.Minute, TimeOut.Second);

                TimeSpan Hasil = Out - In;
                double Durasi = Hasil.TotalHours;

                PARDUR.Text = Durasi.ToString();
            }
            else
            {

            }
        }

        private void PARDUR_TextChanged(object sender, EventArgs e)
        {
            if (PARDUR.Text.Trim() == "" || HOURLY.Text.Trim() == "")
            {
            }
            else
            {
                double Pardur, Hourly, Hasil;
                Pardur = Convert.ToInt32(PARDUR.Text);
                Hourly = Convert.ToInt32(HOURLY.Text);
                Hasil = Pardur * Hourly;
                AMOUNT.Text = Hasil.ToString();
            }

        }

        private void HOURLY_TextChanged(object sender, EventArgs e)
        {
            if (PARDUR.Text.Trim() == "" || HOURLY.Text.Trim() == "")
            {
            }
            else
            {
                double Pardur, Hourly, Hasil;
                Pardur = Convert.ToInt32(PARDUR.Text);
                Hourly = Convert.ToInt32(HOURLY.Text);
                Hasil = Pardur * Hourly;
                AMOUNT.Text = Hasil.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DateIn, DateOut, In, Out;
            TimeSpan TimeIn, TimeOut;
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            if (PLATE.Text.Trim() == "" || DATEIN.Text.Trim() == "" || DATEOUT.Text.Trim() == "" || TIMEIN.Text.Trim() == "" || TIMEOUT.Text.Trim() == "" || OWNER.Text.Trim() == "" || MEMBERTYPE.Text.Trim() == "" || AMOUNT.Text.Trim() == "" || HOURLY.Text.Trim() == "" || PARDUR.Text.Trim() == "")
            {
                MessageBox.Show("Silahkan Isi Data Dengan Benar");
            }
            else
            {
                try
                {
                    DateIn = Convert.ToDateTime(DATEIN.Text);
                    DateOut = Convert.ToDateTime(DATEOUT.Text);
                    TimeIn = Convert.ToDateTime(TIMEIN.Text).TimeOfDay;
                    TimeOut = Convert.ToDateTime(TIMEOUT.Text).TimeOfDay;
                    In = new DateTime(DateIn.Year, DateIn.Month, DateIn.Day, TimeIn.Hours, TimeIn.Minutes, TimeIn.Seconds);
                    Out = new DateTime(DateOut.Year, DateOut.Month, DateOut.Day, TimeOut.Hours, TimeOut.Minutes, TimeOut.Seconds);
                    KodePardur();
                    cmd = new SqlCommand("insert into ParkingData(id, license_plate, vehicle_id, employee_id, hourly_rates_id, datetime_in, datetime_out, amount_to_pay, created_at) values ('" + ParDaID + "','" + PLATE.Text + "','" + VehicleID + "','" + Login.UsernameKu + "','" + HourlyID + "','" + In + "','" + Out + "','" + AMOUNT.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')", conn);
                    cmd.ExecuteNonQuery();
                    Kosong();
                    MessageBox.Show("Data Berhasil Dimasukkan");
                }
                catch (Exception d)
                {
                    MessageBox.Show("Data Gagal Dimasukkan");
                    MessageBox.Show(d.ToString());
                }
            }
            conn.Close();
        }

        private void DATEOUT_Validating(object sender, CancelEventArgs e)
        {
            DateTime DateValue;
            if (DATEOUT.Text.Trim() == "")
            {
               
            }
            else if (!DateTime.TryParse(DATEOUT.Text, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateValue))
            {
                MessageBox.Show("Bukan tanggal yang valid!");
                e.Cancel = true;
            }
            else
            {

            }
        }

        private void DATEIN_Validating(object sender, CancelEventArgs e)
        {
            DateTime DateValue;
            if (DATEIN.Text.Trim() == "")
            {
                
            }
            else if (!DateTime.TryParse(DATEIN.Text, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateValue))
            {
                MessageBox.Show("Bukan tanggal yang valid!");
                e.Cancel = true;
            }
            else
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Kosong()
        {
            PLATE.Clear();
            MEMBERTYPE.Text = "";
            DATEIN.Clear();
            DATEOUT.Clear();
            TIMEIN.Clear();
            TIMEOUT.Clear();
            OWNER.Clear();
            MEMBERTYPE.Text = "";
            PARDUR.Clear();
            HOURLY.Clear();
            AMOUNT.Clear();

        }
        private void VEHICLETYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();


            cmd = new SqlCommand("select * from VehicleType where name='" + VEHICLETYPE.Text + "';", conn);
            {
             SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                   VehicleTypeID1 = rd[0].ToString();
                }
                rd.Close();
            }

            SqlCommand cmd1 = new SqlCommand("select count(*) from Vehicle where license_plate='" + PLATE.Text + "'", conn);
            int count = (int)cmd1.ExecuteScalar();
            if (count > 0)
            {
                cmd = new SqlCommand("select * from HourlyRates where vehicle_type_id='" + VehicleTypeID1 + "';", conn);
                {
                    SqlDataReader rd1 = cmd.ExecuteReader();
                    while (rd1.Read())
                    {
                        HOURLY.Text = rd1[3].ToString();
                        HourlyID = rd1[0].ToString();
                    }
                    rd1.Close();
                }
            }
            else
            {
                cmd = new SqlCommand("select * from HourlyRates where vehicle_type_id='" + VehicleTypeID1 + "';", conn);
                {
                    SqlDataReader rd2 = cmd.ExecuteReader();
                    while (rd2.Read())
                    {
                        int H = Convert.ToInt32(rd2[3].ToString()) + 2000;
                        HOURLY.Text = H.ToString();
                        HourlyID = rd2[0].ToString();
                       
                    }
                    rd2.Close();
                }
               
            }
            conn.Close();
        }

       
        public void KodePardur()
        {
            long Hitung;
            string urutan;
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from ParkingData where id in(select max(id) from ParkingData) order by id desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                Hitung = Convert.ToInt32(rd[0].ToString().Substring(rd["id"].ToString().Length - 6, 6)) + 1;
                String Urutannya = "000000" + Hitung;
                urutan = "PKD-" + Urutannya.Substring(Urutannya.Length - 6, 6);
            }
            else
            {
                urutan = "PKD-000001";
            }
            rd.Close();
            conn.Close();
            ParDaID = urutan;
        }
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            VEHICLETYPE.Enabled = false;
            Kosong();
        }

        public void VehicleType()
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            da = new SqlDataAdapter("select * from VehicleType", conn);
            dt = new DataTable();
            da.Fill(dt);
            VEHICLETYPE.DataSource = dt;
            VEHICLETYPE.ValueMember = "id";
            VEHICLETYPE.DisplayMember = "name";
            conn.Close();
        }
    }
}
