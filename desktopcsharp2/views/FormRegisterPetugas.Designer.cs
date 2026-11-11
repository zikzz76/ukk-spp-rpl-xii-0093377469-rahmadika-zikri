namespace desktopcsharp2.views
{
    partial class FormRegisterPetugas
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtKonfirmasiPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNamaPetugas = new System.Windows.Forms.TextBox();
            this.cmdLevel = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(34, 43);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtKonfirmasiPassword
            // 
            this.txtKonfirmasiPassword.Location = new System.Drawing.Point(34, 133);
            this.txtKonfirmasiPassword.Name = "txtKonfirmasiPassword";
            this.txtKonfirmasiPassword.Size = new System.Drawing.Size(100, 20);
            this.txtKonfirmasiPassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(34, 102);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNamaPetugas
            // 
            this.txtNamaPetugas.Location = new System.Drawing.Point(34, 73);
            this.txtNamaPetugas.Name = "txtNamaPetugas";
            this.txtNamaPetugas.Size = new System.Drawing.Size(100, 20);
            this.txtNamaPetugas.TabIndex = 3;
            // 
            // cmdLevel
            // 
            this.cmdLevel.FormattingEnabled = true;
            this.cmdLevel.Location = new System.Drawing.Point(34, 159);
            this.cmdLevel.Name = "cmdLevel";
            this.cmdLevel.Size = new System.Drawing.Size(121, 21);
            this.cmdLevel.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(34, 186);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(115, 186);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 6;
            this.btnBatal.Text = "batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // FormRegisterPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cmdLevel);
            this.Controls.Add(this.txtNamaPetugas);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtKonfirmasiPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "FormRegisterPetugas";
            this.Text = "FormRegisterPetugas";
            this.Load += new System.EventHandler(this.FormRegisterPetugas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtKonfirmasiPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNamaPetugas;
        private System.Windows.Forms.ComboBox cmdLevel;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}