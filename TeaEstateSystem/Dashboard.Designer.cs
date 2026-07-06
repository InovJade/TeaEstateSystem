namespace TeaEstateSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnTeaCollection = new System.Windows.Forms.Button();
            this.btnSections = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(341, 150);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Your Name";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(341, 202);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(54, 13);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Your Role";
            this.lblRole.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.Location = new System.Drawing.Point(320, 238);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(100, 38);
            this.btnWorkers.TabIndex = 2;
            this.btnWorkers.Text = "Workers";
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Location = new System.Drawing.Point(320, 291);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(100, 34);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnTeaCollection
            // 
            this.btnTeaCollection.Location = new System.Drawing.Point(320, 331);
            this.btnTeaCollection.Name = "btnTeaCollection";
            this.btnTeaCollection.Size = new System.Drawing.Size(100, 40);
            this.btnTeaCollection.TabIndex = 4;
            this.btnTeaCollection.Text = "Tea Collection";
            this.btnTeaCollection.UseVisualStyleBackColor = true;
            this.btnTeaCollection.Click += new System.EventHandler(this.btnTeaCollection_Click);
            // 
            // btnSections
            // 
            this.btnSections.Location = new System.Drawing.Point(320, 377);
            this.btnSections.Name = "btnSections";
            this.btnSections.Size = new System.Drawing.Size(100, 36);
            this.btnSections.TabIndex = 5;
            this.btnSections.Text = "Sections";
            this.btnSections.UseVisualStyleBackColor = true;
            this.btnSections.Click += new System.EventHandler(this.btnSections_Click_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSections);
            this.Controls.Add(this.btnTeaCollection);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnWorkers);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUser);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnTeaCollection;
        private System.Windows.Forms.Button btnSections;
    }
}