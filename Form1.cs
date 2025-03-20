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
    public partial class Form1 : Form
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
                try
                {
                    conn.Open();
                    string query = "SELECT NIM as [NIM], Nama, Email, Telepon, Alamat from Mahasiswa";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvmahasiswa.AutoGenerateColumns = true;
                    dgvmahasiswa.DataSource = dt;

                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
           
        }

        private void BtnCreate(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    if(txtNIM.Text == "" || txtNama.Text == "" || txtTelepon.Text == "")
                    {
                        MessageBox.Show("NIM, Nama, dan Telepon harus diisi", "Warning");
                    }

                    conn.Open();
                    string query = "INSERT INTO Mahasiswa (NIM, Nama, Email, Telepon, Alamat) VALUES (@NIM, @Nama, @Email, @Telepon, @Alamat)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIM", txtNIM.Text);
                        cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Telepon", txtTelepon.Text);
                        cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil ditambahkan", "Sukses" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                            LoadData();
                            ClearForm();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
    }
}
