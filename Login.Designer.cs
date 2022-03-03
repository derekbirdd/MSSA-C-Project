namespace Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomerLogin = new System.Windows.Forms.Button();
            this.btnEmployeeLogin = new System.Windows.Forms.Button();
            this.grpBoxLogin = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Pine Whiskey Productions! ";
            // 
            // btnCustomerLogin
            // 
            this.btnCustomerLogin.Location = new System.Drawing.Point(98, 176);
            this.btnCustomerLogin.Name = "btnCustomerLogin";
            this.btnCustomerLogin.Size = new System.Drawing.Size(156, 46);
            this.btnCustomerLogin.TabIndex = 2;
            this.btnCustomerLogin.Text = "Customer Login";
            this.btnCustomerLogin.UseVisualStyleBackColor = true;
            this.btnCustomerLogin.Click += new System.EventHandler(this.btnCustomerLogin_Click);
            // 
            // btnEmployeeLogin
            // 
            this.btnEmployeeLogin.Location = new System.Drawing.Point(299, 176);
            this.btnEmployeeLogin.Name = "btnEmployeeLogin";
            this.btnEmployeeLogin.Size = new System.Drawing.Size(156, 46);
            this.btnEmployeeLogin.TabIndex = 3;
            this.btnEmployeeLogin.Text = "Employee Login";
            this.btnEmployeeLogin.UseVisualStyleBackColor = true;
            this.btnEmployeeLogin.Click += new System.EventHandler(this.btnEmployeeLogin_Click);
            // 
            // grpBoxLogin
            // 
            this.grpBoxLogin.BackColor = System.Drawing.Color.Silver;
            this.grpBoxLogin.Controls.Add(this.txtPassword);
            this.grpBoxLogin.Controls.Add(this.txtUsername);
            this.grpBoxLogin.Controls.Add(this.lblPassword);
            this.grpBoxLogin.Controls.Add(this.lblUsername);
            this.grpBoxLogin.Controls.Add(this.btnEmployeeLogin);
            this.grpBoxLogin.Controls.Add(this.btnCustomerLogin);
            this.grpBoxLogin.Location = new System.Drawing.Point(120, 196);
            this.grpBoxLogin.Name = "grpBoxLogin";
            this.grpBoxLogin.Size = new System.Drawing.Size(518, 271);
            this.grpBoxLogin.TabIndex = 4;
            this.grpBoxLogin.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(199, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(201, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(199, 62);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(201, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(51, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(104, 25);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(51, 56);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(108, 25);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 646);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(779, 641);
            this.Controls.Add(this.grpBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.grpBoxLogin.ResumeLayout(false);
            this.grpBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustomerLogin;
        private System.Windows.Forms.Button btnEmployeeLogin;
        private System.Windows.Forms.GroupBox grpBoxLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}