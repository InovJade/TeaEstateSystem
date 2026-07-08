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
    public partial class ReportsForm : Form
    {
        DBConnection db = new DBConnection();
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            

            cmbReportType.SelectedIndex = 0;
            cmbReportType.SelectedIndex = 0;

            dgvReports.ReadOnly = true;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadReport()
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "";

                    switch (cmbReportType.Text)
                    {
                        case "Workers Report":

                            query = @"SELECT
                              WorkerID,
                              FullName,
                              NIC,
                              Phone,
                              Address,
                              DateJoined
                              FROM Workers
                              ORDER BY FullName";
                            break;

                        case "Attendance Report":

                            query = @"SELECT
                              w.FullName,
                              a.AttendanceDate,
                              a.Status
                              FROM Attendance a
                              INNER JOIN Workers w
                              ON a.WorkerID=w.WorkerID
                              ORDER BY AttendanceDate DESC";
                            break;

                        case "Sections Report":

                            query = @"SELECT
                              SectionName,
                              Area,
                              TeaType,
                              BushCount,
                              LastPluckingDate,
                              NextPluckingDate,
                              Status
                              FROM Sections";
                            break;

                        case "Tea Collection Report":

                            query = @"SELECT
                              tc.CollectionDate,
                              w.FullName,
                              s.SectionName,
                              tc.Weight
                              FROM TeaCollection tc
                              INNER JOIN Workers w
                              ON tc.WorkerID=w.WorkerID
                              INNER JOIN Sections s
                              ON tc.SectionID=s.SectionID
                              ORDER BY tc.CollectionDate DESC";
                            break;

                        case "Green Leaf Processing Report":

                            query = @"SELECT
                              gp.ProcessingDate,
                              s.SectionName,
                              gp.GreenLeafWeight,
                              gp.MadeTeaWeight,
                              gp.WasteWeight,
                              gp.MoistureLoss
                              FROM GreenLeafProcessing gp
                              INNER JOIN TeaCollection tc
                              ON gp.CollectionID=tc.CollectionID
                              INNER JOIN Sections s
                              ON tc.SectionID=s.SectionID
                              ORDER BY gp.ProcessingDate DESC";
                            break;

                        case "Prediction Report":

                            query = @"SELECT
                              s.SectionName,
                              ph.PredictionDate,
                              ph.AverageYield,
                              ph.AttendancePercentage,
                              ph.PluckingFactor,
                              ph.SeasonFactor,
                              ph.PredictedYield,
                              ph.Accuracy
                              FROM PredictionHistory ph
                              INNER JOIN Sections s
                              ON ph.SectionID=s.SectionID
                              ORDER BY PredictionDate DESC";
                            break;
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvReports.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}
