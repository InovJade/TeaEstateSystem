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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbWorker = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnMarkAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDeleteAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnDeleteRange = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvAttendance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = false;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(244, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mark Attendance";
            // 
            // cmbWorker
            // 
            this.cmbWorker.BackColor = System.Drawing.Color.Transparent;
            this.cmbWorker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbWorker.BorderRadius = 10;
            this.cmbWorker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbWorker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbWorker.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbWorker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbWorker.ForeColor = System.Drawing.Color.White;
            this.cmbWorker.ItemHeight = 30;
            this.cmbWorker.Location = new System.Drawing.Point(219, 70);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(191, 36);
            this.cmbWorker.TabIndex = 16;
            // 
            // dtpDate
            // 
            this.dtpDate.BorderRadius = 10;
            this.dtpDate.Checked = true;
            this.dtpDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.ForeColor = System.Drawing.Color.White;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.Location = new System.Drawing.Point(213, 119);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 36);
            this.dtpDate.TabIndex = 17;
            this.dtpDate.Value = new System.DateTime(2026, 7, 7, 3, 8, 52, 189);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbStatus.BorderRadius = 10;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.White;
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.cmbStatus.Location = new System.Drawing.Point(219, 166);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(191, 36);
            this.cmbStatus.TabIndex = 18;
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnMarkAttendance.BorderRadius = 8;
            this.btnMarkAttendance.BorderThickness = 2;
            this.btnMarkAttendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMarkAttendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMarkAttendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMarkAttendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMarkAttendance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMarkAttendance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMarkAttendance.ForeColor = System.Drawing.Color.Black;
            this.btnMarkAttendance.Image = global::TeaEstateSystem.Properties.Resources.hbjnk_removebg_preview1;
            this.btnMarkAttendance.Location = new System.Drawing.Point(215, 216);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(199, 41);
            this.btnMarkAttendance.TabIndex = 19;
            this.btnMarkAttendance.Text = "Mark Attendance";
            this.btnMarkAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Delete Attendance Single day";
            // 
            // btnDeleteAttendance
            // 
            this.btnDeleteAttendance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteAttendance.BorderRadius = 8;
            this.btnDeleteAttendance.BorderThickness = 2;
            this.btnDeleteAttendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAttendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAttendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAttendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAttendance.FillColor = System.Drawing.Color.Red;
            this.btnDeleteAttendance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAttendance.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAttendance.Image = global::TeaEstateSystem.Properties.Resources.hbjnk_removebg_preview1;
            this.btnDeleteAttendance.Location = new System.Drawing.Point(342, 284);
            this.btnDeleteAttendance.Name = "btnDeleteAttendance";
            this.btnDeleteAttendance.Size = new System.Drawing.Size(199, 41);
            this.btnDeleteAttendance.TabIndex = 21;
            this.btnDeleteAttendance.Text = "Delete";
            this.btnDeleteAttendance.Click += new System.EventHandler(this.btnDeleteAttendance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = false;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Delete Attendance From";
            this.label3.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderRadius = 10;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.ForeColor = System.Drawing.Color.White;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFrom.Location = new System.Drawing.Point(319, 348);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(222, 36);
            this.dtpFrom.TabIndex = 23;
            this.dtpFrom.Value = new System.DateTime(2026, 7, 7, 3, 8, 52, 189);
            // 
            // label4
            // 
            this.label4.AutoSize = false;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(94, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "Attendance to";
            // 
            // dtpTo
            // 
            this.dtpTo.BorderRadius = 10;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.ForeColor = System.Drawing.Color.White;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTo.Location = new System.Drawing.Point(319, 409);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(222, 36);
            this.dtpTo.TabIndex = 25;
            this.dtpTo.Value = new System.DateTime(2026, 7, 7, 3, 8, 52, 189);
            // 
            // btnDeleteRange
            // 
            this.btnDeleteRange.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteRange.BorderRadius = 8;
            this.btnDeleteRange.BorderThickness = 2;
            this.btnDeleteRange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteRange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteRange.FillColor = System.Drawing.Color.Red;
            this.btnDeleteRange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteRange.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRange.Image = global::TeaEstateSystem.Properties.Resources.hbjnk_removebg_preview1;
            this.btnDeleteRange.Location = new System.Drawing.Point(217, 470);
            this.btnDeleteRange.Name = "btnDeleteRange";
            this.btnDeleteRange.Size = new System.Drawing.Size(199, 41);
            this.btnDeleteRange.TabIndex = 26;
            this.btnDeleteRange.Text = "Delete Range";
            this.btnDeleteRange.Click += new System.EventHandler(this.btnDeleteAttendance_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.cmbWorker);
            this.guna2Panel1.Controls.Add(this.btnDeleteRange);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.dtpTo);
            this.guna2Panel1.Controls.Add(this.dtpDate);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.cmbStatus);
            this.guna2Panel1.Controls.Add(this.dtpFrom);
            this.guna2Panel1.Controls.Add(this.btnMarkAttendance);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnDeleteAttendance);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(633, 541);
            this.guna2Panel1.TabIndex = 27;
            // 
            // dgvAttendance
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttendance.ColumnHeadersHeight = 4;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAttendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAttendance.Location = new System.Drawing.Point(651, 12);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.Size = new System.Drawing.Size(745, 541);
            this.dgvAttendance.TabIndex = 28;
            this.dgvAttendance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAttendance.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvAttendance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvAttendance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAttendance.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvAttendance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvAttendance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAttendance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAttendance.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAttendance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeaEstateSystem.Properties.Resources.images__7_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1419, 565);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbWorker;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2Button btnMarkAttendance;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAttendance;
        private Guna.UI2.WinForms.Guna2HtmlLabel label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2HtmlLabel label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2Button btnDeleteRange;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAttendance;
    }
}