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

        #region Windows Form Designer generated code

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
            // 
            // CurrentTeamLabel
            // 
            this.CurrentTeamLabel.AutoSize = true;
            this.CurrentTeamLabel.Location = new System.Drawing.Point(20, 20);
            this.CurrentTeamLabel.Name = "CurrentTeamLabel";
            this.CurrentTeamLabel.Size = new System.Drawing.Size(93, 17);
            this.CurrentTeamLabel.TabIndex = 0;
            this.CurrentTeamLabel.Text = "Current Team: ";
            // 
            // WordLabel
            // 
            this.WordLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordLabel.Location = new System.Drawing.Point(20, 50);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(300, 50);
            this.WordLabel.TabIndex = 1;
            this.WordLabel.Text = "Word: ???";
            this.WordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(20, 110);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(86, 17);
            this.TimerLabel.TabIndex = 2;
            this.TimerLabel.Text = "Time left: 3:00";
            // 
            // Team1ScoreLabel
            // 
            this.Team1ScoreLabel.AutoSize = true;
            this.Team1ScoreLabel.Location = new System.Drawing.Point(20, 140);
            this.Team1ScoreLabel.Name = "Team1ScoreLabel";
            this.Team1ScoreLabel.Size = new System.Drawing.Size(76, 17);
            this.Team1ScoreLabel.TabIndex = 3;
            this.Team1ScoreLabel.Text = "Team 1: 0";
            // 
            // Team2ScoreLabel
            // 
            this.Team2ScoreLabel.AutoSize = true;
            this.Team2ScoreLabel.Location = new System.Drawing.Point(20, 160);
            this.Team2ScoreLabel.Name = "Team2ScoreLabel";
            this.Team2ScoreLabel.Size = new System.Drawing.Size(76, 17);
            this.Team2ScoreLabel.TabIndex = 4;
            this.Team2ScoreLabel.Text = "Team 2: 0";
            // 
            // CurrentPlayerLabel
            // 
            this.CurrentPlayerLabel.AutoSize = true;
            this.CurrentPlayerLabel.Location = new System.Drawing.Point(20, 190);
            this.CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            this.CurrentPlayerLabel.Size = new System.Drawing.Size(106, 17);
            this.CurrentPlayerLabel.TabIndex = 5;
            this.CurrentPlayerLabel.Text = "Current Player: ";
            // 
            // Buttons
            // 
            this.GuessButton.Location = new System.Drawing.Point(20, 220);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(100, 30);
            this.GuessButton.TabIndex = 6;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);

            this.SkipButton.Location = new System.Drawing.Point(130, 220);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(100, 30);
            this.SkipButton.TabIndex = 7;
            this.SkipButton.Text = "Skip";
            this.SkipButton.UseVisualStyleBackColor = true;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);

            this.SurrenderButton.Location = new System.Drawing.Point(240, 220);
            this.SurrenderButton.Name = "SurrenderButton";
            this.SurrenderButton.Size = new System.Drawing.Size(100, 30);
            this.SurrenderButton.TabIndex = 8;
            this.SurrenderButton.Text = "Surrender";
            this.SurrenderButton.UseVisualStyleBackColor = true;
            this.SurrenderButton.Click += new System.EventHandler(this.SurrenderButton_Click);
            // 
            // Chat TextBox
            // 
            this.ChatTextBox.Location = new System.Drawing.Point(20, 270);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatTextBox.Size = new System.Drawing.Size(760, 250);
            this.ChatTextBox.TabIndex = 9;

            // Chat Input TextBox
            this.ChatInputTextBox.Location = new System.Drawing.Point(20, 530);
            this.ChatInputTextBox.Name = "ChatInputTextBox";
            this.ChatInputTextBox.Size = new System.Drawing.Size(600, 22);
            this.ChatInputTextBox.TabIndex = 10;

            // Send Chat Message Button
            this.SendMessageButton.Location = new System.Drawing.Point(630, 530);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(150, 30);
            this.SendMessageButton.TabIndex = 11;
            this.SendMessageButton.Text = "Send";
            this.SendMessageButton.UseVisualStyleBackColor = true;
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

        #endregion

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