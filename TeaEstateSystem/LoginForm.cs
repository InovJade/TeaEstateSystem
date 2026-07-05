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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query =
                        "SELECT * FROM Users WHERE Username=@user AND PasswordHash=@pass";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass",
                        PasswordHelper.HashPassword(txtPassword.Text));

                     SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string username = reader["Username"].ToString();
                        string role = reader["Role"].ToString();

                        Dashboard d = new Dashboard(username, role);

                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm r = new RegisterForm();
            r.ShowDialog();
        }
    }
}
