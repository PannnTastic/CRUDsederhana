namespace CRUDsederhana
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nim = new System.Windows.Forms.Label();
            this.dgvmahasiswa = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.Label();
            this.tlp = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmahasiswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nim
            // 
            this.nim.AutoSize = true;
            this.nim.Location = new System.Drawing.Point(87, 62);
            this.nim.Name = "nim";
            this.nim.Size = new System.Drawing.Size(31, 16);
            this.nim.TabIndex = 0;
            this.nim.Text = "NIM";
            // 
            // dgvmahasiswa
            // 
            this.dgvmahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmahasiswa.Location = new System.Drawing.Point(90, 297);
            this.dgvmahasiswa.Name = "dgvmahasiswa";
            this.dgvmahasiswa.RowHeadersWidth = 51;
            this.dgvmahasiswa.RowTemplate.Height = 24;
            this.dgvmahasiswa.Size = new System.Drawing.Size(554, 150);
            this.dgvmahasiswa.TabIndex = 14;
            this.dgvmahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmahasiswa_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(514, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(370, 252);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(219, 252);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(145, 23);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Refresh";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.BtnRead);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(90, 252);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(191, 87);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(173, 22);
            this.txtNama.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(191, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(191, 148);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(173, 22);
            this.txtTelepon.TabIndex = 7;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(191, 176);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(173, 57);
            this.txtAlamat.TabIndex = 6;
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(191, 55);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(173, 22);
            this.txtNIM.TabIndex = 5;
            // 
            // alamat
            // 
            this.alamat.AutoSize = true;
            this.alamat.Location = new System.Drawing.Point(87, 176);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(49, 16);
            this.alamat.TabIndex = 4;
            this.alamat.Text = "Alamat";
            // 
            // tlp
            // 
            this.tlp.AutoSize = true;
            this.tlp.Location = new System.Drawing.Point(87, 148);
            this.tlp.Name = "tlp";
            this.tlp.Size = new System.Drawing.Size(58, 16);
            this.tlp.TabIndex = 3;
            this.tlp.Text = "Telepon";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(87, 90);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(44, 16);
            this.nama.TabIndex = 2;
            this.nama.Text = "Nama";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(87, 118);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 16);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(502, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvmahasiswa);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.tlp);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nim);
            this.Name = "Form1";
            this.Text = "CRUD Sederhana";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmahasiswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nim;
        private System.Windows.Forms.DataGridView dgvmahasiswa;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.Label alamat;
        private System.Windows.Forms.Label tlp;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

