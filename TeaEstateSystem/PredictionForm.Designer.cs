namespace TeaEstateSystem
{
    partial class PredictionForm
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
            this.txtAverageYield = new System.Windows.Forms.TextBox();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.txtPluckingFactor = new System.Windows.Forms.TextBox();
            this.txtSeasonFactor = new System.Windows.Forms.TextBox();
            this.txtPredictedYield = new System.Windows.Forms.TextBox();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbSection = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpPredictionDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvPrediction = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrediction)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAverageYield
            // 
            this.txtAverageYield.Location = new System.Drawing.Point(162, 137);
            this.txtAverageYield.Margin = new System.Windows.Forms.Padding(4);
            this.txtAverageYield.Name = "txtAverageYield";
            this.txtAverageYield.ReadOnly = true;
            this.txtAverageYield.Size = new System.Drawing.Size(200, 22);
            this.txtAverageYield.TabIndex = 3;
            // 
            // txtAttendance
            // 
            this.txtAttendance.Location = new System.Drawing.Point(162, 188);
            this.txtAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.ReadOnly = true;
            this.txtAttendance.Size = new System.Drawing.Size(200, 22);
            this.txtAttendance.TabIndex = 4;
            // 
            // txtPluckingFactor
            // 
            this.txtPluckingFactor.Location = new System.Drawing.Point(162, 237);
            this.txtPluckingFactor.Margin = new System.Windows.Forms.Padding(4);
            this.txtPluckingFactor.Name = "txtPluckingFactor";
            this.txtPluckingFactor.ReadOnly = true;
            this.txtPluckingFactor.Size = new System.Drawing.Size(200, 22);
            this.txtPluckingFactor.TabIndex = 5;
            // 
            // txtSeasonFactor
            // 
            this.txtSeasonFactor.Location = new System.Drawing.Point(162, 287);
            this.txtSeasonFactor.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeasonFactor.Name = "txtSeasonFactor";
            this.txtSeasonFactor.ReadOnly = true;
            this.txtSeasonFactor.Size = new System.Drawing.Size(200, 22);
            this.txtSeasonFactor.TabIndex = 6;
            // 
            // txtPredictedYield
            // 
            this.txtPredictedYield.Location = new System.Drawing.Point(162, 339);
            this.txtPredictedYield.Margin = new System.Windows.Forms.Padding(4);
            this.txtPredictedYield.Name = "txtPredictedYield";
            this.txtPredictedYield.ReadOnly = true;
            this.txtPredictedYield.Size = new System.Drawing.Size(200, 22);
            this.txtPredictedYield.TabIndex = 7;
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(162, 389);
            this.txtFormula.Margin = new System.Windows.Forms.Padding(4);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.ReadOnly = true;
            this.txtFormula.Size = new System.Drawing.Size(260, 22);
            this.txtFormula.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "Section";
            // 
            // cmbSection
            // 
            this.cmbSection.BackColor = System.Drawing.Color.Transparent;
            this.cmbSection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbSection.BorderRadius = 10;
            this.cmbSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbSection.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSection.ForeColor = System.Drawing.Color.White;
            this.cmbSection.ItemHeight = 30;
            this.cmbSection.Location = new System.Drawing.Point(162, 29);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(200, 36);
            this.cmbSection.TabIndex = 35;
            // 
            // dtpPredictionDate
            // 
            this.dtpPredictionDate.BorderRadius = 10;
            this.dtpPredictionDate.Checked = true;
            this.dtpPredictionDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dtpPredictionDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpPredictionDate.ForeColor = System.Drawing.Color.White;
            this.dtpPredictionDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpPredictionDate.Location = new System.Drawing.Point(162, 78);
            this.dtpPredictionDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpPredictionDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpPredictionDate.Name = "dtpPredictionDate";
            this.dtpPredictionDate.Size = new System.Drawing.Size(200, 36);
            this.dtpPredictionDate.TabIndex = 36;
            this.dtpPredictionDate.Value = new System.DateTime(2026, 7, 7, 3, 8, 52, 189);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnGenerate.BorderRadius = 8;
            this.btnGenerate.BorderThickness = 2;
            this.btnGenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Image = global::TeaEstateSystem.Properties.Resources.hbjnk_removebg_preview1;
            this.btnGenerate.Location = new System.Drawing.Point(20, 17);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(104, 41);
            this.btnGenerate.TabIndex = 34;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = false;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 27);
            this.label2.TabIndex = 37;
            this.label2.Text = "Prediction date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = false;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 27);
            this.label3.TabIndex = 38;
            this.label3.Text = "Average Yield";
            // 
            // label8
            // 
            this.label8.AutoSize = false;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 27);
            this.label8.TabIndex = 39;
            this.label8.Text = "Formula";
            // 
            // label7
            // 
            this.label7.AutoSize = false;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 27);
            this.label7.TabIndex = 40;
            this.label7.Text = " Predicted Yield";
            // 
            // label6
            // 
            this.label6.AutoSize = false;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 27);
            this.label6.TabIndex = 41;
            this.label6.Text = " Season Factor";
            // 
            // label5
            // 
            this.label5.AutoSize = false;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "Plucking Factor";
            // 
            // label4
            // 
            this.label4.AutoSize = false;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 27);
            this.label4.TabIndex = 43;
            this.label4.Text = "Attendance";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.BorderThickness = 2;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = global::TeaEstateSystem.Properties.Resources.hbjnk_removebg_preview1;
            this.btnDelete.Location = new System.Drawing.Point(469, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 41);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnClear.BorderRadius = 8;
            this.btnClear.BorderThickness = 2;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = global::TeaEstateSystem.Properties.Resources.hbjnk_removebg_preview1;
            this.btnClear.Location = new System.Drawing.Point(357, 17);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 41);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(245, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 41);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnSave.BorderRadius = 8;
            this.btnSave.BorderThickness = 2;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::TeaEstateSystem.Properties.Resources.hbjnk_removebg_preview1;
            this.btnSave.Location = new System.Drawing.Point(133, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 41);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtAverageYield);
            this.guna2Panel1.Controls.Add(this.txtAttendance);
            this.guna2Panel1.Controls.Add(this.txtPluckingFactor);
            this.guna2Panel1.Controls.Add(this.txtSeasonFactor);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.txtPredictedYield);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.txtFormula);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.dtpPredictionDate);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.cmbSection);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(33, 31);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(442, 446);
            this.guna2Panel1.TabIndex = 48;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.btnGenerate);
            this.guna2Panel2.Controls.Add(this.btnDelete);
            this.guna2Panel2.Controls.Add(this.btnSave);
            this.guna2Panel2.Controls.Add(this.btnClear);
            this.guna2Panel2.Controls.Add(this.btnRefresh);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(33, 488);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(592, 76);
            this.guna2Panel2.TabIndex = 49;
            // 
            // dgvPrediction
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPrediction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrediction.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrediction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrediction.ColumnHeadersHeight = 4;
            this.dgvPrediction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrediction.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrediction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPrediction.Location = new System.Drawing.Point(481, 31);
            this.dgvPrediction.Name = "dgvPrediction";
            this.dgvPrediction.RowHeadersVisible = false;
            this.dgvPrediction.RowHeadersWidth = 51;
            this.dgvPrediction.RowTemplate.Height = 24;
            this.dgvPrediction.Size = new System.Drawing.Size(1035, 446);
            this.dgvPrediction.TabIndex = 50;
            this.dgvPrediction.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrediction.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvPrediction.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvPrediction.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrediction.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPrediction.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvPrediction.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrediction.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPrediction.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPrediction.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            // 
            // PredictionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeaEstateSystem.Properties.Resources.images__7_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1557, 576);
            this.Controls.Add(this.dgvPrediction);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PredictionForm";
            this.Text = "PredictionForm";
            this.Load += new System.EventHandler(this.PredictionForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrediction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtAverageYield;
        private System.Windows.Forms.TextBox txtAttendance;
        private System.Windows.Forms.TextBox txtPluckingFactor;
        private System.Windows.Forms.TextBox txtSeasonFactor;
        private System.Windows.Forms.TextBox txtPredictedYield;
        private System.Windows.Forms.TextBox txtFormula;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSection;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpPredictionDate;
        private Guna.UI2.WinForms.Guna2Button btnGenerate;
        private Guna.UI2.WinForms.Guna2HtmlLabel label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel label8;
        private Guna.UI2.WinForms.Guna2HtmlLabel label7;
        private Guna.UI2.WinForms.Guna2HtmlLabel label6;
        private Guna.UI2.WinForms.Guna2HtmlLabel label5;
        private Guna.UI2.WinForms.Guna2HtmlLabel label4;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPrediction;
    }
}