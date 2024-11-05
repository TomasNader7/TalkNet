namespace TalkNet
{
    partial class IndividualChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualChat));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.UserBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.UserBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.UserBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.messageTextBox);
            this.groupBox2.Location = new System.Drawing.Point(202, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 398);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(20, 328);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(441, 20);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLabel.Image = ((System.Drawing.Image)(resources.GetObject("userLabel.Image")));
            this.userLabel.Location = new System.Drawing.Point(32, 23);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(94, 25);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "USER 1";
            this.userLabel.Click += new System.EventHandler(this.userLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(2, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 398);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "TALKNET";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.SettingBtn);
            this.groupBox3.Controls.Add(this.homeBtn);
            this.groupBox3.Location = new System.Drawing.Point(0, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 228);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SettingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SettingBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingBtn.Image")));
            this.SettingBtn.Location = new System.Drawing.Point(40, 138);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(126, 43);
            this.SettingBtn.TabIndex = 1;
            this.SettingBtn.Text = "🌣    SETTING";
            this.SettingBtn.UseVisualStyleBackColor = false;
            // 
            // homeBtn
            // 
            this.homeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.BackgroundImage")));
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.homeBtn.Location = new System.Drawing.Point(40, 76);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(126, 44);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "🏠︎     HOME";
            this.homeBtn.UseVisualStyleBackColor = true;
            // 
            // UserBox
            // 
            this.UserBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserBox.BackgroundImage")));
            this.UserBox.Controls.Add(this.userLabel);
            this.UserBox.Location = new System.Drawing.Point(0, 11);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(591, 60);
            this.UserBox.TabIndex = 3;
            this.UserBox.TabStop = false;
            this.UserBox.Enter += new System.EventHandler(this.UserBox_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(522, 199);
            this.listBox1.TabIndex = 4;
            // 
            // IndividualChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IndividualChat";
            this.Text = "IndividualChat";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.UserBox.ResumeLayout(false);
            this.UserBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.GroupBox UserBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}