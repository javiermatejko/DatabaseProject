namespace PrimeraAplicacionConDB
{
    partial class LoginForm
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
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tboxNewUsername = new System.Windows.Forms.TextBox();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.tboxNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tboxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.lblAsterisc = new System.Windows.Forms.Label();
            this.lblAsterisc2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.Location = new System.Drawing.Point(63, 33);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(182, 31);
            this.lblUserLogin.TabIndex = 0;
            this.lblUserLogin.Text = "USER LOGIN";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(653, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 20);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // tboxUsername
            // 
            this.tboxUsername.Location = new System.Drawing.Point(75, 89);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(170, 20);
            this.tboxUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(13, 89);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(75, 121);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(170, 20);
            this.tboxPassword.TabIndex = 2;
            this.tboxPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 124);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(120, 186);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(478, 186);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tboxNewUsername
            // 
            this.tboxNewUsername.Location = new System.Drawing.Point(424, 76);
            this.tboxNewUsername.Name = "tboxNewUsername";
            this.tboxNewUsername.Size = new System.Drawing.Size(170, 20);
            this.tboxNewUsername.TabIndex = 4;
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Location = new System.Drawing.Point(315, 79);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(83, 13);
            this.lblNewUsername.TabIndex = 3;
            this.lblNewUsername.Text = "New Username:";
            // 
            // tboxNewPassword
            // 
            this.tboxNewPassword.Location = new System.Drawing.Point(424, 111);
            this.tboxNewPassword.Name = "tboxNewPassword";
            this.tboxNewPassword.Size = new System.Drawing.Size(170, 20);
            this.tboxNewPassword.TabIndex = 5;
            this.tboxNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(315, 114);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 13);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "New Password:";
            // 
            // tboxConfirmPassword
            // 
            this.tboxConfirmPassword.Location = new System.Drawing.Point(424, 137);
            this.tboxConfirmPassword.Name = "tboxConfirmPassword";
            this.tboxConfirmPassword.Size = new System.Drawing.Size(170, 20);
            this.tboxConfirmPassword.TabIndex = 6;
            this.tboxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Password Confirm:";
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.Location = new System.Drawing.Point(393, 33);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(160, 31);
            this.lblNewUser.TabIndex = 0;
            this.lblNewUser.Text = "NEW USER";
            // 
            // lblAsterisc
            // 
            this.lblAsterisc.AutoSize = true;
            this.lblAsterisc.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisc.Location = new System.Drawing.Point(601, 113);
            this.lblAsterisc.Name = "lblAsterisc";
            this.lblAsterisc.Size = new System.Drawing.Size(11, 13);
            this.lblAsterisc.TabIndex = 6;
            this.lblAsterisc.Text = "*";
            // 
            // lblAsterisc2
            // 
            this.lblAsterisc2.AutoSize = true;
            this.lblAsterisc2.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisc2.Location = new System.Drawing.Point(601, 137);
            this.lblAsterisc2.Name = "lblAsterisc2";
            this.lblAsterisc2.Size = new System.Drawing.Size(11, 13);
            this.lblAsterisc2.TabIndex = 6;
            this.lblAsterisc2.Text = "*";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 221);
            this.Controls.Add(this.lblAsterisc2);
            this.Controls.Add(this.lblAsterisc);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tboxConfirmPassword);
            this.Controls.Add(this.tboxNewPassword);
            this.Controls.Add(this.lblNewUsername);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxNewUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblNewUser);
            this.Controls.Add(this.lblUserLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tboxNewUsername;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.TextBox tboxNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tboxConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.Label lblAsterisc;
        private System.Windows.Forms.Label lblAsterisc2;
    }
}