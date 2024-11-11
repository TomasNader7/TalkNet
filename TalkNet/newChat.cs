using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TalkNet
{
    public partial class newChat : Form
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=TOMIROG;Initial Catalog=forget_Password_db;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public int SelectedUserId { get; private set; }

        public newChat()
        {
            InitializeComponent();
            LoadAvailableUsers();
        }

        private void LoadAvailableUsers()
        {
            try
            {
                connect.Open();

                // Query to get all users except the current user
                string query = "SELECT Id, username FROM Users WHERE Id != @currentUserId";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@currentUserId", UserSession.CurrentUserId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        string username = reader.GetString(1);

                        // Add each user to the ListBox (or DataGridView)
                        ListViewItem item = new ListViewItem(username) { Tag = userId };
                        usersListView.Items.Add(item); // Assume you have a ListView control named `usersListView`
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnStartChat_Click(object sender, EventArgs e)
        {
            if (usersListView.SelectedItems.Count > 0)
            {
                // Get selected user ID from Tag
                SelectedUserId = (int)usersListView.SelectedItems[0].Tag;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a user to start a chat.");
            }
        }
    }
}
