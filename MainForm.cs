using System;
using System.Windows.Forms;

namespace ChatRoomsApp
{
    public partial class MainForm : Form
    {
        private int roomCount = 0;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Главное окно — Чат с комнатами";

            // Кнопка "Создать комнату"
            Button createRoomButton = new Button();
            createRoomButton.Text = "Создать комнату";
            createRoomButton.Dock = DockStyle.Top;
            createRoomButton.Click += CreateRoomButton_Click;

            // Кнопка "Выход"
            Button exitButton = new Button();
            exitButton.Text = "Выход";
            exitButton.Dock = DockStyle.Top;
            exitButton.Click += (s, e) => this.Close();

            // Добавляем кнопки на форму
            this.Controls.Add(exitButton);
            this.Controls.Add(createRoomButton);

            this.Width = 300;
            this.Height = 150;
        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            roomCount++;
            var room = new ChatRoomForm($"Комната {roomCount}");
            room.Show();
        }
    }
}
