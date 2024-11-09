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

        private int _userId;
        public Home(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadChatsFromDatabase();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selection of items in the list view
            // Example: Load chat details or perform actions based on selection
        }
        // Method to load chats from the database
        private void LoadChatsFromDatabase()
        {
            try
            {
                connect.Open();
                string query = "SELECT ChatId, ChatName FROM Chats"; // Adjust the query based on your database schema
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataReader reader = cmd.ExecuteReader();

                chatlistBox.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ChatName"].ToString());
                    item.Tag = reader["ChatId"]; // Store ChatId for later reference
                    chatlistBox.Items.Add(item);
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

        private void LoadChatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chatlistBox.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = chatlistBox.SelectedItems[0];
                int chatId = Convert.ToInt32(selectedItem.Tag); // Retrieve ChatId stored in Tag

                // Open the IndividualChat form and pass the selected chatId
                IndividualChat chatForm = new IndividualChat(chatId, _userId);
                chatForm.Show();
                this.Hide(); // Hide Home form if necessary
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            // Optional: Reload chats or handle home button click event
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            Setting S = new Setting();
            S.Show();
            this.Hide();
        }
    }
}
