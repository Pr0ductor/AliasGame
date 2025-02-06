using System;
using System.Windows.Forms;

namespace AliasClient
{
    public partial class GameForm : Form
    {
        private Client _client;
        private string _nickname;
        private bool _isExplaining = false;
        private int _remainingTime = 60;

        private System.Windows.Forms.Timer _gameTimer;

        public GameForm(Client client, string nickname)
        {
            InitializeComponent();
            _client = client;
            _nickname = nickname;

            // Инициализация таймера
            _gameTimer = new System.Windows.Forms.Timer { Interval = 1000 }; // Интервал 1 секунда
            _gameTimer.Tick += OnTimerTick;

            _client.OnMessageReceived += Client_OnMessageReceived;
            _client.SendMessage($"JOIN|{_nickname}");
        }

        private void Client_OnMessageReceived(object sender, string message)
        {
            string[] parts = message.Split('|');
            switch (parts[0])
            {
                case "JOIN":
                    if (parts[1] == "ERROR")
                    {
                        MessageBox.Show(parts[2], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                    else
                    {
                        UpdateChatBox($"Console: Player {parts[1]} joined the game.");
                    }
                    break;

                case "LEAVE":
                    UpdateChatBox($"Console: Player {parts[1]} left the game.");
                    break;

                case "CHAT":
                    UpdateChatBox($"{parts[1]}: {parts[2]}");
                    break;

                case "START_GAME":
                    StartGame(parts[1], parts[2], parts[3]); // parts[1] - команда, parts[2] - игрок, parts[3] - слово
                    UpdateChatBox("Console: Game was started!");
                    break;

                case "NEXT_TURN":
                    NextTurn(parts[1], parts[2], parts[3]); // parts[1] - команда, parts[2] - игрок, parts[3] - слово
                    break;

                case "GUESS":
                    UpdateScore(parts[1], int.Parse(parts[2])); // Обновление счета
                    break;

                case "SKIP":
                    ShowNextWord(parts[1]); // Показ следующего слова
                    break;

                case "WIN":
                    Win(parts[1]); // Победа команды
                    Close();
                    break;

                case "PLAYERS":
                    UpdatePlayersList(parts[1].Split("&&")); // Обновление списка игроков
                    break;
            }
        }

        private void StartGame(string team, string player, string word)
        {
            Invoke((MethodInvoker)delegate
            {
                CurrentTeamLabel.Text = $"Current Team: {team}";
                CurrentPlayerLabel.Text = $"Current Player: {player}";
                WordLabel.Text = _isExplaining ? word : "???"; // Показываем слово только текущему объясняющему игроку
                _isExplaining = player == _nickname;

                if (_isExplaining)
                {
                    GuessButton.Enabled = true;
                    SkipButton.Enabled = true;
                    ResetTimer(); // Запускаем таймер
                }
                else
                {
                    GuessButton.Enabled = false;
                    SkipButton.Enabled = false;
                    StopTimer(); // Останавливаем таймер
                }
            });
        }

        private void NextTurn(string team, string player, string word)
        {
            Invoke((MethodInvoker)delegate
            {
                CurrentTeamLabel.Text = $"Current Team: {team}";
                CurrentPlayerLabel.Text = $"Current Player: {player}";
                WordLabel.Text = _isExplaining ? word : "???"; // Показываем слово только текущему объясняющему игроку
                _isExplaining = player == _nickname;

                if (_isExplaining)
                {
                    GuessButton.Enabled = true;
                    SkipButton.Enabled = true;
                    ResetTimer(); // Запускаем таймер
                }
                else
                {
                    GuessButton.Enabled = false;
                    SkipButton.Enabled = false;
                    StopTimer(); // Останавливаем таймер
                }
            });
        }

        private void UpdateScore(string team, int score)
        {
            Invoke((MethodInvoker)delegate
            {
                if (team == "Team1")
                {
                    Team1ScoreLabel.Text = $"Team 1: {score}";
                }
                else if (team == "Team2")
                {
                    Team2ScoreLabel.Text = $"Team 2: {score}";
                }
            });
        }

        private void ShowNextWord(string word)
        {
            Invoke((MethodInvoker)delegate
            {
                if (_isExplaining)
                {
                    WordLabel.Text = word; // Показываем слово
                }
                else
                {
                    WordLabel.Text = "???"; // Скрываем слово
                }
            });
        }

        private void Win(string team)
        {
            MessageBox.Show($"Team {team} won the game!", "WIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void UpdatePlayersList(string[] players)
        {
            ChatTextBox.Invoke((MethodInvoker)delegate
            {
                ChatTextBox.AppendText("Current Players:\n");
                foreach (var player in players)
                {   
                    ChatTextBox.AppendText("    ");
                    ChatTextBox.AppendText($"{player}\n"); // Добавляем каждого игрока с новой строки
                }
            });
        }

        private void UpdateChatBox(string message)
        {
            ChatTextBox.Invoke((MethodInvoker)delegate
            {
                ChatTextBox.AppendText("    ");
                ChatTextBox.AppendText($"{message}\n"); // Добавляем перенос строки
            });
        }

        private void Error(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            if (_isExplaining)
            {
                _client.SendMessage("GUESS");
            }
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            if (_isExplaining)
            {
                _client.SendMessage("SKIP");
            }
        }

        private void SurrenderButton_Click(object sender, EventArgs e)
        {
            _client.SendMessage($"LEAVE|{_nickname}");
            Close();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            string message = ChatInputTextBox.Text;
            if (!string.IsNullOrEmpty(message))
            {
                _client.SendMessage($"CHAT|{_nickname}|{message}");
                ChatInputTextBox.Clear();
            }
        }

        private void ResetTimer()
        {
            _remainingTime = 60;
            TimerLabel.Text = $"Time left: {FormatTime(_remainingTime)}";
            _gameTimer.Start();
        }

        private void StopTimer()
        {
            _gameTimer.Stop();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (_remainingTime > 0)
            {
                _remainingTime--;
                TimerLabel.Text = $"Time left: {FormatTime(_remainingTime)}";
            }
            else
            {
                _gameTimer.Stop();
                if (_isExplaining)
                {
                    _client.SendMessage("END_TURN"); // Автоматическое завершение хода
                }
            }
        }

        private string FormatTime(int seconds)
        {
            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;
            return $"{minutes}:{remainingSeconds:D2}";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _client?.RemoveMessageHandler(Client_OnMessageReceived);
            _client?.Dispose();
        }
    }
}