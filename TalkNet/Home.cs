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
            SELECT C.ChatId, C.ChatName, 
                   CASE 
                       WHEN U1.UserID = @UserId THEN U2.username 
                       ELSE U1.username 
                   END AS DisplayChatName
            FROM Chats C
            INNER JOIN ChatParticipants CP1 ON C.ChatId = CP1.ChatId
            INNER JOIN ChatParticipants CP2 ON C.ChatId = CP2.ChatId AND CP1.UserId != CP2.UserId
            INNER JOIN Users U1 ON CP1.UserId = U1.UserID
            INNER JOIN Users U2 ON CP2.UserId = U2.UserID
            WHERE (CP1.UserId = @UserId OR CP2.UserId = @UserId)";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@UserId", UserSession.CurrentUserId);  // Use the current user's ID
                SqlDataReader reader = cmd.ExecuteReader();

                chatsView.Items.Clear();

                while (reader.Read())
                {
                    string displayChatName = "Chat with " + reader["DisplayChatName"].ToString();
                    ListViewItem item = new ListViewItem(displayChatName);
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
            newChatbtn.Enabled = false;
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
            newChatbtn.Enabled = true;
        }

        private int CreateNewChat(int otherUserId)
        {
            int chatId = -1;

            try
            {
                connect.Open();

                // Check if a chat already exists between the two users
                string checkExistingChatQuery = @"
            SELECT C.ChatId
            FROM Chats C
            INNER JOIN ChatParticipants CP1 ON C.ChatId = CP1.ChatId
            INNER JOIN ChatParticipants CP2 ON C.ChatId = CP2.ChatId
            WHERE (CP1.UserId = @currentUserId AND CP2.UserId = @otherUserId)
               OR (CP1.UserId = @otherUserId AND CP2.UserId = @currentUserId)";

                using (SqlCommand cmd = new SqlCommand(checkExistingChatQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@currentUserId", UserSession.CurrentUserId);
                    cmd.Parameters.AddWithValue("@otherUserId", otherUserId);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        // Chat already exists, return the existing ChatId immediately
                        chatId = Convert.ToInt32(result);
                        return chatId;
                    }
                }

                // No existing chat, create a new one
                string insertChatQuery = "INSERT INTO Chats (ChatName) OUTPUT INSERTED.ChatId VALUES (@chatName)";
                using (SqlCommand cmd = new SqlCommand(insertChatQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@chatName", "Chat with User");
                    chatId = (int)cmd.ExecuteScalar();
                }

                if (chatId > 0)
                {
                    // Insert participants (both the logged-in user and the other user)
                    string insertParticipantsQuery = "INSERT INTO ChatParticipants (ChatId, UserId) VALUES (@chatId, @userId)";
                    using (SqlCommand cmd = new SqlCommand(insertParticipantsQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@chatId", chatId);
                        cmd.Parameters.AddWithValue("@userId", UserSession.CurrentUserId);  // Add logged-in user
                        cmd.ExecuteNonQuery();  // Execute insert for the logged-in user

                        cmd.Parameters["@userId"].Value = otherUserId;  // Update for the other user
                        cmd.ExecuteNonQuery();  // Execute insert for the other user
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
