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
        private int _chatId;
        public IndividualChat(int chatId)
        {
            InitializeComponent();
            _chatId = chatId;
        }
        private void IndividualChat_Load(object sender, EventArgs e)
        {

        }
    }
}
