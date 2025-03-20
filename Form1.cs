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

namespace CRUDsederhana
{
    public partial class Form1: Form 
    {
        private string connectionString = "Data Source=LAPTOP-EKC9LDBK\\PANNNTASTIC;Initial Catalog=OrganisasiMahasiswa;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void ClearForm() 
        {
            txtNIM.Clear();
            txtNama.Clear();
            txtTelepon.Clear();
            txtAlamat.Clear();
            txtEmail.Clear();

            txtNIM.Focus();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();
                string query = "SELECT NIM as [NIM], Nama, Email, Telepon, Alamat from Mahasiswa";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
            }
        }

    }
}
