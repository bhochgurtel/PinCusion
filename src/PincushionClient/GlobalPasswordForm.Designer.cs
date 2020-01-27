namespace PinCushionClient
{
    partial class GlobalPasswordForm
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblGlobalPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(273, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // lblGlobalPassword
            // 
            this.lblGlobalPassword.AutoSize = true;
            this.lblGlobalPassword.Location = new System.Drawing.Point(13, 38);
            this.lblGlobalPassword.Name = "lblGlobalPassword";
            this.lblGlobalPassword.Size = new System.Drawing.Size(155, 13);
            this.lblGlobalPassword.TabIndex = 1;
            this.lblGlobalPassword.Text = "Please Enter  Global Password:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(210, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "The global password is used to encrypt passwords in the \r\nconnectoin file. You wi" +
    "ll need to enter this each time you\r\nuse the software.\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GlobalPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblGlobalPassword);
            this.Controls.Add(this.txtPassword);
            this.Name = "GlobalPasswordForm";
            this.Text = "Globa Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblGlobalPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}