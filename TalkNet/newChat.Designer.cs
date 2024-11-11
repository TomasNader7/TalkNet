namespace TalkNet
{
    partial class newChat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newChat));
            this.usersListView = new System.Windows.Forms.ListView();
            this.btnStartChat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usersListView
            // 
            this.usersListView.HideSelection = false;
            this.usersListView.Location = new System.Drawing.Point(14, 62);
            this.usersListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(404, 374);
            this.usersListView.TabIndex = 0;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.View = System.Windows.Forms.View.List;
            // 
            // btnStartChat
            // 
            this.btnStartChat.Location = new System.Drawing.Point(165, 462);
            this.btnStartChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartChat.Name = "btnStartChat";
            this.btnStartChat.Size = new System.Drawing.Size(112, 38);
            this.btnStartChat.TabIndex = 1;
            this.btnStartChat.Text = "Start Chat";
            this.btnStartChat.UseVisualStyleBackColor = true;
            this.btnStartChat.Click += new System.EventHandler(this.btnStartChat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a User to Chat";
            // 
            // newChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(432, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartChat);
            this.Controls.Add(this.usersListView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "newChat";
            this.Text = "Start New Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView usersListView;
        private System.Windows.Forms.Button btnStartChat;
        private System.Windows.Forms.Label label1;
    }
}
