using MySql.Data.MySqlClient;
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
    public partial class WorkersForm : Form
    {
        public WorkersForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query =
                        "INSERT INTO Workers " +
                        "(FullName,NIC,Phone,Address,DateJoined) " +
                        "VALUES " +
                        "(@name,@nic,@phone,@address,@date)";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@date", dtpJoined.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Worker Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
