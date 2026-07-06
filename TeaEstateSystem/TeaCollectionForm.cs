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
    public partial class TeaCollectionForm : Form
    {
        public TeaCollectionForm()
        {
            InitializeComponent();
        }

        private void LoadWorkers()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT WorkerID, FullName FROM Workers", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbWorker.DataSource = dt;
                cmbWorker.DisplayMember = "FullName";
                cmbWorker.ValueMember = "WorkerID";
                cmbWorker.SelectedIndex = -1;
            }
        }

        private void LoadCollection()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT
                    T.CollectionID,
                    W.FullName,
                    S.SectionName,
                    T.CollectionDate,
                    T.Weight
                FROM TeaCollection T
                INNER JOIN Workers W
                    ON T.WorkerID = W.WorkerID
                INNER JOIN Sections S
                    ON T.SectionID = S.SectionID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvCollection.DataSource = dt;
            }
        }
        private void LoadSections()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT SectionID, SectionName FROM Sections",
                        conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbSection.DataSource = dt;
                cmbSection.DisplayMember = "SectionName";
                cmbSection.ValueMember = "SectionID";

                cmbSection.SelectedIndex = -1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeaCollectionForm_Load(object sender, EventArgs e)
        {
            if (UserSession.Role == "Clerk")
            {
                btnDelete.Visible = false;
            }

            LoadWorkers();
            LoadSections();
            LoadCollection();
        }   

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO TeaCollection
                    (WorkerID,SectionID,CollectionDate,Weight)
                    VALUES
                    (@id,@section,@date,@weight)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", cmbWorker.SelectedValue);
                    cmd.Parameters.AddWithValue("@section", cmbSection.SelectedValue);
                    cmd.Parameters.AddWithValue("@date", dtpCollection.Value.Date);
                    cmd.Parameters.AddWithValue("@weight", decimal.Parse(txtWeight.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Collection Saved");

                    LoadCollection();
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
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE TeaCollection
                    SET WorkerID=@id,
                        SectionID=@section,
                        CollectionDate=@date,
                        Weight=@weight
                    WHERE CollectionID=@collection";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@collection",
                        dgvCollection.CurrentRow.Cells["CollectionID"].Value);

                    cmd.Parameters.AddWithValue("@id",
                        cmbWorker.SelectedValue);

                    cmd.Parameters.AddWithValue("@section",
                        cmbSection.SelectedValue);

                    cmd.Parameters.AddWithValue("@date",
                        dtpCollection.Value.Date);

                    cmd.Parameters.AddWithValue("@weight",
                        decimal.Parse(txtWeight.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Collection Updated");

                    LoadCollection();
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
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query =
                        "DELETE FROM TeaCollection WHERE CollectionID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id",
                        dgvCollection.CurrentRow.Cells["CollectionID"].Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Collection Deleted");

                    LoadCollection();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCollection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCollection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            cmbWorker.Text =
                dgvCollection.Rows[e.RowIndex].Cells["FullName"].Value.ToString();

            cmbSection.Text =
                dgvCollection.Rows[e.RowIndex].Cells["SectionName"].Value.ToString();

            dtpCollection.Value =
                Convert.ToDateTime(
                    dgvCollection.Rows[e.RowIndex].Cells["CollectionDate"].Value);

            txtWeight.Text =
                dgvCollection.Rows[e.RowIndex].Cells["Weight"].Value.ToString();
        }
        private void ClearFields()
        {
            cmbWorker.SelectedIndex = -1;
    cmbSection.SelectedIndex = -1;

    txtWeight.Clear();

    dtpCollection.Value = DateTime.Today;
        }

    }
}
