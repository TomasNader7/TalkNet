using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkNet
{
    public partial class VerificationForm : Form
    {
        public VerificationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the entered code matches the generated code
            if(ForgotPasswordForm.randomCode == (txtVerCode.Text).ToString())
            {
                string userEmail = ForgotPasswordForm.EmailAddress;
                ResetPasswordForm rp = new ResetPasswordForm();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Code");
            }

        }
    }
}
