using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TalkNet
{
    public partial class ResetPasswordForm : Form
    {
        string email = ForgotPasswordForm.to;

        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string password = textBox2.Text;
            if (txtResetPassVer.Text == password)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=TOMIROG;Initial Catalog=forget_Password_db;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                string q = "UPDATE [dbo].[Users] SET [password] = '" + password + "'  WHERE email = '" + email + "' ";
                SqlCommand cmd = new SqlCommand(q, connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Password Successfully Changed!");
            }
            else
            {
                MessageBox.Show("New password does not match. Enter same password.");
            }
        }
    }
}