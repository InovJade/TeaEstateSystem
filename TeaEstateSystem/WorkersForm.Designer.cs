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
            this.txtFullName1 = new System.Windows.Forms.Label();
            this.txtNIC1 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.Label();
            this.dtpJoined = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(219, 32);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 0;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(219, 58);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(100, 20);
            this.txtNIC.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(219, 84);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(219, 110);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtFullName1
            // 
            this.txtFullName1.AutoSize = true;
            this.txtFullName1.Location = new System.Drawing.Point(143, 39);
            this.txtFullName1.Name = "txtFullName1";
            this.txtFullName1.Size = new System.Drawing.Size(54, 13);
            this.txtFullName1.TabIndex = 4;
            this.txtFullName1.Text = "Full Name";
            // 
            // txtNIC1
            // 
            this.txtNIC1.AutoSize = true;
            this.txtNIC1.Location = new System.Drawing.Point(143, 65);
            this.txtNIC1.Name = "txtNIC1";
            this.txtNIC1.Size = new System.Drawing.Size(25, 13);
            this.txtNIC1.TabIndex = 5;
            this.txtNIC1.Text = "NIC";
            // 
            // txtPhone1
            // 
            this.txtPhone1.AutoSize = true;
            this.txtPhone1.Location = new System.Drawing.Point(143, 91);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(38, 13);
            this.txtPhone1.TabIndex = 6;
            this.txtPhone1.Text = "Phone";
            // 
            // txtAddress1
            // 
            this.txtAddress1.AutoSize = true;
            this.txtAddress1.Location = new System.Drawing.Point(143, 117);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(45, 13);
            this.txtAddress1.TabIndex = 7;
            this.txtAddress1.Text = "Address";
            // 
            // dtpJoined
            // 
            this.dtpJoined.Location = new System.Drawing.Point(466, 59);
            this.dtpJoined.Name = "dtpJoined";
            this.dtpJoined.Size = new System.Drawing.Size(200, 20);
            this.dtpJoined.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(370, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(146, 202);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.Size = new System.Drawing.Size(529, 181);
            this.dgvWorkers.TabIndex = 10;
            this.dgvWorkers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkers_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(476, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(476, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvWorkers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpJoined);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.txtNIC1);
            this.Controls.Add(this.txtFullName1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.txtFullName);
            this.Name = "WorkersForm";
            this.Text = "WorkersForm";
            this.Load += new System.EventHandler(this.WorkersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label txtFullName1;
        private System.Windows.Forms.Label txtNIC1;
        private System.Windows.Forms.Label txtPhone1;
        private System.Windows.Forms.Label txtAddress1;
        private System.Windows.Forms.DateTimePicker dtpJoined;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}