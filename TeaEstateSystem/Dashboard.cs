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

        }
    }
}
