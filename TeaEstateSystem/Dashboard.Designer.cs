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
            this.btnGreenLeafProcessing = new System.Windows.Forms.Button();
            this.btnPrediction = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTotalWorkersTitle = new System.Windows.Forms.Label();
            this.lblTotalWorkers = new System.Windows.Forms.Label();
            this.lblPresentTodayTitle = new System.Windows.Forms.Label();
            this.lblPresentToday = new System.Windows.Forms.Label();
            this.lblTotalSectionsTitle = new System.Windows.Forms.Label();
            this.lblTotalSections = new System.Windows.Forms.Label();
            this.lblTodayCollectionTitle = new System.Windows.Forms.Label();
            this.lblTodayCollection = new System.Windows.Forms.Label();
            this.lblAverageCollectionTitle = new System.Windows.Forms.Label();
            this.lblAverageCollection = new System.Windows.Forms.Label();
            this.lblHighestSectionTitle = new System.Windows.Forms.Label();
            this.lblHighestSection = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(31, 18);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Your Name";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(31, 66);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(54, 13);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Your Role";
            this.lblRole.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.Location = new System.Drawing.Point(12, 113);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(100, 38);
            this.btnWorkers.TabIndex = 2;
            this.btnWorkers.Text = "Workers";
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Location = new System.Drawing.Point(12, 166);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(100, 34);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnTeaCollection
            // 
            this.btnTeaCollection.Location = new System.Drawing.Point(12, 215);
            this.btnTeaCollection.Name = "btnTeaCollection";
            this.btnTeaCollection.Size = new System.Drawing.Size(100, 40);
            this.btnTeaCollection.TabIndex = 4;
            this.btnTeaCollection.Text = "Tea Collection";
            this.btnTeaCollection.UseVisualStyleBackColor = true;
            this.btnTeaCollection.Click += new System.EventHandler(this.btnTeaCollection_Click);
            // 
            // btnSections
            // 
            this.btnSections.Location = new System.Drawing.Point(12, 272);
            this.btnSections.Name = "btnSections";
            this.btnSections.Size = new System.Drawing.Size(100, 36);
            this.btnSections.TabIndex = 5;
            this.btnSections.Text = "Sections";
            this.btnSections.UseVisualStyleBackColor = true;
            this.btnSections.Click += new System.EventHandler(this.btnSections_Click_1);
            // 
            // btnGreenLeafProcessing
            // 
            this.btnGreenLeafProcessing.Location = new System.Drawing.Point(12, 326);
            this.btnGreenLeafProcessing.Name = "btnGreenLeafProcessing";
            this.btnGreenLeafProcessing.Size = new System.Drawing.Size(125, 33);
            this.btnGreenLeafProcessing.TabIndex = 6;
            this.btnGreenLeafProcessing.Text = "Green Leaf Processing";
            this.btnGreenLeafProcessing.UseVisualStyleBackColor = true;
            this.btnGreenLeafProcessing.Click += new System.EventHandler(this.btnGreenLeafProcessing_Click);
            // 
            // btnPrediction
            // 
            this.btnPrediction.Location = new System.Drawing.Point(12, 374);
            this.btnPrediction.Name = "btnPrediction";
            this.btnPrediction.Size = new System.Drawing.Size(100, 33);
            this.btnPrediction.TabIndex = 7;
            this.btnPrediction.Text = "Predictions";
            this.btnPrediction.UseVisualStyleBackColor = true;
            this.btnPrediction.Click += new System.EventHandler(this.btnPrediction_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(12, 423);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(100, 33);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 478);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 33);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTotalWorkersTitle
            // 
            this.lblTotalWorkersTitle.AutoSize = true;
            this.lblTotalWorkersTitle.Location = new System.Drawing.Point(479, 66);
            this.lblTotalWorkersTitle.Name = "lblTotalWorkersTitle";
            this.lblTotalWorkersTitle.Size = new System.Drawing.Size(74, 13);
            this.lblTotalWorkersTitle.TabIndex = 11;
            this.lblTotalWorkersTitle.Text = "Total Workers";
            // 
            // lblTotalWorkers
            // 
            this.lblTotalWorkers.AutoSize = true;
            this.lblTotalWorkers.Location = new System.Drawing.Point(635, 66);
            this.lblTotalWorkers.Name = "lblTotalWorkers";
            this.lblTotalWorkers.Size = new System.Drawing.Size(13, 13);
            this.lblTotalWorkers.TabIndex = 12;
            this.lblTotalWorkers.Text = "0";
            // 
            // lblPresentTodayTitle
            // 
            this.lblPresentTodayTitle.AutoSize = true;
            this.lblPresentTodayTitle.Location = new System.Drawing.Point(476, 95);
            this.lblPresentTodayTitle.Name = "lblPresentTodayTitle";
            this.lblPresentTodayTitle.Size = new System.Drawing.Size(76, 13);
            this.lblPresentTodayTitle.TabIndex = 13;
            this.lblPresentTodayTitle.Text = "Present Today";
            // 
            // lblPresentToday
            // 
            this.lblPresentToday.AutoSize = true;
            this.lblPresentToday.Location = new System.Drawing.Point(635, 95);
            this.lblPresentToday.Name = "lblPresentToday";
            this.lblPresentToday.Size = new System.Drawing.Size(13, 13);
            this.lblPresentToday.TabIndex = 14;
            this.lblPresentToday.Text = "0";
            // 
            // lblTotalSectionsTitle
            // 
            this.lblTotalSectionsTitle.AutoSize = true;
            this.lblTotalSectionsTitle.Location = new System.Drawing.Point(477, 187);
            this.lblTotalSectionsTitle.Name = "lblTotalSectionsTitle";
            this.lblTotalSectionsTitle.Size = new System.Drawing.Size(75, 13);
            this.lblTotalSectionsTitle.TabIndex = 15;
            this.lblTotalSectionsTitle.Text = "Total Sections";
            // 
            // lblTotalSections
            // 
            this.lblTotalSections.AutoSize = true;
            this.lblTotalSections.Location = new System.Drawing.Point(635, 187);
            this.lblTotalSections.Name = "lblTotalSections";
            this.lblTotalSections.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSections.TabIndex = 16;
            this.lblTotalSections.Text = "0";
            // 
            // lblTodayCollectionTitle
            // 
            this.lblTodayCollectionTitle.AutoSize = true;
            this.lblTodayCollectionTitle.Location = new System.Drawing.Point(476, 215);
            this.lblTodayCollectionTitle.Name = "lblTodayCollectionTitle";
            this.lblTodayCollectionTitle.Size = new System.Drawing.Size(89, 13);
            this.lblTodayCollectionTitle.TabIndex = 17;
            this.lblTodayCollectionTitle.Text = "Today Collection ";
            // 
            // lblTodayCollection
            // 
            this.lblTodayCollection.AutoSize = true;
            this.lblTodayCollection.Location = new System.Drawing.Point(630, 215);
            this.lblTodayCollection.Name = "lblTodayCollection";
            this.lblTodayCollection.Size = new System.Drawing.Size(28, 13);
            this.lblTodayCollection.TabIndex = 18;
            this.lblTodayCollection.Text = "0 kg";
            // 
            // lblAverageCollectionTitle
            // 
            this.lblAverageCollectionTitle.AutoSize = true;
            this.lblAverageCollectionTitle.Location = new System.Drawing.Point(466, 308);
            this.lblAverageCollectionTitle.Name = "lblAverageCollectionTitle";
            this.lblAverageCollectionTitle.Size = new System.Drawing.Size(99, 13);
            this.lblAverageCollectionTitle.TabIndex = 19;
            this.lblAverageCollectionTitle.Text = "Average Collection ";
            // 
            // lblAverageCollection
            // 
            this.lblAverageCollection.AutoSize = true;
            this.lblAverageCollection.Location = new System.Drawing.Point(635, 308);
            this.lblAverageCollection.Name = "lblAverageCollection";
            this.lblAverageCollection.Size = new System.Drawing.Size(28, 13);
            this.lblAverageCollection.TabIndex = 20;
            this.lblAverageCollection.Text = "0 kg";
            // 
            // lblHighestSectionTitle
            // 
            this.lblHighestSectionTitle.AutoSize = true;
            this.lblHighestSectionTitle.Location = new System.Drawing.Point(467, 336);
            this.lblHighestSectionTitle.Name = "lblHighestSectionTitle";
            this.lblHighestSectionTitle.Size = new System.Drawing.Size(108, 13);
            this.lblHighestSectionTitle.TabIndex = 21;
            this.lblHighestSectionTitle.Text = "Highest Yield Section";
            // 
            // lblHighestSection
            // 
            this.lblHighestSection.AutoSize = true;
            this.lblHighestSection.Location = new System.Drawing.Point(630, 336);
            this.lblHighestSection.Name = "lblHighestSection";
            this.lblHighestSection.Size = new System.Drawing.Size(33, 13);
            this.lblHighestSection.TabIndex = 22;
            this.lblHighestSection.Text = "None";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(532, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Attendance";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(532, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Collection Status";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(564, 272);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Yield";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(522, 391);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 32);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 640);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblHighestSection);
            this.Controls.Add(this.lblHighestSectionTitle);
            this.Controls.Add(this.lblAverageCollection);
            this.Controls.Add(this.lblAverageCollectionTitle);
            this.Controls.Add(this.lblTodayCollection);
            this.Controls.Add(this.lblTodayCollectionTitle);
            this.Controls.Add(this.lblTotalSections);
            this.Controls.Add(this.lblTotalSectionsTitle);
            this.Controls.Add(this.lblPresentToday);
            this.Controls.Add(this.lblPresentTodayTitle);
            this.Controls.Add(this.lblTotalWorkers);
            this.Controls.Add(this.lblTotalWorkersTitle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnPrediction);
            this.Controls.Add(this.btnGreenLeafProcessing);
            this.Controls.Add(this.btnSections);
            this.Controls.Add(this.btnTeaCollection);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnWorkers);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUser);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Click += new System.EventHandler(this.Dashboard_Click);
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
        private System.Windows.Forms.Button btnGreenLeafProcessing;
        private System.Windows.Forms.Button btnPrediction;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTotalWorkersTitle;
        private System.Windows.Forms.Label lblTotalWorkers;
        private System.Windows.Forms.Label lblPresentTodayTitle;
        private System.Windows.Forms.Label lblPresentToday;
        private System.Windows.Forms.Label lblTotalSectionsTitle;
        private System.Windows.Forms.Label lblTotalSections;
        private System.Windows.Forms.Label lblTodayCollectionTitle;
        private System.Windows.Forms.Label lblTodayCollection;
        private System.Windows.Forms.Label lblAverageCollectionTitle;
        private System.Windows.Forms.Label lblAverageCollection;
        private System.Windows.Forms.Label lblHighestSectionTitle;
        private System.Windows.Forms.Label lblHighestSection;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRefresh;
    }
}