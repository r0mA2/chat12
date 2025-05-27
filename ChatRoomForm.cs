using System;
using System.Windows.Forms;

namespace ChatRoomsApp
{
    public class ChatRoomForm : Form
    {
        private TextBox messageInput;
        private Button sendButton;
        private ListBox chatBox;

        public ChatRoomForm(string roomName)
        {
            this.Text = roomName;
            this.Width = 400;
            this.Height = 300;

            chatBox = new ListBox() { Dock = DockStyle.Top, Height = 200 };
            messageInput = new TextBox() { Dock = DockStyle.Top };
            sendButton = new Button() { Text = "Отправить", Dock = DockStyle.Top };

            sendButton.Click += SendButton_Click;

            this.Controls.Add(sendButton);
            this.Controls.Add(messageInput);
            this.Controls.Add(chatBox);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(messageInput.Text))
            {
                chatBox.Items.Add($"Вы: {messageInput.Text}");
                messageInput.Clear();
            }
        }
    }
}
