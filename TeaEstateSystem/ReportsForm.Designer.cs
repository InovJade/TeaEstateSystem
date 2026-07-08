namespace TeaEstateSystem
{
    partial class ReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLoadReport = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbReportType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.dgvReports = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnLoadReport.BorderRadius = 8;
            this.btnLoadReport.BorderThickness = 2;
            this.btnLoadReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLoadReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadReport.ForeColor = System.Drawing.Color.Black;
            this.btnLoadReport.Image = global::TeaEstateSystem.Properties.Resources.hbjnk_removebg_preview1;
            this.btnLoadReport.Location = new System.Drawing.Point(308, 162);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(131, 41);
            this.btnLoadReport.TabIndex = 37;
            this.btnLoadReport.Text = "Load Report";
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = false;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(423, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(254, 27);
            this.label14.TabIndex = 36;
            this.label14.Text = "Tea Estate Report Center";
            // 
            // cmbReportType
            // 
            this.cmbReportType.BackColor = System.Drawing.Color.Transparent;
            this.cmbReportType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbReportType.BorderRadius = 10;
            this.cmbReportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbReportType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbReportType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbReportType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbReportType.ForeColor = System.Drawing.Color.White;
            this.cmbReportType.ItemHeight = 30;
            this.cmbReportType.Items.AddRange(new object[] {
            "Workers Report",
            "Attendance Report",
            "Sections Report",
            "Tea Collection Report",
            "Green Leaf Processing Report",
            "Prediction Report"});
            this.cmbReportType.Location = new System.Drawing.Point(423, 95);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(191, 36);
            this.cmbReportType.TabIndex = 38;
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.BorderThickness = 2;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::TeaEstateSystem.Properties.Resources.hbjnk_removebg_preview1;
            this.btnRefresh.Location = new System.Drawing.Point(455, 162);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 41);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnClose.BorderRadius = 8;
            this.btnClose.BorderThickness = 2;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::TeaEstateSystem.Properties.Resources.hbjnk_removebg_preview1;
            this.btnClose.Location = new System.Drawing.Point(603, 162);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 41);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvReports
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReports.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReports.ColumnHeadersHeight = 4;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReports.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReports.Location = new System.Drawing.Point(26, 233);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.RowHeadersWidth = 51;
            this.dgvReports.RowTemplate.Height = 24;
            this.dgvReports.Size = new System.Drawing.Size(991, 268);
            this.dgvReports.TabIndex = 51;
            this.dgvReports.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReports.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvReports.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvReports.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReports.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvReports.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvReports.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReports.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReports.ThemeStyle.RowsStyle.Height = 24;
            this.dgvReports.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.label14);
            this.guna2Panel1.Controls.Add(this.dgvReports);
            this.guna2Panel1.Controls.Add(this.cmbReportType);
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Controls.Add(this.btnLoadReport);
            this.guna2Panel1.Controls.Add(this.btnRefresh);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1043, 530);
            this.guna2Panel1.TabIndex = 52;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeaEstateSystem.Properties.Resources.images__7_8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportsForm";
            this.Text = "Tea Estate Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnLoadReport;
        private Guna.UI2.WinForms.Guna2HtmlLabel label14;
        private Guna.UI2.WinForms.Guna2ComboBox cmbReportType;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReports;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}