namespace TeaEstateSystem
{
    partial class SectionsForm
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
            this.txtSectionName = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtBushCount = new System.Windows.Forms.TextBox();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpLastPlucking = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.cmbTeaType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpNextPlucking = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvSections = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSectionName
            // 
            this.txtSectionName.Location = new System.Drawing.Point(168, 63);
            this.txtSectionName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.Size = new System.Drawing.Size(189, 22);
            this.txtSectionName.TabIndex = 0;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(168, 110);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(189, 22);
            this.txtArea.TabIndex = 1;
            // 
            // txtBushCount
            // 
            this.txtBushCount.Location = new System.Drawing.Point(168, 157);
            this.txtBushCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtBushCount.Name = "txtBushCount";
            this.txtBushCount.Size = new System.Drawing.Size(189, 22);
            this.txtBushCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "Section Name";
            // 
            // dtpLastPlucking
            // 
            this.dtpLastPlucking.BorderRadius = 10;
            this.dtpLastPlucking.Checked = true;
            this.dtpLastPlucking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dtpLastPlucking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpLastPlucking.ForeColor = System.Drawing.Color.White;
            this.dtpLastPlucking.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpLastPlucking.Location = new System.Drawing.Point(167, 241);
            this.dtpLastPlucking.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpLastPlucking.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpLastPlucking.Name = "dtpLastPlucking";
            this.dtpLastPlucking.Size = new System.Drawing.Size(200, 36);
            this.dtpLastPlucking.TabIndex = 32;
            this.dtpLastPlucking.Value = new System.DateTime(2026, 7, 7, 3, 8, 52, 189);
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
            this.btnSave.Location = new System.Drawing.Point(16, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 41);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // cmbTeaType
            // 
            this.cmbTeaType.BackColor = System.Drawing.Color.Transparent;
            this.cmbTeaType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbTeaType.BorderRadius = 10;
            this.cmbTeaType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTeaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeaType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbTeaType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTeaType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTeaType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTeaType.ForeColor = System.Drawing.Color.White;
            this.cmbTeaType.ItemHeight = 30;
            this.cmbTeaType.Location = new System.Drawing.Point(166, 196);
            this.cmbTeaType.Name = "cmbTeaType";
            this.cmbTeaType.Size = new System.Drawing.Size(191, 36);
            this.cmbTeaType.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = false;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = false;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 27);
            this.label6.TabIndex = 34;
            this.label6.Text = "Next Plucking";
            // 
            // label5
            // 
            this.label5.AutoSize = false;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 27);
            this.label5.TabIndex = 35;
            this.label5.Text = "Last Plucking";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = false;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tea Type";
            // 
            // label3
            // 
            this.label3.AutoSize = false;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 37;
            this.label3.Text = "Bush Count";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 27);
            this.label2.TabIndex = 38;
            this.label2.Text = "Area";
            // 
            // dtpNextPlucking
            // 
            this.dtpNextPlucking.BorderRadius = 10;
            this.dtpNextPlucking.Checked = true;
            this.dtpNextPlucking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dtpNextPlucking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNextPlucking.ForeColor = System.Drawing.Color.White;
            this.dtpNextPlucking.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNextPlucking.Location = new System.Drawing.Point(167, 292);
            this.dtpNextPlucking.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNextPlucking.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNextPlucking.Name = "dtpNextPlucking";
            this.dtpNextPlucking.Size = new System.Drawing.Size(200, 36);
            this.dtpNextPlucking.TabIndex = 39;
            this.dtpNextPlucking.Value = new System.DateTime(2026, 7, 7, 3, 8, 52, 189);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.cmbStatus);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.dtpNextPlucking);
            this.guna2Panel1.Controls.Add(this.cmbTeaType);
            this.guna2Panel1.Controls.Add(this.txtSectionName);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txtArea);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.txtBushCount);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.dtpLastPlucking);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(23, 22);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(407, 446);
            this.guna2Panel1.TabIndex = 40;
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
            this.cmbStatus.Location = new System.Drawing.Point(167, 340);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(191, 36);
            this.cmbStatus.TabIndex = 40;
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
            this.btnDelete.Location = new System.Drawing.Point(348, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 41);
            this.btnDelete.TabIndex = 41;
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
            this.btnClear.Location = new System.Drawing.Point(237, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 41);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = global::TeaEstateSystem.Properties.Resources.hbjnk_removebg_preview1;
            this.btnUpdate.Location = new System.Drawing.Point(126, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 41);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.btnDelete);
            this.guna2Panel2.Controls.Add(this.btnUpdate);
            this.guna2Panel2.Controls.Add(this.btnSave);
            this.guna2Panel2.Controls.Add(this.btnClear);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(23, 483);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(468, 83);
            this.guna2Panel2.TabIndex = 41;
            // 
            // dgvSections
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSections.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSections.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSections.ColumnHeadersHeight = 4;
            this.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSections.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSections.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSections.Location = new System.Drawing.Point(447, 22);
            this.dgvSections.Name = "dgvSections";
            this.dgvSections.RowHeadersVisible = false;
            this.dgvSections.RowHeadersWidth = 51;
            this.dgvSections.RowTemplate.Height = 24;
            this.dgvSections.Size = new System.Drawing.Size(1111, 446);
            this.dgvSections.TabIndex = 42;
            this.dgvSections.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSections.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvSections.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvSections.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSections.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvSections.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvSections.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSections.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSections.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSections.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            // 
            // SectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeaEstateSystem.Properties.Resources.images__7_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 581);
            this.Controls.Add(this.dgvSections);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SectionsForm";
            this.Text = "SectionsForm";
            this.Load += new System.EventHandler(this.SectionsForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSectionName;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtBushCount;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpLastPlucking;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTeaType;
        private Guna.UI2.WinForms.Guna2HtmlLabel label7;
        private Guna.UI2.WinForms.Guna2HtmlLabel label6;
        private Guna.UI2.WinForms.Guna2HtmlLabel label5;
        private Guna.UI2.WinForms.Guna2HtmlLabel label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNextPlucking;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSections;
    }
}