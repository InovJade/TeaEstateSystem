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
            if (UserSession.Role == "Clerk")
            {
                btnDeleteAttendance.Visible = false;
                btnDeleteRange.Visible = false;
                dtpFrom.Visible = false;
                dtpTo.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }

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
                ClearFields();

                cmbWorker.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;


                dtpDate.Value = DateTime.Now;
            }
        }

        private void btnDeleteAttendance_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.CurrentRow == null)
            {
                MessageBox.Show("Please select an attendance record.");
                return;
            }

            if (MessageBox.Show("Delete this attendance record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Attendance WHERE AttendanceID=@id", conn);

                    cmd.Parameters.AddWithValue("@id",
                        dgvAttendance.CurrentRow.Cells["AttendanceID"].Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Attendance deleted.");

                LoadAttendance();
                ClearFields();
            }
        }

        private void btnDeleteRange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
        "Delete attendance between these dates?",
        "Confirm",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        @"DELETE FROM Attendance
                  WHERE AttendanceDate
                  BETWEEN @from AND @to", conn);

                    cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date);
                    cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Attendance records deleted.");

                LoadAttendance();
            }

        }
        private void ClearFields()
        {
            cmbWorker.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dtpDate.Value = DateTime.Today;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
