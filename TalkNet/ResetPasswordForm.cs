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
        string username = ForgotPasswordForm.to;

        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtResetPass.Text == txtResetPassVer.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=TOMIROG;Initial Catalog=forget_Password_db;Integrated Security=True;Trust Server Certificate=True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[forgotPassword] SET [password] = '"+txtResetPassVer.Text+"'  WHERE username = '"+username+"' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Reses successfully!");
            }
            else
            {
                MessageBox.Show("New password does not match. Enter same password.");
            }
        }
    }
}