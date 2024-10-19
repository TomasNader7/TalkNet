using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkNet
{
    public partial class Register : Form
    {
        // Mock user data store
        private static Dictionary<string, string> users = new Dictionary<string, string>();

        public Register()
        {
            InitializeComponent();
            this.FormClosing += RegisterForm_FormClosing;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConPassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (users.ContainsKey(username))
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            // Save user details to mock data store
            users.Add(username, password);
            MessageBox.Show("User registered successfully");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
