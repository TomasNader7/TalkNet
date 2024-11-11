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
            WHERE CP.UserId = @UserId";  // Filter by the logged-in user

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@UserId", UserSession.CurrentUserId);  // Use the current logged-in user's ID
                SqlDataReader reader = cmd.ExecuteReader();

                chatsView.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ChatName"].ToString());
                    item.Tag = reader["ChatId"]; // Store ChatId for later reference
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
                connect.Close(); // Ensure the connection is closed
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

    }
}
