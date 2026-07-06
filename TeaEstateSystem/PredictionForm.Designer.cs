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
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPredictionDate = new System.Windows.Forms.DateTimePicker();
            this.txtAverageYield = new System.Windows.Forms.TextBox();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.txtPluckingFactor = new System.Windows.Forms.TextBox();
            this.txtSeasonFactor = new System.Windows.Forms.TextBox();
            this.txtPredictedYield = new System.Windows.Forms.TextBox();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvPrediction = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrediction)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(141, 46);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(121, 21);
            this.cmbSection.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Section";
            // 
            // dtpPredictionDate
            // 
            this.dtpPredictionDate.Location = new System.Drawing.Point(141, 96);
            this.dtpPredictionDate.Name = "dtpPredictionDate";
            this.dtpPredictionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPredictionDate.TabIndex = 2;
            // 
            // txtAverageYield
            // 
            this.txtAverageYield.Location = new System.Drawing.Point(157, 154);
            this.txtAverageYield.Name = "txtAverageYield";
            this.txtAverageYield.ReadOnly = true;
            this.txtAverageYield.Size = new System.Drawing.Size(100, 20);
            this.txtAverageYield.TabIndex = 3;
            // 
            // txtAttendance
            // 
            this.txtAttendance.Location = new System.Drawing.Point(157, 189);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.ReadOnly = true;
            this.txtAttendance.Size = new System.Drawing.Size(100, 20);
            this.txtAttendance.TabIndex = 4;
            // 
            // txtPluckingFactor
            // 
            this.txtPluckingFactor.Location = new System.Drawing.Point(157, 229);
            this.txtPluckingFactor.Name = "txtPluckingFactor";
            this.txtPluckingFactor.ReadOnly = true;
            this.txtPluckingFactor.Size = new System.Drawing.Size(100, 20);
            this.txtPluckingFactor.TabIndex = 5;
            // 
            // txtSeasonFactor
            // 
            this.txtSeasonFactor.Location = new System.Drawing.Point(157, 269);
            this.txtSeasonFactor.Name = "txtSeasonFactor";
            this.txtSeasonFactor.ReadOnly = true;
            this.txtSeasonFactor.Size = new System.Drawing.Size(100, 20);
            this.txtSeasonFactor.TabIndex = 6;
            // 
            // txtPredictedYield
            // 
            this.txtPredictedYield.Location = new System.Drawing.Point(157, 305);
            this.txtPredictedYield.Name = "txtPredictedYield";
            this.txtPredictedYield.ReadOnly = true;
            this.txtPredictedYield.Size = new System.Drawing.Size(100, 20);
            this.txtPredictedYield.TabIndex = 7;
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(157, 343);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.ReadOnly = true;
            this.txtFormula.Size = new System.Drawing.Size(196, 20);
            this.txtFormula.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prediction date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Average Yield";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Attendance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Plucking Factor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = " Season Factor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = " Predicted Yield";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Formula";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(103, 419);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(199, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(484, 419);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(390, 419);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(295, 419);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvPrediction
            // 
            this.dgvPrediction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrediction.Location = new System.Drawing.Point(380, 102);
            this.dgvPrediction.Name = "dgvPrediction";
            this.dgvPrediction.Size = new System.Drawing.Size(776, 295);
            this.dgvPrediction.TabIndex = 21;
            this.dgvPrediction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrediction_CellClick);
            // 
            // PredictionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 468);
            this.Controls.Add(this.dgvPrediction);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.txtPredictedYield);
            this.Controls.Add(this.txtSeasonFactor);
            this.Controls.Add(this.txtPluckingFactor);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.txtAverageYield);
            this.Controls.Add(this.dtpPredictionDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSection);
            this.Name = "PredictionForm";
            this.Text = "PredictionForm";
            this.Load += new System.EventHandler(this.PredictionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrediction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPredictionDate;
        private System.Windows.Forms.TextBox txtAverageYield;
        private System.Windows.Forms.TextBox txtAttendance;
        private System.Windows.Forms.TextBox txtPluckingFactor;
        private System.Windows.Forms.TextBox txtSeasonFactor;
        private System.Windows.Forms.TextBox txtPredictedYield;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvPrediction;
    }
}