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
    public partial class PredictionForm : Form
    {
        DBConnection db = new DBConnection();

        int predictionID = 0;
        public PredictionForm()
        {
            InitializeComponent();
        }

        private void PredictionForm_Load(object sender, EventArgs e)
        {
            if (UserSession.Role == "Clerk")
            {
                btnDelete.Visible = false;
            }

            LoadSections();
            LoadPredictionHistory();
            ClearFields();
        }
        private void LoadSections()
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(

                        "SELECT SectionID, SectionName FROM Sections ORDER BY SectionName",

                        conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cmbSection.DataSource = dt;

                    cmbSection.DisplayMember = "SectionName";

                    cmbSection.ValueMember = "SectionID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadPredictionHistory()
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"

            SELECT

            ph.PredictionID,

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

            ORDER BY ph.PredictionDate DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvPrediction.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearFields()
        {
            predictionID = 0;

            if (cmbSection.Items.Count > 0)
                cmbSection.SelectedIndex = 0;

            dtpPredictionDate.Value = DateTime.Today;

            txtAverageYield.Clear();

            txtAttendance.Clear();

            txtPluckingFactor.Clear();

            txtSeasonFactor.Clear();

            txtPredictedYield.Clear();

            txtFormula.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPredictionHistory();

            ClearFields();
        }
        private decimal GetSeasonFactor()
        {
            int month = dtpPredictionDate.Value.Month;

            switch (month)
            {
                case 1:
                    return 0.95m;

                case 2:
                    return 0.97m;

                case 3:
                    return 1.00m;

                case 4:
                    return 1.05m;

                case 5:
                    return 1.10m;

                case 6:
                    return 1.08m;

                case 7:
                    return 1.00m;

                case 8:
                    return 0.98m;

                case 9:
                    return 1.02m;

                case 10:
                    return 1.06m;

                case 11:
                    return 1.03m;

                default:
                    return 0.96m;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            CalculatePrediction();
        }
        private void CalculatePrediction()
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    int sectionID = Convert.ToInt32(cmbSection.SelectedValue);

                    //avg yeild==

                    decimal averageYield = 0;

                    SqlCommand cmd = new SqlCommand(@"
                    SELECT ISNULL(AVG(Weight),0)
                    FROM TeaCollection
                    WHERE SectionID=@SectionID", conn);

                    cmd.Parameters.AddWithValue("@SectionID", sectionID);

                    averageYield = Convert.ToDecimal(cmd.ExecuteScalar());

                    txtAverageYield.Text = averageYield.ToString("0.00");

                   //attend precen

                    SqlCommand totalCmd =
                        new SqlCommand("SELECT COUNT(*) FROM Workers", conn);

                    int totalWorkers =
                        Convert.ToInt32(totalCmd.ExecuteScalar());

                    SqlCommand presentCmd = new SqlCommand(@"
                    SELECT COUNT(*)
                    FROM Attendance
                    WHERE AttendanceDate=@Date
                    AND Status='Present'", conn);

                    presentCmd.Parameters.AddWithValue("@Date", DateTime.Today);

                    int presentWorkers =
                        Convert.ToInt32(presentCmd.ExecuteScalar());

                    decimal attendance = 0;

                    if (totalWorkers > 0)
                        attendance = (decimal)presentWorkers / totalWorkers;

                    txtAttendance.Text = (attendance * 100).ToString("0.00");

                    //pluck factor

                    SqlCommand sectionCmd = new SqlCommand(@"
                    SELECT LastPluckingDate
                    FROM Sections
                    WHERE SectionID=@SectionID", conn);

                    sectionCmd.Parameters.AddWithValue("@SectionID", sectionID);

                    object lastDate = sectionCmd.ExecuteScalar();

                    decimal pluckingFactor = 1.00m;

                    if (lastDate != DBNull.Value)
                    {
                        DateTime lastPlucking =
                            Convert.ToDateTime(lastDate);

                        int days =
                            (dtpPredictionDate.Value.Date - lastPlucking).Days;

                        if (days < 5)
                            pluckingFactor = 0.90m;
                        else if (days <= 7)
                            pluckingFactor = 1.00m;
                        else if (days <= 10)
                            pluckingFactor = 1.05m;
                        else
                            pluckingFactor = 1.10m;
                    }

                    txtPluckingFactor.Text =
                        pluckingFactor.ToString("0.00");

                    //season fac (dont change btw)

                    decimal season =
                        GetSeasonFactor();

                    txtSeasonFactor.Text =
                        season.ToString("0.00");

                   // STARRRR of the project prediction

                    decimal prediction =
                        averageYield *
                        attendance *
                        pluckingFactor *
                        season;

                    txtPredictedYield.Text =
                        prediction.ToString("0.00");

                    //BTS behind the secenes
                

                    txtFormula.Text =
                        averageYield.ToString("0.00")
                        + " × "
                        + attendance.ToString("0.00")
                        + " × "
                        + pluckingFactor.ToString("0.00")
                        + " × "
                        + season.ToString("0.00")
                        + " = "
                        + prediction.ToString("0.00")
                        + " kg";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPredictedYield.Text == "")
            {
                MessageBox.Show("Generate prediction first.");
                return;
            }

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"
            INSERT INTO PredictionHistory
            (
                SectionID,
                PredictionDate,
                AverageYield,
                AttendancePercentage,
                PluckingFactor,
                SeasonFactor,
                PredictedYield,
                Accuracy
            )

            VALUES

            (
                @SectionID,
                @PredictionDate,
                @AverageYield,
                @Attendance,
                @PluckingFactor,
                @SeasonFactor,
                @Prediction,
                NULL
            )", conn);

                    cmd.Parameters.AddWithValue("@SectionID",
                        cmbSection.SelectedValue);

                    cmd.Parameters.AddWithValue("@PredictionDate",
                        dtpPredictionDate.Value.Date);

                    cmd.Parameters.AddWithValue("@AverageYield",
                        txtAverageYield.Text);

                    cmd.Parameters.AddWithValue("@Attendance",
                        txtAttendance.Text);

                    cmd.Parameters.AddWithValue("@PluckingFactor",
                        txtPluckingFactor.Text);

                    cmd.Parameters.AddWithValue("@SeasonFactor",
                        txtSeasonFactor.Text);

                    cmd.Parameters.AddWithValue("@Prediction",
                        txtPredictedYield.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Prediction saved successfully.");

                    LoadPredictionHistory();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPrediction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPrediction.Rows[e.RowIndex];

                predictionID = Convert.ToInt32(row.Cells["PredictionID"].Value);

                cmbSection.Text = row.Cells["SectionName"].Value.ToString();

                dtpPredictionDate.Value =
                    Convert.ToDateTime(row.Cells["PredictionDate"].Value);

                txtAverageYield.Text =
                    row.Cells["AverageYield"].Value.ToString();

                txtAttendance.Text =
                    row.Cells["AttendancePercentage"].Value.ToString();

                txtPluckingFactor.Text =
                    row.Cells["PluckingFactor"].Value.ToString();

                txtSeasonFactor.Text =
                    row.Cells["SeasonFactor"].Value.ToString();

                txtPredictedYield.Text =
                    row.Cells["PredictedYield"].Value.ToString();

                txtFormula.Text =
                    txtAverageYield.Text +
                    " × " +
                    (Convert.ToDecimal(txtAttendance.Text) / 100).ToString("0.00") +
                    " × " +
                    txtPluckingFactor.Text +
                    " × " +
                    txtSeasonFactor.Text +
                    " = " +
                    txtPredictedYield.Text + " kg";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (predictionID == 0)
            {
                MessageBox.Show("Please select a prediction.");

                return;
            }

            if (MessageBox.Show("Delete this prediction?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = db.GetConnection())
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(
                            "DELETE FROM PredictionHistory WHERE PredictionID=@ID",
                            conn);

                        cmd.Parameters.AddWithValue("@ID", predictionID);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Prediction deleted.");

                        LoadPredictionHistory();

                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private decimal CalculateAccuracy(decimal predicted, decimal actual)
        {
            if (actual == 0)
                return 0;

            decimal accuracy =
                100 - ((Math.Abs(predicted - actual) / actual) * 100);

            if (accuracy < 0)
                accuracy = 0;

            return Math.Round(accuracy, 2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {

        }
    }
}
