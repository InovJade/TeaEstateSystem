namespace TeaEstateSystem
{
    partial class WorkersForm
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpJoined = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.dj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(295, 78);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(295, 146);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(100, 20);
            this.txtNIC.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(295, 215);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(295, 273);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // dtpJoined
            // 
            this.dtpJoined.Location = new System.Drawing.Point(524, 94);
            this.dtpJoined.Name = "dtpJoined";
            this.dtpJoined.Size = new System.Drawing.Size(200, 20);
            this.dtpJoined.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(506, 143);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.Size = new System.Drawing.Size(240, 150);
            this.dgvWorkers.TabIndex = 6;
            // 
            // dj
            // 
            this.dj.AutoSize = true;
            this.dj.Location = new System.Drawing.Point(573, 78);
            this.dj.Name = "dj";
            this.dj.Size = new System.Drawing.Size(92, 13);
            this.dj.TabIndex = 7;
            this.dj.Text = "Enter Date Joined";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FullName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NIC/ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adress";
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dj);
            this.Controls.Add(this.dgvWorkers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpJoined);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.txtFullName);
            this.Name = "WorkersForm";
            this.Text = "WorkersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpJoined;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.Label dj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}