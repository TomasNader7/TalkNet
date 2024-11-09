using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TalkNet
{
    public partial class Setting : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=TOMIROG;Initial Catalog=forget_Password_db;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public Setting()
        {
            InitializeComponent();
        }


        private void savebtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usertxt.Text) ||
                string.IsNullOrWhiteSpace(emailtxt.Text) ||
                string.IsNullOrWhiteSpace(passtxt.Text) ||
                string.IsNullOrWhiteSpace(conpsstxt.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passtxt.Text != conpsstxt.Text)
            {
                MessageBox.Show("Passwords do not match. Please re-enter the password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();

                string updateQuery = "UPDATE Users SET username = @username, email = @Email, password = @password WHERE username = @currentUsername";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                {
                    string currentUsername = UserSession.CurrentUsername;

                    cmd.Parameters.AddWithValue("@username", usertxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", emailtxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", passtxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@currentUsername", currentUsername);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please check the current username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this account and all associated data?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

    if (result == DialogResult.Yes)
    {
        try
        {
            connect.Open();

            // SQL command to delete the user from the Users table
            string deleteRecord = "DELETE FROM Users WHERE username = @username";

            using (SqlCommand cmd = new SqlCommand(deleteRecord, connect))
            {
                // Use the current username for deletion
                string currentUsername = UserSession.CurrentUsername;
                cmd.Parameters.AddWithValue("@username", currentUsername);

                // Execute the deletion query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Optionally, log the user out after successful deletion
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Deletion failed. The account may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            // Close the connection
            connect.Close();
        }
    }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void navHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pfp_Click(object sender, EventArgs e)
        {
            // Open a file dialog for the user to select a new image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the PictureBox
                    string imagePath = openFileDialog.FileName;
                    circularPictureBox1.Image = Image.FromFile(imagePath);

                    // Convert the image to a byte array
                    byte[] imageBytes = File.ReadAllBytes(imagePath);

                    // Save the byte array to the database (associated with the current user)
                    SaveProfilePicture(imageBytes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SaveProfilePicture(byte[] imageBytes)
{
    try
    {
        // Open the database connection
        connect.Open();

        // SQL query to update the profile picture in the Users table
        string updateQuery = "UPDATE Users SET profile_picture = @profilePicture WHERE username = @username";

        using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
        {
            // Get the current username
            string currentUsername = UserSession.CurrentUsername;

            // Add parameters to the query
            cmd.Parameters.AddWithValue("@profilePicture", imageBytes);
            cmd.Parameters.AddWithValue("@username", currentUsername);

            // Execute the query
            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Profile picture updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update the profile picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error saving profile picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
        connect.Close();
    }
}
        private void LoadProfilePicture()
        {
            try
            {
                // Open the database connection
                connect.Open();

                // SQL query to retrieve the profile picture
                string selectQuery = "SELECT profile_picture FROM Users WHERE username = @username";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@username", UserSession.CurrentUsername);

                    // Execute the query and retrieve the profile picture
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])result;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            circularPictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadProfilePicture();
        }

    }
}
