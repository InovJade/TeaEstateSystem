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
    public partial class GreenLeafProcessingForm : Form
    {
        DBConnection db = new DBConnection();

        int processingID = 0;
        public GreenLeafProcessingForm()
        {
            InitializeComponent();
        }

        private void GreenLeafProcessingForm_Load(object sender, EventArgs e)
        {
            if (UserSession.Role == "Clerk")
            {
                btnDelete.Visible = false;
            }

            LoadCollections();
            LoadProcessing();
        }
        private void LoadCollections()
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
                    SELECT
                        tc.CollectionID,
                        'Collection #' + CAST(tc.CollectionID AS VARCHAR)
                        + ' - Worker ' + w.FullName
                        + ' - ' + s.SectionName AS DisplayText
                    FROM TeaCollection tc
                    INNER JOIN Workers w
                        ON tc.WorkerID = w.WorkerID
                    INNER JOIN Sections s
                        ON tc.SectionID = s.SectionID
                    ORDER BY tc.CollectionID";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cmbCollection.DataSource = dt;

                    cmbCollection.DisplayMember = "DisplayText";

                    cmbCollection.ValueMember = "CollectionID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadProcessing()
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
                    SELECT
                        gp.ProcessingID,
                        tc.CollectionID,
                        w.FullName,
                        s.SectionName,
                        gp.ProcessingDate,
                        gp.GreenLeafWeight,
                        gp.MadeTeaWeight,
                        gp.WasteWeight,
                        gp.MoistureLoss,
                        gp.Remarks
                    FROM GreenLeafProcessing gp
                    INNER JOIN TeaCollection tc
                        ON gp.CollectionID = tc.CollectionID
                    INNER JOIN Workers w
                        ON tc.WorkerID = w.WorkerID
                    INNER JOIN Sections s
                        ON tc.SectionID = s.SectionID";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvProcessing.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCollection.SelectedIndex == -1 ||
                   txtGreenLeafWeight.Text == "" ||
                   txtMadeTeaWeight.Text == "" ||
                   txtWasteWeight.Text == "" ||
                   txtMoistureLoss.Text == "")
            {
                MessageBox.Show("Please fill all required fields.");

                return;
            }

            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
            INSERT INTO GreenLeafProcessing
            (
                CollectionID,
                ProcessingDate,
                GreenLeafWeight,
                MadeTeaWeight,
                WasteWeight,
                MoistureLoss,
                Remarks
            )
            VALUES
            (
                @CollectionID,
                @ProcessingDate,
                @GreenLeafWeight,
                @MadeTeaWeight,
                @WasteWeight,
                @MoistureLoss,
                @Remarks
            )";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@CollectionID", cmbCollection.SelectedValue);

                    cmd.Parameters.AddWithValue("@ProcessingDate", dtpProcessingDate.Value.Date);

                    cmd.Parameters.AddWithValue("@GreenLeafWeight", txtGreenLeafWeight.Text);

                    cmd.Parameters.AddWithValue("@MadeTeaWeight", txtMadeTeaWeight.Text);

                    cmd.Parameters.AddWithValue("@WasteWeight", txtWasteWeight.Text);

                    cmd.Parameters.AddWithValue("@MoistureLoss", txtMoistureLoss.Text);

                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Processing record saved successfully.");

                    LoadProcessing();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearFields()
        {
            cmbCollection.SelectedIndex = 0;

            dtpProcessingDate.Value = DateTime.Now;

            txtGreenLeafWeight.Clear();

            txtMadeTeaWeight.Clear();

            txtWasteWeight.Clear();

            txtMoistureLoss.Clear();

            txtRemarks.Clear();

            processingID = 0;
        }

        private void txtMadeTeaWeight_TextChanged(object sender, EventArgs e)
        {
            CalculateValues();
        }

        private void txtWasteWeight_TextChanged(object sender, EventArgs e)
        {
            CalculateValues();
        }
        private void CalculateValues()
        {
            if (decimal.TryParse(txtGreenLeafWeight.Text, out decimal greenLeaf) &&
                decimal.TryParse(txtMadeTeaWeight.Text, out decimal madeTea))
            {
                decimal waste = greenLeaf - madeTea;

                if (waste < 0)
                    waste = 0;

                txtWasteWeight.Text = waste.ToString("0.00");

                decimal moisture = 0;

                if (greenLeaf > 0)
                    moisture = (waste / greenLeaf) * 100;

                txtMoistureLoss.Text = moisture.ToString("0.00");
            }
            else
            {
                txtWasteWeight.Clear();
                txtMoistureLoss.Clear();
            }
        }

        private void txtMoistureLoss_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProcessing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProcessing.Rows[e.RowIndex];

                processingID = Convert.ToInt32(row.Cells["ProcessingID"].Value);

                cmbCollection.Text =
                    "Collection #" + row.Cells["CollectionID"].Value.ToString()
                    + " - Worker " + row.Cells["FullName"].Value.ToString()
                    + " - " + row.Cells["SectionName"].Value.ToString();

                dtpProcessingDate.Value =
                    Convert.ToDateTime(row.Cells["ProcessingDate"].Value);

                txtGreenLeafWeight.Text =
                    row.Cells["GreenLeafWeight"].Value.ToString();

                txtMadeTeaWeight.Text =
                    row.Cells["MadeTeaWeight"].Value.ToString();

                txtWasteWeight.Text =
                    row.Cells["WasteWeight"].Value.ToString();

                txtMoistureLoss.Text =
                    row.Cells["MoistureLoss"].Value.ToString();

                txtRemarks.Text =
                    row.Cells["Remarks"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (processingID == 0)
            {
                MessageBox.Show("Please select a record.");

                return;
            }

            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
            UPDATE GreenLeafProcessing
            SET

            CollectionID=@CollectionID,
            ProcessingDate=@ProcessingDate,
            GreenLeafWeight=@GreenLeafWeight,
            MadeTeaWeight=@MadeTeaWeight,
            WasteWeight=@WasteWeight,
            MoistureLoss=@MoistureLoss,
            Remarks=@Remarks

            WHERE ProcessingID=@ProcessingID";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@CollectionID", cmbCollection.SelectedValue);
                    cmd.Parameters.AddWithValue("@ProcessingDate", dtpProcessingDate.Value.Date);
                    cmd.Parameters.AddWithValue("@GreenLeafWeight", txtGreenLeafWeight.Text);
                    cmd.Parameters.AddWithValue("@MadeTeaWeight", txtMadeTeaWeight.Text);
                    cmd.Parameters.AddWithValue("@WasteWeight", txtWasteWeight.Text);
                    cmd.Parameters.AddWithValue("@MoistureLoss", txtMoistureLoss.Text);
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
                    cmd.Parameters.AddWithValue("@ProcessingID", processingID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record updated successfully.");

                    LoadProcessing();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (processingID == 0)
            {
                MessageBox.Show("Please select a record.");

                return;
            }

            if (MessageBox.Show("Delete this record?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DBConnection db = new DBConnection();

                    using (SqlConnection conn = db.GetConnection())
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(
                            "DELETE FROM GreenLeafProcessing WHERE ProcessingID=@id", conn);

                        cmd.Parameters.AddWithValue("@id", processingID);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Record deleted.");

                        LoadProcessing();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
