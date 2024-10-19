using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TalkNet
{
    public partial class ForgotPasswordForm : Form
    {
        public static string randomCode;
        public static string to;
        public static string EmailAddress { get; private set; }

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }

        // When the user clicks Submit on ForgotPasswordForm, send the generated verification code to their email or phone number
        private void button1_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            EmailAddress = to;
            from = "ameliawarden96@gmail.com";
            pass = "xtds hiut bgxa unbv";
            messageBody = "Your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code sent successfully!");
                VerificationForm verificationForm = new VerificationForm();
                verificationForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
