using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkNet
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=TOMIROG;Initial Catalog=forget_Password_db;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public Login()
        {
            InitializeComponent();
        }
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*'; ;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        // Modified query to select only necessary columns
                        string selectData = "SELECT UserID, username FROM Users WHERE username = @username AND password = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());

                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read()) // Check if the reader has rows, meaning login was successful
                            {
                                // Set the logged-in user's ID and username in UserSession
                                UserSession.CurrentUserId = reader.GetInt32(0); // Id column
                                UserSession.CurrentUsername = reader.GetString(1); // username column

                                MessageBox.Show("Logged In Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Home home = new Home();
                                home.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        // Add event for "Forgot Password" Link
        private void linkForgotPassword_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
            this.Hide();
        }

        private void BoxTalkNet_Enter(object sender, EventArgs e)
        {

        }
    }
}
