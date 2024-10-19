namespace TalkNet
{
    partial class ResetPasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtResetPassVer = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResetPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset account password";
            // 
            // txtResetPassVer
            // 
            this.txtResetPassVer.Location = new System.Drawing.Point(233, 136);
            this.txtResetPassVer.Name = "txtResetPassVer";
            this.txtResetPassVer.Size = new System.Drawing.Size(217, 20);
            this.txtResetPassVer.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter new password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm new password";
            // 
            // txtResetPass
            // 
            this.txtResetPass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtResetPass.Location = new System.Drawing.Point(332, 289);
            this.txtResetPass.Name = "txtResetPass";
            this.txtResetPass.Size = new System.Drawing.Size(118, 35);
            this.txtResetPass.TabIndex = 6;
            this.txtResetPass.Text = "Reset Password";
            this.txtResetPass.UseVisualStyleBackColor = false;
            this.txtResetPass.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResetPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtResetPassVer);
            this.Controls.Add(this.label1);
            this.Name = "ResetPasswordForm";
            this.Text = "ResetPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResetPassVer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtResetPass;
    }
}