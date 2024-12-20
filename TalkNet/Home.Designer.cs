﻿namespace TalkNet
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chatsView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.homeBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.newChatbtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.newChatbtn);
            this.groupBox2.Controls.Add(this.chatsView);
            this.groupBox2.Location = new System.Drawing.Point(303, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(896, 612);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // chatsView
            // 
            this.chatsView.FullRowSelect = true;
            this.chatsView.GridLines = true;
            this.chatsView.HideSelection = false;
            this.chatsView.Location = new System.Drawing.Point(62, 43);
            this.chatsView.Name = "chatsView";
            this.chatsView.Columns.Add("Chats...", 500);
            this.chatsView.GridLines = true;
            this.chatsView.FullRowSelect = true;
            this.chatsView.Size = new System.Drawing.Size(756, 408);
            this.chatsView.TabIndex = 0;
            this.chatsView.UseCompatibleStateImageBehavior = false;
            this.chatsView.View = System.Windows.Forms.View.Details;
            this.chatsView.SelectedIndexChanged += new System.EventHandler(this.chatsView_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(3, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 612);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(83, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "TALKNET";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.homeBtn);
            this.groupBox3.Controls.Add(this.SettingBtn);
            this.groupBox3.Location = new System.Drawing.Point(0, 391);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(300, 222);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // homeBtn
            // 
            this.homeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.BackgroundImage")));
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.homeBtn.Location = new System.Drawing.Point(62, 29);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(189, 68);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "🏠︎     HOME";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SettingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SettingBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingBtn.Image")));
            this.SettingBtn.Location = new System.Drawing.Point(62, 117);
            this.SettingBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(189, 66);
            this.SettingBtn.TabIndex = 1;
            this.SettingBtn.Text = "🌣    SETTING";
            this.SettingBtn.UseVisualStyleBackColor = false;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // newChatbtn
            // 
            this.newChatbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newChatbtn.BackgroundImage")));
            this.newChatbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newChatbtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.newChatbtn.Location = new System.Drawing.Point(629, 472);
            this.newChatbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newChatbtn.Name = "newChatbtn";
            this.newChatbtn.Size = new System.Drawing.Size(189, 68);
            this.newChatbtn.TabIndex = 2;
            this.newChatbtn.Text = "Start New Chat";
            this.newChatbtn.UseVisualStyleBackColor = true;
            this.newChatbtn.Click += new System.EventHandler(this.newChatbtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.ListView chatsView;
        private System.Windows.Forms.Button newChatbtn;
    }
}