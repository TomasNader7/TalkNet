using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TalkNet
{
    public partial class IndividualChat : Form
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=TOMIROG;Initial Catalog=forget_Password_db;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private int chatId;

        public IndividualChat(int chatId)
        {
            InitializeComponent();
            this.chatId = chatId;

        }

        private void IndividualChat_Load(object sender, EventArgs e)
        {
            LoadChatMessages();

        }

        private void LoadChatMessages()
        {
            chatPanel.Controls.Clear(); // Clear existing messages

            try
            {
                connect.Open();
                string query = "SELECT M.MessageText, U.username, M.Timestamp " +
                               "FROM Messages M " +
                               "INNER JOIN Users U ON M.SenderId = U.Id " +
                               "WHERE M.ChatId = @ChatId " +
                               "ORDER BY M.Timestamp";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@ChatId", chatId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string username = reader["username"].ToString();
                            string messageText = reader["MessageText"].ToString();
                            DateTime timestamp = (DateTime)reader["Timestamp"];

                            // Create a custom bubble panel for each message
                            Panel bubblePanel = new Panel();
                            bubblePanel.AutoSize = true;
                            bubblePanel.Padding = new Padding(10);
                            bubblePanel.BackColor = username == UserSession.CurrentUsername ? Color.LightBlue : Color.LightGray;
                            //bubblePanel.Anchor = username == UserSession.CurrentUsername ? AnchorStyles.Right : AnchorStyles.Left;
                            bubblePanel.Margin = new Padding(5);

                            // Add message text and user name
                            Label messageLabel = new Label();
                            messageLabel.Text = $" {username} {timestamp}\n{messageText}";
                            messageLabel.AutoSize = true;
                            messageLabel.MaximumSize = new Size(500, 0);
                            bubblePanel.Controls.Add(messageLabel);

                            // Align bubbles
                            //bubblePanel.Dock = username == UserSession.CurrentUsername ? DockStyle.Right : DockStyle.Left;
                            chatPanel.Controls.Add(bubblePanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chat messages: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

            // Auto-scroll to the latest message
            chatPanel.ScrollControlIntoView(chatPanel.Controls[chatPanel.Controls.Count - 1]);
        }


        private void btnSend_Click_1(object sender, EventArgs e)
        {
            string messageContent = txtMessage.Text.Trim();

            if (string.IsNullOrWhiteSpace(messageContent))
            {
                MessageBox.Show("Cannot send an empty message.");
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=TOMIROG;Initial Catalog=forget_Password_db;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    connect.Open();
                    string query = "INSERT INTO Messages (ChatId, SenderId, MessageText, Timestamp) VALUES (@ChatId, @SenderId, @MessageText, @Timestamp)";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@ChatId", chatId);
                        cmd.Parameters.AddWithValue("@SenderId", UserSession.CurrentUserId);
                        cmd.Parameters.AddWithValue("@MessageText", messageContent);
                        cmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }

                txtMessage.Clear();
                LoadChatMessages();
                MessageBox.Show("Message sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message);
            }
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Close();
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            Setting s = new Setting();
            s.Show();
            this.Close();
        }
    }
}
