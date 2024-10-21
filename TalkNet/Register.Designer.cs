namespace TalkNet
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.BoxTalkNet = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signup_login = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_conpass = new System.Windows.Forms.TextBox();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.signup_email = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.signup_showpass = new System.Windows.Forms.CheckBox();
            this.signup_showpass1 = new System.Windows.Forms.CheckBox();
            this.BoxTalkNet.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxTalkNet
            // 
            this.BoxTalkNet.BackColor = System.Drawing.Color.Indigo;
            this.BoxTalkNet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoxTalkNet.BackgroundImage")));
            this.BoxTalkNet.Controls.Add(this.signup_showpass1);
            this.BoxTalkNet.Controls.Add(this.signup_showpass);
            this.BoxTalkNet.Controls.Add(this.label7);
            this.BoxTalkNet.Controls.Add(this.label6);
            this.BoxTalkNet.Controls.Add(this.label5);
            this.BoxTalkNet.Controls.Add(this.signup_login);
            this.BoxTalkNet.Controls.Add(this.label4);
            this.BoxTalkNet.Controls.Add(this.label2);
            this.BoxTalkNet.Controls.Add(this.btnRegister);
            this.BoxTalkNet.Controls.Add(this.label3);
            this.BoxTalkNet.Controls.Add(this.signup_conpass);
            this.BoxTalkNet.Controls.Add(this.signup_username);
            this.BoxTalkNet.Controls.Add(this.signup_password);
            this.BoxTalkNet.Controls.Add(this.signup_email);
            this.BoxTalkNet.Controls.Add(this.labelPassword);
            this.BoxTalkNet.Controls.Add(this.labelUsername);
            this.BoxTalkNet.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxTalkNet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BoxTalkNet.Location = new System.Drawing.Point(12, 12);
            this.BoxTalkNet.Name = "BoxTalkNet";
            this.BoxTalkNet.Size = new System.Drawing.Size(714, 340);
            this.BoxTalkNet.TabIndex = 1;
            this.BoxTalkNet.TabStop = false;
            this.BoxTalkNet.Text = "Register";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(309, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 68);
            this.label7.TabIndex = 18;
            this.label7.Text = "- Instant messaging\r\n- Group chats\r\n- Real-time updates\r\n- Secure communication";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(307, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Register now to enjoy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Indigo;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(304, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 47);
            this.label5.TabIndex = 16;
            this.label5.Text = "Welcome To TalkNet";
            // 
            // signup_login
            // 
            this.signup_login.AutoSize = true;
            this.signup_login.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_login.Image = ((System.Drawing.Image)(resources.GetObject("signup_login.Image")));
            this.signup_login.LinkColor = System.Drawing.Color.Green;
            this.signup_login.Location = new System.Drawing.Point(136, 266);
            this.signup_login.Name = "signup_login";
            this.signup_login.Size = new System.Drawing.Size(37, 13);
            this.signup_login.TabIndex = 15;
            this.signup_login.TabStop = true;
            this.signup_login.Text = "Login";
            this.signup_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLabel_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(27, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Already have an account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(27, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Confirm Password:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Navy;
            this.btnRegister.Location = new System.Drawing.Point(29, 233);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(101, 31);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(27, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username:";
            // 
            // signup_conpass
            // 
            this.signup_conpass.Location = new System.Drawing.Point(30, 176);
            this.signup_conpass.Name = "signup_conpass";
            this.signup_conpass.PasswordChar = '*';
            this.signup_conpass.Size = new System.Drawing.Size(236, 22);
            this.signup_conpass.TabIndex = 9;
            // 
            // signup_username
            // 
            this.signup_username.Location = new System.Drawing.Point(30, 78);
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(236, 22);
            this.signup_username.TabIndex = 8;
            // 
            // signup_password
            // 
            this.signup_password.Location = new System.Drawing.Point(30, 125);
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(236, 22);
            this.signup_password.TabIndex = 3;
            // 
            // signup_email
            // 
            this.signup_email.Location = new System.Drawing.Point(30, 32);
            this.signup_email.Name = "signup_email";
            this.signup_email.Size = new System.Drawing.Size(236, 22);
            this.signup_email.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Image = ((System.Drawing.Image)(resources.GetObject("labelPassword.Image")));
            this.labelPassword.Location = new System.Drawing.Point(27, 109);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(59, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelUsername.Image = ((System.Drawing.Image)(resources.GetObject("labelUsername.Image")));
            this.labelUsername.Location = new System.Drawing.Point(27, 16);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(81, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Email Address:";
            // 
            // signup_showpass
            // 
            this.signup_showpass.AutoSize = true;
            this.signup_showpass.BackColor = System.Drawing.Color.Transparent;
            this.signup_showpass.Location = new System.Drawing.Point(159, 204);
            this.signup_showpass.Name = "signup_showpass";
            this.signup_showpass.Size = new System.Drawing.Size(107, 17);
            this.signup_showpass.TabIndex = 19;
            this.signup_showpass.Text = "Show Password";
            this.signup_showpass.UseVisualStyleBackColor = false;
            this.signup_showpass.CheckedChanged += new System.EventHandler(this.signup_showpass_CheckedChanged);
            // 
            // signup_showpass1
            // 
            this.signup_showpass1.AutoSize = true;
            this.signup_showpass1.BackColor = System.Drawing.Color.Transparent;
            this.signup_showpass1.Location = new System.Drawing.Point(159, 153);
            this.signup_showpass1.Name = "signup_showpass1";
            this.signup_showpass1.Size = new System.Drawing.Size(107, 17);
            this.signup_showpass1.TabIndex = 20;
            this.signup_showpass1.Text = "Show Password";
            this.signup_showpass1.UseVisualStyleBackColor = false;
            this.signup_showpass1.CheckedChanged += new System.EventHandler(this.signup_showpass1_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(731, 360);
            this.Controls.Add(this.BoxTalkNet);
            this.Name = "Register";
            this.Text = "Register";
            this.BoxTalkNet.ResumeLayout(false);
            this.BoxTalkNet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxTalkNet;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.TextBox signup_conpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel signup_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox signup_showpass;
        private System.Windows.Forms.CheckBox signup_showpass1;
    }
}