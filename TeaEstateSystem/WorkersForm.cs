using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaEstateSystem
{
    public partial class WorkersForm : Form
    {
        DBConnection db = new DBConnection();

        public WorkersForm()
        {
            InitializeComponent();
        }

        private void LoadWorkers()
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter da =
                        new SqlDataAdapter("SELECT * FROM Workers", conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvWorkers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }


        private void WorkersForm_Load(object sender, EventArgs e)
        {
            if (UserSession.Role == "Clerk")
            {
                btnDelete.Visible = false;
            }
            LoadWorkers();
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtNIC.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Workers
                                    (FullName, NIC, Phone, Address, DateJoined)
                                    VALUES
                                    (@name, @nic, @phone, @address, @date)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@date", dtpJoined.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Worker Saved");

                    LoadWorkers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Error: " + ex.Message);
            }
        }

        private void dgvWorkers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvWorkers.CurrentRow != null)
            {
                txtFullName.Text = dgvWorkers.CurrentRow.Cells["FullName"].Value.ToString();
                txtNIC.Text = dgvWorkers.CurrentRow.Cells["NIC"].Value.ToString();
                txtPhone.Text = dgvWorkers.CurrentRow.Cells["Phone"].Value.ToString();
                txtAddress.Text = dgvWorkers.CurrentRow.Cells["Address"].Value.ToString();
                dtpJoined.Value = Convert.ToDateTime(dgvWorkers.CurrentRow.Cells["DateJoined"].Value);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE Workers
                             SET FullName=@name,
                                 NIC=@nic,
                                 Phone=@phone,
                                 Address=@address,
                                 DateJoined=@date
                             WHERE WorkerID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", dgvWorkers.CurrentRow.Cells["WorkerID"].Value);
                    cmd.Parameters.AddWithValue("@name", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@date", dtpJoined.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Worker Updated");

                    LoadWorkers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM Workers WHERE WorkerID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", dgvWorkers.CurrentRow.Cells["WorkerID"].Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Worker Deleted");

                    LoadWorkers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
