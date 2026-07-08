namespace TeaEstateSystem
{
    partial class GreenLeafProcessingForm
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
            this.txtGreenLeafWeight = new System.Windows.Forms.TextBox();
            this.txtMadeTeaWeight = new System.Windows.Forms.TextBox();
            this.txtWasteWeight = new System.Windows.Forms.TextBox();
            this.txtMoistureLoss = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.dgvProcessing = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbCollection = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpProcessingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGreenLeafWeight
            // 
            this.txtGreenLeafWeight.Location = new System.Drawing.Point(260, 188);
            this.txtGreenLeafWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtGreenLeafWeight.Name = "txtGreenLeafWeight";
            this.txtGreenLeafWeight.Size = new System.Drawing.Size(200, 22);
            this.txtGreenLeafWeight.TabIndex = 10;
            // 
            // txtMadeTeaWeight
            // 
            this.txtMadeTeaWeight.Location = new System.Drawing.Point(260, 234);
            this.txtMadeTeaWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtMadeTeaWeight.Name = "txtMadeTeaWeight";
            this.txtMadeTeaWeight.Size = new System.Drawing.Size(200, 22);
            this.txtMadeTeaWeight.TabIndex = 11;
            this.txtMadeTeaWeight.TextChanged += new System.EventHandler(this.txtMadeTeaWeight_TextChanged);
            // 
            // txtWasteWeight
            // 
            this.txtWasteWeight.Location = new System.Drawing.Point(260, 279);
            this.txtWasteWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWasteWeight.Name = "txtWasteWeight";
            this.txtWasteWeight.ReadOnly = true;
            this.txtWasteWeight.Size = new System.Drawing.Size(200, 22);
            this.txtWasteWeight.TabIndex = 12;
            this.txtWasteWeight.TextChanged += new System.EventHandler(this.txtWasteWeight_TextChanged);
            // 
            // txtMoistureLoss
            // 
            this.txtMoistureLoss.Location = new System.Drawing.Point(260, 324);
            this.txtMoistureLoss.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoistureLoss.Name = "txtMoistureLoss";
            this.txtMoistureLoss.ReadOnly = true;
            this.txtMoistureLoss.Size = new System.Drawing.Size(200, 22);
            this.txtMoistureLoss.TabIndex = 13;
            this.txtMoistureLoss.TextChanged += new System.EventHandler(this.txtMoistureLoss_TextChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(260, 369);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(200, 22);
            this.txtRemarks.TabIndex = 14;
            this.txtRemarks.TextChanged += new System.EventHandler(this.txtRemarks_TextChanged);
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
            this.guna2Panel2.Location = new System.Drawing.Point(356, 429);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(608, 83);
            this.guna2Panel2.TabIndex = 42;
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
            this.btnDelete.Location = new System.Drawing.Point(441, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 41);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(189, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 41);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnSave.Location = new System.Drawing.Point(63, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 41);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClear.Location = new System.Drawing.Point(315, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 41);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvProcessing
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProcessing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcessing.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcessing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProcessing.ColumnHeadersHeight = 4;
            this.dgvProcessing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcessing.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProcessing.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProcessing.Location = new System.Drawing.Point(544, 90);
            this.dgvProcessing.Name = "dgvProcessing";
            this.dgvProcessing.RowHeadersVisible = false;
            this.dgvProcessing.RowHeadersWidth = 51;
            this.dgvProcessing.RowTemplate.Height = 24;
            this.dgvProcessing.Size = new System.Drawing.Size(696, 305);
            this.dgvProcessing.TabIndex = 43;
            this.dgvProcessing.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProcessing.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvProcessing.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvProcessing.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProcessing.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvProcessing.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvProcessing.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProcessing.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProcessing.ThemeStyle.RowsStyle.Height = 24;
            this.dgvProcessing.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            // 
            // cmbCollection
            // 
            this.cmbCollection.BackColor = System.Drawing.Color.Transparent;
            this.cmbCollection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbCollection.BorderRadius = 10;
            this.cmbCollection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbCollection.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCollection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCollection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCollection.ForeColor = System.Drawing.Color.White;
            this.cmbCollection.ItemHeight = 30;
            this.cmbCollection.Location = new System.Drawing.Point(260, 90);
            this.cmbCollection.Name = "cmbCollection";
            this.cmbCollection.Size = new System.Drawing.Size(191, 36);
            this.cmbCollection.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(166, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 27);
            this.label1.TabIndex = 44;
            this.label1.Text = "Green Leaf Processing";
            // 
            // dtpProcessingDate
            // 
            this.dtpProcessingDate.BorderRadius = 10;
            this.dtpProcessingDate.Checked = true;
            this.dtpProcessingDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dtpProcessingDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpProcessingDate.ForeColor = System.Drawing.Color.White;
            this.dtpProcessingDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpProcessingDate.Location = new System.Drawing.Point(260, 136);
            this.dtpProcessingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpProcessingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpProcessingDate.Name = "dtpProcessingDate";
            this.dtpProcessingDate.Size = new System.Drawing.Size(200, 36);
            this.dtpProcessingDate.TabIndex = 45;
            this.dtpProcessingDate.Value = new System.DateTime(2026, 7, 7, 3, 8, 52, 189);
            // 
            // label8
            // 
            this.label8.AutoSize = false;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(54, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 27);
            this.label8.TabIndex = 47;
            this.label8.Text = "Remarks";
            // 
            // label7
            // 
            this.label7.AutoSize = false;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(54, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 27);
            this.label7.TabIndex = 48;
            this.label7.Text = "Moisture Loss (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = false;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(54, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 27);
            this.label6.TabIndex = 49;
            this.label6.Text = "Waste Weight (kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = false;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 27);
            this.label5.TabIndex = 50;
            this.label5.Text = "Made Tea Weight (kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = false;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 27);
            this.label4.TabIndex = 51;
            this.label4.Text = "Green Leaf Weight (kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = false;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 27);
            this.label3.TabIndex = 52;
            this.label3.Text = "Processing Date";
            // 
            // label2
            // 
            this.label2.AutoSize = false;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 27);
            this.label2.TabIndex = 53;
            this.label2.Text = "Tea Collection";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GreenLeafProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeaEstateSystem.Properties.Resources.images__7_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1383, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCollection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpProcessingDate);
            this.Controls.Add(this.dgvProcessing);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtMoistureLoss);
            this.Controls.Add(this.txtWasteWeight);
            this.Controls.Add(this.txtMadeTeaWeight);
            this.Controls.Add(this.txtGreenLeafWeight);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GreenLeafProcessingForm";
            this.Text = "GreenLeafProcessingForm";
            this.Load += new System.EventHandler(this.GreenLeafProcessingForm_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGreenLeafWeight;
        private System.Windows.Forms.TextBox txtMadeTeaWeight;
        private System.Windows.Forms.TextBox txtWasteWeight;
        private System.Windows.Forms.TextBox txtMoistureLoss;
        private System.Windows.Forms.TextBox txtRemarks;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProcessing;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCollection;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpProcessingDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel label8;
        private Guna.UI2.WinForms.Guna2HtmlLabel label7;
        private Guna.UI2.WinForms.Guna2HtmlLabel label6;
        private Guna.UI2.WinForms.Guna2HtmlLabel label5;
        private Guna.UI2.WinForms.Guna2HtmlLabel label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel label2;
    }
}