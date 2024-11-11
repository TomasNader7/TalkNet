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
            try
            {
                connect.Open();

                // Insert a new chat record and retrieve the new ChatId
                string insertChatQuery = "INSERT INTO Chats (ChatName, UserId) OUTPUT INSERTED.ChatId VALUES (@chatName, @currentUserId)";
                using (SqlCommand cmd = new SqlCommand(insertChatQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@chatName", "Chat with User " + otherUserId);
                    cmd.Parameters.AddWithValue("@currentUserId", UserSession.CurrentUserId);
                    chatId = (int)cmd.ExecuteScalar(); // Get the new ChatId
                }

                if (chatId > 0)
                {
                    // Insert records into ChatParticipants for both users
                    string insertParticipantsQuery = "INSERT INTO ChatParticipants (ChatId, UserId) VALUES (@chatId, @userId)";
                    using (SqlCommand cmd = new SqlCommand(insertParticipantsQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@chatId", chatId);
                        cmd.Parameters.AddWithValue("@userId", UserSession.CurrentUserId);
                        cmd.ExecuteNonQuery(); // Add the current user

                        cmd.Parameters["@userId"].Value = otherUserId;
                        cmd.ExecuteNonQuery(); // Add the other user
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
