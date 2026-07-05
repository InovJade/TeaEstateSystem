namespace TeaEstateSystem
{
    partial class AttendanceForm
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnMarkAttendance = new System.Windows.Forms.Button();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.AllowDrop = true;
            this.dtpDate.Location = new System.Drawing.Point(298, 93);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.Location = new System.Drawing.Point(360, 190);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(75, 23);
            this.btnMarkAttendance.TabIndex = 3;
            this.btnMarkAttendance.Text = "Mark Attendance";
            this.btnMarkAttendance.UseVisualStyleBackColor = true;
            this.btnMarkAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(193, 236);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.Size = new System.Drawing.Size(414, 158);
            this.dgvAttendance.TabIndex = 4;
            // 
            // cmbWorker
            // 
            this.cmbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(337, 45);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(121, 21);
            this.cmbWorker.TabIndex = 5;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.cmbStatus.Location = new System.Drawing.Point(337, 145);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 6;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbWorker);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.btnMarkAttendance);
            this.Controls.Add(this.dtpDate);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnMarkAttendance;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}