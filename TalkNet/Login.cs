using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using TalkNet;

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

                // Updated SQL query to retrieve UserId along with username and password
                String selectData = "SELECT UserId FROM Users WHERE username = @username AND password = @pass";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                    // Execute the command and read the UserId
                    var result = cmd.ExecuteScalar();
                    if (result != null) // If a UserId is returned
                    {
                        int userId = Convert.ToInt32(result);
                        MessageBox.Show("Logged In Successfully ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Pass the UserId to the Home form
                        Home home = new Home(userId);
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username/Password ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
