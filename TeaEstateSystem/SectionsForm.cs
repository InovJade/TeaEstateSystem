using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class SectionsForm : Form
    {

        DBConnection db = new DBConnection();
        public SectionsForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SectionsForm_Load(object sender, EventArgs e)
        {
            if (UserSession.Role == "Clerk")
            {
                btnDelete.Visible = false;
            }

            LoadSections();

            LoadTeaTypes();

            LoadStatus();
        }
        private void LoadTeaTypes()
        {
            cmbTeaType.Items.Clear();

            cmbTeaType.Items.Add("BOP");
            cmbTeaType.Items.Add("FBOP");
            cmbTeaType.Items.Add("Dust");
            cmbTeaType.Items.Add("OP");
            cmbTeaType.Items.Add("PEKOE");

            cmbTeaType.SelectedIndex = -1;
        }
        private void LoadStatus()
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Growing");
            cmbStatus.Items.Add("Ready");
            cmbStatus.Items.Add("Maintenance");

            cmbStatus.SelectedIndex = -1;
        }
        private void LoadSections()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT * FROM Sections",
                        conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvSections.DataSource = dt;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query =
                    @"INSERT INTO Sections
            (
                SectionName,
                Area,
                BushCount,
                TeaType,
                LastPluckingDate,
                NextPluckingDate,
                Status
            )
            VALUES
            (
                @name,
                @area,
                @bush,
                @type,
                @last,
                @next,
                @status
            )";

                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name",
                        txtSectionName.Text);

                    cmd.Parameters.AddWithValue("@area",
                        Convert.ToDecimal(txtArea.Text));

                    cmd.Parameters.AddWithValue("@bush",
                        Convert.ToInt32(txtBushCount.Text));

                    cmd.Parameters.AddWithValue("@type",
                        cmbTeaType.Text);

                    cmd.Parameters.AddWithValue("@last",
                        dtpLastPlucking.Value);

                    cmd.Parameters.AddWithValue("@next",
                        dtpNextPlucking.Value);

                    cmd.Parameters.AddWithValue("@status",
                        cmbStatus.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Section Saved");

                    LoadSections();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE Sections
                            SET
                            SectionName=@name,
                            Area=@area,
                            BushCount=@bush,
                            TeaType=@type,
                            LastPluckingDate=@last,
                            NextPluckingDate=@next,
                            Status=@status
                            WHERE SectionID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id",
                        dgvSections.CurrentRow.Cells["SectionID"].Value);

                    cmd.Parameters.AddWithValue("@name", txtSectionName.Text);
                    cmd.Parameters.AddWithValue("@area", Convert.ToDecimal(txtArea.Text));
                    cmd.Parameters.AddWithValue("@bush", Convert.ToInt32(txtBushCount.Text));
                    cmd.Parameters.AddWithValue("@type", cmbTeaType.Text);
                    cmd.Parameters.AddWithValue("@last", dtpLastPlucking.Value.Date);
                    cmd.Parameters.AddWithValue("@next", dtpNextPlucking.Value.Date);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Section Updated Successfully.");

                    LoadSections();
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
            if (dgvSections.CurrentRow == null)
            {
                MessageBox.Show("Please select a section.");
                return;
            }

            if (MessageBox.Show("Delete this section?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Sections WHERE SectionID=@id", conn);

                    cmd.Parameters.AddWithValue("@id",
                        dgvSections.CurrentRow.Cells["SectionID"].Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Section Deleted Successfully.");

                    LoadSections();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvSections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgvSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtSectionName.Text =
                dgvSections.Rows[e.RowIndex].Cells["SectionName"].Value.ToString();

            txtArea.Text =
                dgvSections.Rows[e.RowIndex].Cells["Area"].Value.ToString();

            txtBushCount.Text =
                dgvSections.Rows[e.RowIndex].Cells["BushCount"].Value.ToString();

            cmbTeaType.Text =
                dgvSections.Rows[e.RowIndex].Cells["TeaType"].Value.ToString();

            dtpLastPlucking.Value =
                Convert.ToDateTime(
                    dgvSections.Rows[e.RowIndex].Cells["LastPluckingDate"].Value);

            dtpNextPlucking.Value =
                Convert.ToDateTime(
                    dgvSections.Rows[e.RowIndex].Cells["NextPluckingDate"].Value);

            cmbStatus.Text =
                dgvSections.Rows[e.RowIndex].Cells["Status"].Value.ToString();
        }
        private void ClearFields()
        {
            txtSectionName.Clear();
            txtArea.Clear();
            txtBushCount.Clear();

            cmbTeaType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            dtpLastPlucking.Value = DateTime.Today;
            dtpNextPlucking.Value = DateTime.Today;
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}
