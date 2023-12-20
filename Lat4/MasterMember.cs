using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lat4
{
    public partial class MasterMember : Form
    {
        KONEKSI KONN = new KONEKSI();
        private SqlCommand cmd;
        private SqlDataReader rd;
        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable dt;
        private string Gender, ID, MemberShipID;
        public MasterMember()
        {
            InitializeComponent();
        }

        private void MasterMember_Load(object sender, EventArgs e)
        {
            Tampil();
            Kosong();
            Tutup();
            labelStatus.Hide();
            dataGridView1.Enabled = false;
        }
        
        public void Kosong()
        {
            NAME.Clear();
            MEMBERTYPE.Text = "";
            EMAIL.Clear();
            HP.Clear();
            ADDRESS.Clear();
            DATE.Clear();
            MALE.Checked = false;
            FEMALE.Checked = false;
        }
        public void Tutup()
        {
            NAME.Enabled = false;
            MEMBERTYPE.Enabled = false;
            EMAIL.Enabled = false;
            HP.Enabled = false;
            ADDRESS.Enabled = false;
            DATE.Enabled = false ;
            MALE.Enabled = false;
            FEMALE.Enabled = false;
        }

        public void Buka()
        {
            NAME.Enabled = true;
            MEMBERTYPE.Enabled = true;
            EMAIL.Enabled = true;
            HP.Enabled = true;
            ADDRESS.Enabled = true;
            DATE.Enabled = true;
            MALE.Enabled = true;
            FEMALE.Enabled = true;
        }
        public void Tampil()
        {
            SqlConnection conn = KONN.GetConn();
            da = new SqlDataAdapter("select id, membership_id, name, email, phone_number, address, date_of_birth, gender from Member where deleted_at is null", conn);
            ds = new DataSet();
            da.Fill(ds, "Member");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Member";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void MALE_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "MALE";
        }

        private void FEMALE_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "FEMALE";
        }

        public void Kode()
        {
            long Hitung;
            string urutan;
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Member where id in(select max(id) from Member) order by id desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();

            if(rd.HasRows)
            {
                Hitung = Convert.ToInt32(rd[0].ToString().Substring(rd["id"].ToString().Length - 6, 6)) + 1;
                String Urutannya = "000000" + Hitung;
                urutan = "MBR-" + Urutannya.Substring(Urutannya.Length - 6, 6);
            }
            else
            {
                urutan = "MBR-000001";
            }
            rd.Close();
            conn.Close();
            ID = urutan;
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            INSERT.Enabled = false;
            UPDATE.Enabled = false;
            DELETE.Enabled = false;
            SMBINSERT.Show();
            SMBDELETE.Hide();
            SMBUPDATE.Hide();
            SMBINSERT.Enabled = true;
            SMBDELETE.Enabled = false;
            SMBUPDATE.Enabled = false;
            dataGridView1.Enabled = false;
            TampilMemberType();
            Buka();
            MessageBox.Show("Silahkan Isi Data");
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            INSERT.Enabled = false;
            UPDATE.Enabled = false;
            DELETE.Enabled = false;
            SMBINSERT.Hide();
            SMBDELETE.Hide();
            SMBUPDATE.Show();
            SMBINSERT.Enabled = false;
            SMBDELETE.Enabled = false;
            SMBUPDATE.Enabled = true;
            dataGridView1.Enabled = true;
            TampilMemberType();
            Buka();
            MessageBox.Show("Silahkan Pilih Data");
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            INSERT.Enabled = false;
            UPDATE.Enabled = false;
            DELETE.Enabled = false;
            SMBINSERT.Hide();
            SMBDELETE.Show();
            SMBUPDATE.Hide();
            SMBINSERT.Enabled = false;
            SMBDELETE.Enabled = true;
            SMBUPDATE.Enabled = false;
            dataGridView1.Enabled = true;
            TampilMemberType();
            MessageBox.Show("Silahkan Pilih Data");
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            Kosong();
            Tutup();
            dataGridView1.Enabled = false;
            INSERT.Enabled = true;
            UPDATE.Enabled = true;
            DELETE.Enabled = true;
            SMBINSERT.Enabled = false;
            SMBDELETE.Enabled = false;
            SMBUPDATE.Enabled = false;
            SMBINSERT.Show();
            SMBDELETE.Show();
            SMBUPDATE.Show();
            labelStatus.Hide();
        }

        private void SMBINSERT_Click(object sender, EventArgs e)
        {
            DateTime DateValue;
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            if (NAME.Text.Trim() == "" || MEMBERTYPE.Text.Trim() == "" || EMAIL.Text.Trim() == "" || HP.Text.Trim() == "" || ADDRESS.Text.Trim() == "" || DATE.Text.Trim() == "" || Gender == null)
            {
                MessageBox.Show("Isi Data Dengan Banar");
            }
            else if(HP.Text.Length <= 10)
            {
                MessageBox.Show("Phone Number less than 10 digit");
            }
            else if (!DateTime.TryParse(DATE.Text, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateValue))
            {
                MessageBox.Show("Tanggal Belum Benar");
            }
            else if(IsValidPhone(HP) == false)
            {
                MessageBox.Show("Data is not Phone Number");
            }
            else
            {
                try
                {
                    Kode();
                    cmd = new SqlCommand("insert into Member(id, membership_id, name, email, phone_number, address, date_of_birth, gender, created_at) values ('" + ID + "','" + MemberShipID + "','" + NAME.Text + "','" + EMAIL.Text + "','" + HP.Text + "','" + ADDRESS.Text + "','" + DATE.Text + "','" + Gender + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')", conn);
                    cmd.ExecuteNonQuery();
                    Tampil();
                    Kosong();
                    Kosong();
                    Tutup();
                    dataGridView1.Enabled = false;
                    INSERT.Enabled = true;
                    UPDATE.Enabled = true;
                    DELETE.Enabled = true;
                    SMBINSERT.Enabled = false;
                    SMBDELETE.Enabled = false;
                    SMBUPDATE.Enabled = false;
                    SMBINSERT.Show();
                    SMBDELETE.Show();
                    SMBUPDATE.Show();
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
        private bool IsValidPhone(System.Windows.Forms.TextBox text)
        {
            string Phone = text.Text;
            return Regex.IsMatch(Phone,@"^\d+$");
        }
        private void DATE_Validating(object sender, CancelEventArgs e)
        {
            DateTime DateValue;
            if (!DateTime.TryParse(DATE.Text, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateValue))
            {
                MessageBox.Show("Bukan tanggal yang valid!");
                e.Cancel = true;
            }
            else
            {

            }
        }

        private void SMBUPDATE_Click(object sender, EventArgs e)
        {
            DateTime DateValue;
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            if (NAME.Text.Trim() == "" || MEMBERTYPE.Text.Trim() == "" || EMAIL.Text.Trim() == "" || HP.Text.Trim() == "" || ADDRESS.Text.Trim() == "" || DATE.Text.Trim() == "" || Gender == null)
            {
                MessageBox.Show("Pilih Data Dengan Banar");
            }
            else if (HP.Text.Length <= 10)
            {
                MessageBox.Show("Phone Number less than 10 digit");
            }
            else if (!DateTime.TryParse(DATE.Text, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateValue))
            {
                MessageBox.Show("Tanggal Belum Benar");
            }
            else if (IsValidPhone(HP) == false)
            {
                MessageBox.Show("Data is not Phone Number");
            }
            else if(MessageBox.Show("Yakin Data Akan Diubah??", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand("update Member set membership_id='" + MemberShipID + "', name='" + NAME.Text + "', email='" + EMAIL.Text + "', phone_number='" + HP.Text + "', address='" + ADDRESS.Text + "', date_of_birth='" + DATE.Text + "', gender='" + Gender + "', last_updated_at='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where id='" + ID + "'", conn);
                    cmd.ExecuteNonQuery();
                    Tampil();
                    Kosong();
                    Tutup();
                    dataGridView1.Enabled = false;
                    INSERT.Enabled = true;
                    UPDATE.Enabled = true;
                    DELETE.Enabled = true;
                    SMBINSERT.Enabled = false;
                    SMBDELETE.Enabled = false;
                    SMBUPDATE.Enabled = false;
                    SMBINSERT.Show();
                    SMBDELETE.Show();
                    SMBUPDATE.Show();
                    labelStatus.Hide();
                    MessageBox.Show("Data Berhasil Diubah");
                }
                catch (Exception d)
                {
                    MessageBox.Show("Data Gagal Diubah");
                    MessageBox.Show(d.ToString());
                }
            }
            else
            {
               
            }
            conn.Close();
        }

        private void SMBDELETE_Click(object sender, EventArgs e)
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            if (NAME.Text.Trim() == "" || MEMBERTYPE.Text.Trim() == "" || EMAIL.Text.Trim() == "" || HP.Text.Trim() == "" || ADDRESS.Text.Trim() == "" || DATE.Text.Trim() == "" || Gender == null)
            {
                MessageBox.Show("Pilih Data Dengan Banar");
            }
            else if(MessageBox.Show("Yakin Data Akan Dihapus??", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand("update Member set deleted_at='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where id='" + ID + "'", conn);
                    cmd.ExecuteNonQuery();
                    Tampil();
                    Kosong();
                    Tutup();
                    dataGridView1.Enabled = false;
                    INSERT.Enabled = true;
                    UPDATE.Enabled = true;
                    DELETE.Enabled = true;
                    SMBINSERT.Enabled = false;
                    SMBDELETE.Enabled = false;
                    SMBUPDATE.Enabled = false;
                    SMBINSERT.Show();
                    SMBDELETE.Show();
                    SMBUPDATE.Show();
                    labelStatus.Hide();
                    MessageBox.Show("Data Berhasil Dihapus");
                }
                catch (Exception d)
                {
                    MessageBox.Show("Data Gagal Dihapus");
                    MessageBox.Show(d.ToString());
                }
            }
            else
            {

            }
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelStatus.Show();
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            DataGridViewRow Row = this.dataGridView1.Rows[e.RowIndex];
            ID = Row.Cells[0].Value.ToString();
            MemberShipID = Row.Cells[1].Value.ToString();
            NAME.Text = Row.Cells[2].Value.ToString();
            EMAIL.Text = Row.Cells[3].Value.ToString();
            HP.Text = Row.Cells[4].Value.ToString();
            ADDRESS.Text = Row.Cells[5].Value.ToString();
            DATE.Text = Row.Cells[6].Value.ToString();
            Gender = Row.Cells[7].Value.ToString();

            if(Gender == "MALE")
            {
                MALE.Checked = true;
                FEMALE.Checked = false;
            }
            else
            {
                MALE.Checked = false;
                FEMALE.Checked = true;
            }

            cmd = new SqlCommand("select * from Membership where id='" + MemberShipID + "';", conn);
            {
               SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    MEMBERTYPE.Text = rd[1].ToString();
                }
                rd.Close();
            }

            cmd = new SqlCommand("select * from Member where id='" + ID + "';",conn);
            {
               SqlDataReader rd1 = cmd.ExecuteReader();
                while (rd1.Read())
                {
                    if(rd1.IsDBNull(9))
                    {
                        labelStatus.Text = "This data never updated";
                    }
                    else
                    {
                        labelStatus.Text = "This record is last modified at " + rd1[9].ToString();
                    }
                }
                rd1.Close();
            }
            conn.Close();
        }

        private void DATE_TextChanged(object sender, EventArgs e)
        {

        }

        private void MEMBERTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Membership where name='" + MEMBERTYPE.Text + "';", conn);
            {
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    MemberShipID = rd[0].ToString();
                }
                rd.Close();
            }
            conn.Close();
        }

        public void TampilMemberType()
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            da = new SqlDataAdapter("select * from Membership",conn);
            dt = new DataTable();
            da.Fill(dt);
            MEMBERTYPE.DataSource = dt;
            MEMBERTYPE.ValueMember = "id";
            MEMBERTYPE.DisplayMember = "name";
            conn.Close();
        }
    }
}
