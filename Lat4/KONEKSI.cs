using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lat4
{
    internal class KONEKSI
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=SAMS-PC\SQLSAMS; Initial Catalog=Lat4; Integrated Security=True";
            return conn;
        }

        public bool IsConnectionValid()
        {
            using (SqlConnection connection = GetConn())
            {
                try
                {
                    connection.Open();
                    return true; // Koneksi berhasil
                }
                catch (SqlException)
                {
                    return false; // Gagal terhubung
                }
            }
        }
    }
}
