namespace AliasClient
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CurrentTeamLabel = new System.Windows.Forms.Label();
            this.WordLabel = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.Team1ScoreLabel = new System.Windows.Forms.Label();
            this.Team2ScoreLabel = new System.Windows.Forms.Label();
            this.CurrentPlayerLabel = new System.Windows.Forms.Label();
            this.GuessButton = new System.Windows.Forms.Button();
            this.SkipButton = new System.Windows.Forms.Button();
            this.SurrenderButton = new System.Windows.Forms.Button();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.ChatInputTextBox = new System.Windows.Forms.TextBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // General form settings
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30); // Dark background
            this.ForeColor = System.Drawing.Color.White; // Light text
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GameForm";
            this.Text = "Alias Game";
            this.Size = new System.Drawing.Size(800, 620); // Начальный размер
            this.MinimumSize = new System.Drawing.Size(600, 620); // Минимальный размер
            this.Resize += new System.EventHandler(this.GameForm_Resize);

            // CurrentTeamLabel
            this.CurrentTeamLabel.AutoSize = true;
            this.CurrentTeamLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentTeamLabel.Location = new System.Drawing.Point(20, 20);
            this.CurrentTeamLabel.Name = "CurrentTeamLabel";
            this.CurrentTeamLabel.Size = new System.Drawing.Size(120, 28);
            this.CurrentTeamLabel.TabIndex = 0;
            this.CurrentTeamLabel.Text = "Current Team: ";

            // WordLabel
            this.WordLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordLabel.ForeColor = System.Drawing.Color.FromArgb(0, 191, 255); // Bright blue word color
            this.WordLabel.Location = new System.Drawing.Point(20, 60);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(760, 50);
            this.WordLabel.TabIndex = 1;
            this.WordLabel.Text = "Word: ???";
            this.WordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // TimerLabel
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.Location = new System.Drawing.Point(20, 120);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(100, 28);
            this.TimerLabel.TabIndex = 2;
            this.TimerLabel.Text = "Time left: 1:00";

            // Team1ScoreLabel
            this.Team1ScoreLabel.AutoSize = true;
            this.Team1ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Team1ScoreLabel.Location = new System.Drawing.Point(20, 160);
            this.Team1ScoreLabel.Name = "Team1ScoreLabel";
            this.Team1ScoreLabel.Size = new System.Drawing.Size(90, 28);
            this.Team1ScoreLabel.TabIndex = 3;
            this.Team1ScoreLabel.Text = "Team 1: 0";

            // Team2ScoreLabel
            this.Team2ScoreLabel.AutoSize = true;
            this.Team2ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Team2ScoreLabel.Location = new System.Drawing.Point(20, 190);
            this.Team2ScoreLabel.Name = "Team2ScoreLabel";
            this.Team2ScoreLabel.Size = new System.Drawing.Size(90, 28);
            this.Team2ScoreLabel.TabIndex = 4;
            this.Team2ScoreLabel.Text = "Team 2: 0";

            // CurrentPlayerLabel
            this.CurrentPlayerLabel.AutoSize = true;
            this.CurrentPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentPlayerLabel.Location = new System.Drawing.Point(20, 220);
            this.CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            this.CurrentPlayerLabel.Size = new System.Drawing.Size(140, 28);
            this.CurrentPlayerLabel.TabIndex = 5;
            this.CurrentPlayerLabel.Text = "Current Player: ";

            // GuessButton
            this.GuessButton.Location = new System.Drawing.Point(20, 270);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(150, 40);
            this.GuessButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GuessButton.BackColor = System.Drawing.Color.FromArgb(139, 195, 74); 
            this.GuessButton.ForeColor = System.Drawing.Color.White;
            this.GuessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat; 
            this.GuessButton.FlatAppearance.BorderSize = 0; // Remove border
            this.GuessButton.TabIndex = 6;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = false;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);

            // SkipButton
            this.SkipButton.Location = new System.Drawing.Point(180, 270);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(150, 40);
            this.SkipButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SkipButton.BackColor = System.Drawing.Color.White;
            this.SkipButton.ForeColor = System.Drawing.Color.Black;
            this.SkipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat; 
            this.SkipButton.FlatAppearance.BorderSize = 0; // Remove border
            this.SkipButton.TabIndex = 7;
            this.SkipButton.Text = "Skip";
            this.SkipButton.UseVisualStyleBackColor = false;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);

            // SurrenderButton
            this.SurrenderButton.Location = new System.Drawing.Point(340, 270);
            this.SurrenderButton.Name = "SurrenderButton";
            this.SurrenderButton.Size = new System.Drawing.Size(150, 40);
            this.SurrenderButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SurrenderButton.BackColor = System.Drawing.Color.FromArgb(211, 47, 47); // Dark red
            this.SurrenderButton.ForeColor = System.Drawing.Color.White;
            this.SurrenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Flat style
            this.SurrenderButton.FlatAppearance.BorderSize = 0; // Remove border
            this.SurrenderButton.TabIndex = 8;
            this.SurrenderButton.Text = "Surrender";
            this.SurrenderButton.UseVisualStyleBackColor = false;
            this.SurrenderButton.Click += new System.EventHandler(this.SurrenderButton_Click);

            // Chat TextBox
            this.ChatTextBox.Location = new System.Drawing.Point(20, 330);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatTextBox.Size = new System.Drawing.Size(760, 200);
            this.ChatTextBox.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.ChatTextBox.ForeColor = System.Drawing.Color.White;
            this.ChatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatTextBox.TabIndex = 9;

            // Chat Input TextBox
            this.ChatInputTextBox.Location = new System.Drawing.Point(20, 540);
            this.ChatInputTextBox.Name = "ChatInputTextBox";
            this.ChatInputTextBox.Size = new System.Drawing.Size(600, 30);
            this.ChatInputTextBox.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.ChatInputTextBox.ForeColor = System.Drawing.Color.White;
            this.ChatInputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatInputTextBox.TabIndex = 10;

            // Send Chat Message Button
            this.SendMessageButton.Location = new System.Drawing.Point(630, 540);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(135, 25);
            this.SendMessageButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SendMessageButton.BackColor = System.Drawing.Color.FromArgb(0, 122, 204); // Blue accent
            this.SendMessageButton.ForeColor = System.Drawing.Color.White;
            this.SendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessageButton.TabIndex = 11;
            this.SendMessageButton.Text = "Send";
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);

            // Form settings
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.ChatInputTextBox);
            this.Controls.Add(this.ChatTextBox);
            this.Controls.Add(this.SurrenderButton);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.CurrentPlayerLabel);
            this.Controls.Add(this.Team2ScoreLabel);
            this.Controls.Add(this.Team1ScoreLabel);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.CurrentTeamLabel);
            this.Name = "GameForm";
            this.Text = "Alias Game";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void GameForm_Resize(object sender, System.EventArgs e)
        {
            // Перерасчет размеров элементов при изменении размера формы
            this.WordLabel.Size = new System.Drawing.Size(this.ClientSize.Width - 40, 50);
            this.ChatTextBox.Size = new System.Drawing.Size(this.ClientSize.Width - 40, 200);
            this.ChatInputTextBox.Size = new System.Drawing.Size(this.ClientSize.Width - 180, 30);
            this.SendMessageButton.Location = new System.Drawing.Point(this.ClientSize.Width - 155, 540);
        }

        private System.Windows.Forms.Label CurrentTeamLabel;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label Team1ScoreLabel;
        private System.Windows.Forms.Label Team2ScoreLabel;
        private System.Windows.Forms.Label CurrentPlayerLabel;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.Button SurrenderButton;
        private System.Windows.Forms.TextBox ChatTextBox;
        private System.Windows.Forms.TextBox ChatInputTextBox;
        private System.Windows.Forms.Button SendMessageButton;
    }
}
