using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;   // COPYRIGHT OWNED BY Esindu Amarajeewa 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaEstateSystem
{
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            LoadWorkers();
            LoadAttendance();
        }

        private void LoadWorkers()
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter da =
                        new SqlDataAdapter("SELECT WorkerID, FullName FROM Workers", conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbWorker.DataSource = null;

                    cmbWorker.DisplayMember = "FullName";
                    cmbWorker.ValueMember = "WorkerID";
                    cmbWorker.DataSource = dt;

                    cmbWorker.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Worker Load Error: " + ex.Message);
            }
        }

        private void LoadAttendance()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    A.AttendanceID,                                                                                                                         
                    W.FullName,
                    A.AttendanceDate,
                    A.Status
                FROM Attendance A
                INNER JOIN Workers W ON A.WorkerID = W.WorkerID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);    

                dgvAttendance.DataSource = dt;
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO Attendance
                        (WorkerID, AttendanceDate, Status)
                        VALUES (@id, @date, @status)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", cmbWorker.SelectedValue);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Attendance Marked");

                LoadAttendance();

                cmbWorker.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;

                
                dtpDate.Value = DateTime.Now;
            }
        }
    }
}
