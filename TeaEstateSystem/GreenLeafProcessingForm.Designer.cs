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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCollection = new System.Windows.Forms.ComboBox();
            this.dtpProcessingDate = new System.Windows.Forms.DateTimePicker();
            this.txtGreenLeafWeight = new System.Windows.Forms.TextBox();
            this.txtMadeTeaWeight = new System.Windows.Forms.TextBox();
            this.txtWasteWeight = new System.Windows.Forms.TextBox();
            this.txtMoistureLoss = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvProcessing = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Green Leaf Processing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tea Collection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Processing Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Green Leaf Weight (kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Made Tea Weight (kg)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Waste Weight (kg)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Moisture Loss (%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Remarks";
            // 
            // cmbCollection
            // 
            this.cmbCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollection.FormattingEnabled = true;
            this.cmbCollection.Location = new System.Drawing.Point(141, 50);
            this.cmbCollection.Name = "cmbCollection";
            this.cmbCollection.Size = new System.Drawing.Size(121, 21);
            this.cmbCollection.TabIndex = 8;
            // 
            // dtpProcessingDate
            // 
            this.dtpProcessingDate.Location = new System.Drawing.Point(141, 88);
            this.dtpProcessingDate.Name = "dtpProcessingDate";
            this.dtpProcessingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpProcessingDate.TabIndex = 9;
            // 
            // txtGreenLeafWeight
            // 
            this.txtGreenLeafWeight.Location = new System.Drawing.Point(162, 127);
            this.txtGreenLeafWeight.Name = "txtGreenLeafWeight";
            this.txtGreenLeafWeight.Size = new System.Drawing.Size(100, 20);
            this.txtGreenLeafWeight.TabIndex = 10;
            // 
            // txtMadeTeaWeight
            // 
            this.txtMadeTeaWeight.Location = new System.Drawing.Point(162, 170);
            this.txtMadeTeaWeight.Name = "txtMadeTeaWeight";
            this.txtMadeTeaWeight.Size = new System.Drawing.Size(100, 20);
            this.txtMadeTeaWeight.TabIndex = 11;
            this.txtMadeTeaWeight.TextChanged += new System.EventHandler(this.txtMadeTeaWeight_TextChanged);
            // 
            // txtWasteWeight
            // 
            this.txtWasteWeight.Location = new System.Drawing.Point(162, 207);
            this.txtWasteWeight.Name = "txtWasteWeight";
            this.txtWasteWeight.ReadOnly = true;
            this.txtWasteWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWasteWeight.TabIndex = 12;
            this.txtWasteWeight.TextChanged += new System.EventHandler(this.txtWasteWeight_TextChanged);
            // 
            // txtMoistureLoss
            // 
            this.txtMoistureLoss.Location = new System.Drawing.Point(162, 255);
            this.txtMoistureLoss.Name = "txtMoistureLoss";
            this.txtMoistureLoss.ReadOnly = true;
            this.txtMoistureLoss.Size = new System.Drawing.Size(100, 20);
            this.txtMoistureLoss.TabIndex = 13;
            this.txtMoistureLoss.TextChanged += new System.EventHandler(this.txtMoistureLoss_TextChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(162, 306);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(100, 20);
            this.txtRemarks.TabIndex = 14;
            this.txtRemarks.TextChanged += new System.EventHandler(this.txtRemarks_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(324, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(518, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(425, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvProcessing
            // 
            this.dgvProcessing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessing.Location = new System.Drawing.Point(461, 59);
            this.dgvProcessing.Name = "dgvProcessing";
            this.dgvProcessing.Size = new System.Drawing.Size(522, 287);
            this.dgvProcessing.TabIndex = 19;
            this.dgvProcessing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcessing_CellClick);
            // 
            // GreenLeafProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 442);
            this.Controls.Add(this.dgvProcessing);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtMoistureLoss);
            this.Controls.Add(this.txtWasteWeight);
            this.Controls.Add(this.txtMadeTeaWeight);
            this.Controls.Add(this.txtGreenLeafWeight);
            this.Controls.Add(this.dtpProcessingDate);
            this.Controls.Add(this.cmbCollection);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GreenLeafProcessingForm";
            this.Text = "GreenLeafProcessingForm";
            this.Load += new System.EventHandler(this.GreenLeafProcessingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCollection;
        private System.Windows.Forms.DateTimePicker dtpProcessingDate;
        private System.Windows.Forms.TextBox txtGreenLeafWeight;
        private System.Windows.Forms.TextBox txtMadeTeaWeight;
        private System.Windows.Forms.TextBox txtWasteWeight;
        private System.Windows.Forms.TextBox txtMoistureLoss;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvProcessing;
    }
}