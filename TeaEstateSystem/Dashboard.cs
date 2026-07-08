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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TeaEstateSystem
{
    public partial class Dashboard : Form
    {
        private DBConnection db = new DBConnection();
        private SqlConnection con;

        public Dashboard(string username, string role)
        {
            InitializeComponent();

            lblUser.Text = "Welcome " + username;
            lblRole.Text = "Role: " + role;

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }
        private void LoadDashboard()
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Total Workers
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Workers", conn);
                    lblTotalWorkers.Text = cmd.ExecuteScalar().ToString();

                    // Present Today
                    cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Attendance WHERE AttendanceDate=@Date AND Status='Present'", conn);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Today);
                    lblPresentToday.Text = cmd.ExecuteScalar().ToString();

                    // Total Sections
                    cmd = new SqlCommand("SELECT COUNT(*) FROM Sections", conn);
                    lblTotalSections.Text = cmd.ExecuteScalar().ToString();

                    // Today's Collection
                    cmd = new SqlCommand(
                        "SELECT ISNULL(SUM(Weight),0) FROM TeaCollection WHERE CollectionDate=@Date", conn);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Today);

                    decimal todayCollection = Convert.ToDecimal(cmd.ExecuteScalar());
                    lblTodayCollection.Text = todayCollection.ToString("0.00") + " kg";

                    // Average Collection
                    cmd = new SqlCommand(
                        "SELECT ISNULL(AVG(Weight),0) FROM TeaCollection", conn);

                    decimal avg = Convert.ToDecimal(cmd.ExecuteScalar());
                    lblAverageCollection.Text = avg.ToString("0.00") + " kg";

                    // Highest Yield Section
                    cmd = new SqlCommand(@"
                    SELECT TOP 1 s.SectionName
                    FROM TeaCollection tc
                    INNER JOIN Sections s
                        ON tc.SectionID = s.SectionID
                    GROUP BY s.SectionName
                    ORDER BY SUM(tc.Weight) DESC", conn);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        lblHighestSection.Text = result.ToString();
                    else
                        lblHighestSection.Text = "No Data";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            WorkersForm frm = new WorkersForm();
            frm.ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm af = new AttendanceForm();
            af.Show();
        }

        private void btnTeaCollection_Click(object sender, EventArgs e)
        {
            TeaCollectionForm teaForm = new TeaCollectionForm();
            teaForm.Show();
        }

        private void btnSections_Click_1(object sender, EventArgs e)
        {
            SectionsForm sectionsForm = new SectionsForm();
            sectionsForm.Show();
        }

        private void btnGreenLeafProcessing_Click(object sender, EventArgs e)
        {
            GreenLeafProcessingForm frm = new GreenLeafProcessingForm();
            frm.ShowDialog();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm frm = new ReportsForm();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnPrediction_Click(object sender, EventArgs e)
        {
            PredictionForm frm = new PredictionForm();
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboard();

            MessageBox.Show("Dashboard refreshed successfully.",
                            "Refresh",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }
    }
}
