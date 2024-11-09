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
    public partial class IndividualChat : Form
    {
        public IndividualChat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserBox_Enter(object sender, EventArgs e)
        {

        }

        /*
         * using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TalkNet
{
    public partial class IndividualChat : Form
    {
        private int _chatId;
        private int _userId; // User ID of the currently logged-in user
        private SqlConnection connect = new SqlConnection(@"Data Source=TOMIROG;Initial Catalog=forget_Password_db;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public IndividualChat(int chatId, int userId)
        {
            InitializeComponent();
            _chatId = chatId;
            _userId = userId; // Store the user ID
        }

        private void IndividualChat_Load(object sender, EventArgs e)
        {
            // Optionally, display the user ID to whom you're chatting
            label2.Text = $"Chatting with User ID: {GetChatUserId(_chatId)}"; // Update this method to get the user ID of the chat partner
        }

        private int GetChatUserId(int chatId)
        {
            int chatUserId = 0;
            try
            {
                connect.Open();
                // Retrieve the user ID of the chat partner from the database
                string query = "SELECT PartnerUserId FROM Chats WHERE ChatId = @chatId"; // Adjust the query based on your schema
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@chatId", chatId);
                    chatUserId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving chat partner ID: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return chatUserId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            if (!string.IsNullOrEmpty(message))
            {
                SendMessage(_userId, _chatId, message); // Send the message
                messageTextBox.Clear(); // Clear the input box after sending
            }
            else
            {
                MessageBox.Show("Please enter a message.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SendMessage(int userId, int chatId, string message)
        {
            try
            {
                connect.Open();
                // Insert the message into the database
                string query = "INSERT INTO Messages (ChatId, SenderUserId, MessageText, Timestamp) VALUES (@chatId, @userId, @message, @timestamp)";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@chatId", chatId);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@message", message);
                    cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Message sent!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}

         * */
    }
}
