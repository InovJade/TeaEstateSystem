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
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");

                return;
            }
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlCommand checkUser = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE Username=@user", conn);

                    checkUser.Parameters.AddWithValue("@user", txtUsername.Text);

                    int exists = Convert.ToInt32(checkUser.ExecuteScalar());

                    if (exists > 0)
                    {
                        MessageBox.Show("Username already exists.");

                        return;
                    }

                    string query =

                        "INSERT INTO Users (FullName, Username, PasswordHash, Role) " +
                        "VALUES (@name, @user, @pass, @role)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass",
                        PasswordHelper.HashPassword(txtPassword.Text));
                    cmd.Parameters.AddWithValue("@role", "Clerk");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User Registered Successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
