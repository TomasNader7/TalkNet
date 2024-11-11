using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace TalkNet
{
    public partial class Home : Form
    {
        // Database connection with the specified connection string
        SqlConnection connect = new SqlConnection(@"Data Source=TOMIROG;Initial Catalog=forget_Password_db;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadChatsFromDatabase();
        }

        // Method to load chats from the database
        private void LoadChatsFromDatabase()
        {
            try
            {
                connect.Open();
                string query = @"
            SELECT C.ChatId, C.ChatName 
            FROM Chats C
            INNER JOIN ChatParticipants CP ON C.ChatId = CP.ChatId
            WHERE CP.UserId = @UserId";  // Get only chats the user participates in

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@UserId", UserSession.CurrentUserId);  // Use the current user's ID
                SqlDataReader reader = cmd.ExecuteReader();

                chatsView.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ChatName"].ToString());
                    item.Tag = reader["ChatId"]; // Store ChatId for reference
                    chatsView.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chats: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void chatsView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (chatsView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = chatsView.SelectedItems[0];
                int chatId = Convert.ToInt32(selectedItem.Tag); // Retrieve ChatId stored in Tag

                // Open the IndividualChat form and pass the selected chatId
                IndividualChat chatForm = new IndividualChat(chatId);
                chatForm.Show();
                this.Hide(); // Hide Home form if necessary
            }
        }


        private void homeBtn_Click(object sender, EventArgs e)
        {
            LoadChatsFromDatabase(); // // Refresh chats if Home button is clicked
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            Setting S = new Setting();
            S.Show();
            this.Hide();
        }

        private void newChatbtn_Click(object sender, EventArgs e)
        {
            using (newChat newChatForm = new newChat())
            {
                if (newChatForm.ShowDialog() == DialogResult.OK)
                {
                    int selectedUserId = newChatForm.SelectedUserId;
                    int chatId = CreateNewChat(selectedUserId);

                    if (chatId > 0)
                    {
                        // Open the chat in the IndividualChat form
                        IndividualChat chatForm = new IndividualChat(chatId);
                        chatForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error creating new chat.");
                    }
                }
            }
        }

        private int CreateNewChat(int otherUserId)
        {
            int chatId = -1;
            string otherUsername = string.Empty;

            try
            {
                connect.Open();

                // Retrieve the username of the other user (the person you are chatting with)
                string query = "SELECT username FROM Users WHERE Id = @otherUserId";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@otherUserId", otherUserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            otherUsername = reader["username"].ToString();
                        }
                    }
                }

                // Check if we have the other username
                if (!string.IsNullOrEmpty(otherUsername))
                {
                    // Set the chat name based on who is logged in
                    string currentUserUsername = UserSession.CurrentUsername;  // Get the current logged-in user's name
                    string chatName = "Chat with ";

                    // Set chat name dynamically
                    if (UserSession.CurrentUserId == otherUserId)
                    {
                        // If the logged-in user is the one being chatted with, set the name to the other user
                        chatName += otherUsername;  // The other person is being chatted with
                    }
                    else
                    {
                        chatName += currentUserUsername;  // The logged-in user is chatting with the other person
                    }

                    // Insert a new chat and retrieve the ChatId
                    string insertChatQuery = "INSERT INTO Chats (ChatName, UserId) OUTPUT INSERTED.ChatId VALUES (@chatName, @currentUserId)";
                    using (SqlCommand cmd = new SqlCommand(insertChatQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@chatName", chatName);
                        cmd.Parameters.AddWithValue("@currentUserId", UserSession.CurrentUserId);
                        chatId = (int)cmd.ExecuteScalar();  // Retrieve the ChatId of the newly created chat
                    }

                    if (chatId > 0)
                    {
                        // Insert participants (both the logged-in user and the other user)
                        string insertParticipantsQuery = "INSERT INTO ChatParticipants (ChatId, UserId) VALUES (@chatId, @userId)";
                        using (SqlCommand cmd = new SqlCommand(insertParticipantsQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@chatId", chatId);
                            cmd.Parameters.AddWithValue("@userId", UserSession.CurrentUserId);  // Add logged-in user
                            cmd.ExecuteNonQuery();  // Execute the insert for the logged-in user

                            cmd.Parameters["@userId"].Value = otherUserId;  // Update for the other user
                            cmd.ExecuteNonQuery();  // Execute the insert for the other user
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating chat: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

            return chatId;
        }



    }
}
