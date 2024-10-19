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
    partial class BackToLogin : Form
    {
        public BackToLogin()
        {
            InitializeComponent();
            // Subscribe to the button click event
            button1.Click += new EventHandler(button1_Click);
        }

        // Event handler for the Back to Login button
        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the login form
            Login loginForm = new Login();
            // Show the login form
            loginForm.Show();
            // Close the current form
            this.Close(); // Or you can use this.Hide(); if you want to keep it in memory
        }
    }
}
