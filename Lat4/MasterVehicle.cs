using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Globalization;

namespace Lat4
{
    public partial class MasterVehicle : Form
    {
        KONEKSI KONN = new KONEKSI();
        private SqlCommand cmd;
        private SqlDataReader rd;
        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable dt;
        private string ID, VehicleID, MemberID;
        public MasterVehicle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void Tampil()
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            da = new SqlDataAdapter("select id, vehicle_type_id, member_id, license_plate, notes from Vehicle where deleted_at is null", conn);
            ds = new DataSet();
            da.Fill(ds, "Vehicle");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Vehicle";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void NAME_TextChanged(object sender, EventArgs e)
        {   
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Member where name='" + OWNER.Text + "';", conn);
            {
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    MemberID = rd[0].ToString();
                }
                rd.Close();
            }
            conn.Close();
        }
        public void Cari()
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            da = new SqlDataAdapter("select Vehicle.id as vid, Vehicle.member_id as vmd, Member.id as mi, Member.name as mn, Vehicle.deleted_at as vda from Vehicle inner join Member on Vehicle.member_id=Member.id where Vehicle.deleted_at is null", conn);
            var D = new HashSet<string>();
            SqlDataReader rd = da.SelectCommand.ExecuteReader();
            while (rd.Read())
            {
                D.Add(rd["mn"].ToString());
            }
            SEARCH.Items.AddRange(D.ToArray());
            rd.Close();
            conn.Close();
        }
        private void MasterVehicle_Load(object sender, EventArgs e)
        {
            Tampil();
            dataGridView1.Enabled = false;
            labelStatus.Hide();
            Tutup();
            Cari();
            SEARCH.Text = "";
        }

        public void AutoCompleteMember()
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Member", conn);
            rd = cmd.ExecuteReader();

            AutoCompleteStringCollection Suggest = new AutoCompleteStringCollection();

            while(rd.Read())
            {
                Suggest.Add(rd[2].ToString());
            }

            OWNER.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            OWNER.AutoCompleteSource = AutoCompleteSource.CustomSource;
            OWNER.AutoCompleteCustomSource = Suggest;
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
            VehicleType();
            Buka();
            AutoCompleteMember();
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
            VehicleType();
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
            VehicleType();
            MessageBox.Show("Silahkan Pilih Data");
        }
        public void Kosong()
        {
            PLATE.Text = "XX XXXX XX";
            VEHICLETYPE.Text = "";
            OWNER.Clear();
            NOTES.Clear();
        }
        public void Tutup()
        {
            PLATE.Enabled = false;
            VEHICLETYPE.Enabled = false;
            OWNER.Enabled = false;
            NOTES.Enabled = false;
        }

        public void Buka()
        {
            PLATE.Enabled = true;
            VEHICLETYPE.Enabled = true;
            OWNER.Enabled = true;
            NOTES.Enabled = true;
        }

        private void SMBINSERT_Click(object sender, EventArgs e)
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();

            cmd = new SqlCommand("select count(*) from Member where name='" + OWNER.Text + "'", conn);
            int count = (int)cmd.ExecuteScalar();

            if (PLATE.Text.Trim() == "" || VEHICLETYPE.Text.Trim() == "" || OWNER.Text.Trim() == "" || NOTES.Text.Trim() == "")
            {
                MessageBox.Show("Isi Data Dengan Banar");
            }
            else if (count > 0)
            {
                try
                {
                    Kode();
                    cmd = new SqlCommand("insert into Vehicle(id, vehicle_type_id, member_id, license_plate, notes, created_at) values ('" + ID + "','" + VehicleID + "','" + MemberID + "','" + PLATE.Text + "','" + NOTES.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')", conn);
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
                    MessageBox.Show("Data Berhasil Dimasukkan");
                }
                catch (Exception d)
                {
                    MessageBox.Show("Data Gagal Dimasukkan");
                    MessageBox.Show(d.ToString());
                }
            }
            else
            {
                MessageBox.Show("Data Owner tidak tersedia");
            }
            conn.Close();
        }

        private void SMBUPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            cmd = new SqlCommand("select count(*) from Member where name='" + OWNER.Text + "'", conn);
            int count = (int)cmd.ExecuteScalar();

            if (PLATE.Text.Trim() == "" || VEHICLETYPE.Text.Trim() == "" || OWNER.Text.Trim() == "" || NOTES.Text.Trim() == "")
            {
                MessageBox.Show("Pilih Data Dengan Banar");
            }
            else if (count > 0)
            {  
                if (MessageBox.Show("Yakin Data Akan Diubah??", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("update Vehicle set vehicle_type_id='" + VehicleID + "', member_id='" + MemberID + "', license_plate='" + PLATE.Text + "', notes='" + NOTES.Text + "', last_updated_at='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where id='" + ID + "'", conn);
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
            }
            else
            {
                MessageBox.Show("Data Owner tidak tersedia");
            }
            conn.Close();
        }

        private void SMBDELETE_Click(object sender, EventArgs e)
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            if (PLATE.Text.Trim() == "" || VEHICLETYPE.Text.Trim() == "" || OWNER.Text.Trim() == "" || NOTES.Text.Trim() == "")
            {
                MessageBox.Show("Pilih Data Dengan Banar");
            }
            else if (MessageBox.Show("Yakin Data Akan Dihapus??", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand("update Vehicle set deleted_at='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where id='" + ID + "'", conn);
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

        private void SEARCH_TextChanged(object sender, EventArgs e)
        {
            if(SEARCH.Text.Trim() == "")
            {
                Tampil();
            }
            else
            {
                SqlConnection conn = KONN.GetConn();
                conn.Open();

                cmd = new SqlCommand("select * from Member where name='" + SEARCH.Text + "';", conn);
                {
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        MemberID = rd[0].ToString();
                    }
                    rd.Close();
                }

                da = new SqlDataAdapter("select id, vehicle_type_id, member_id, license_plate, notes from Vehicle where deleted_at is null and member_id like '%" + MemberID + "%'", conn);
                ds = new DataSet();
                da.Fill(ds, "Vehicle");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Vehicle";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelStatus.Show();
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            DataGridViewRow Row = this.dataGridView1.Rows[e.RowIndex];
            ID = Row.Cells[0].Value.ToString();
            VehicleID = Row.Cells[1].Value.ToString();
            MemberID = Row.Cells[2].Value.ToString();
            PLATE.Text = Row.Cells[3].Value.ToString();
            NOTES.Text = Row.Cells[4].Value.ToString();

            cmd = new SqlCommand("select * from VehicleType where id='" + VehicleID + "';", conn);
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    VEHICLETYPE.Text = rd[1].ToString();
                }
                rd.Close();
            }


            cmd = new SqlCommand("select * from Member where id='" + MemberID + "';", conn);
            {
                SqlDataReader rd2 = cmd.ExecuteReader();
                while (rd2.Read())
                {
                    OWNER.Text = rd2[2].ToString();
                }
                rd2.Close();
            }

            cmd = new SqlCommand("select * from Vehicle where id='" + ID + "';", conn);
            {
                SqlDataReader rd1 = cmd.ExecuteReader();
                while (rd1.Read())
                {
                    if (rd1.IsDBNull(6))
                    {
                        labelStatus.Text = "This data never updated";
                    }
                    else
                    {
                        labelStatus.Text = "This record is last modified at " + rd1[6].ToString();
                    }
                }
                rd1.Close();
            }
            conn.Close();
        }

        private void CARI_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            da = new SqlDataAdapter("select id, vehicle_type_id, member_id, license_plate, notes from Vehicle where deleted_at is null and license_plate like '%" + CARI.Text + "%'", conn);
            ds = new DataSet();
            da.Fill(ds,"Vehicle");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Vehicle";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

       

        private void VEHICLETYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from VehicleType where name='" + VEHICLETYPE.Text + "';", conn);
            {
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    VehicleID = rd[0].ToString();
                }
                rd.Close();
            }
            conn.Close();
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
        }
        public void Kode()
        {
            long Hitung;
            string urutan;
            SqlConnection conn = KONN.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Vehicle where id in(select max(id) from Vehicle) order by id desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                Hitung = Convert.ToInt32(rd[0].ToString().Substring(rd["id"].ToString().Length - 6, 6)) + 1;
                String Urutannya = "000000" + Hitung;
                urutan = "VHL-" + Urutannya.Substring(Urutannya.Length - 6, 6);
            }
            else
            {
                urutan = "VHL-000001";
            }
            rd.Close();
            conn.Close();
            ID = urutan;
        }
    }
}
