namespace AliasClient
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LabelTitle = new System.Windows.Forms.Label();
            NicknameTextBox = new System.Windows.Forms.TextBox();
            LoginButton = new System.Windows.Forms.Button();
            LabelNickname = new System.Windows.Forms.Label();

            // General form settings
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30); // Dark background
            this.ForeColor = System.Drawing.Color.White; // Light text
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "Login";

            // LabelTitle
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LabelTitle.Location = new System.Drawing.Point(30, 20);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new System.Drawing.Size(240, 37);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "Alias Original";
            LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // NicknameTextBox
            NicknameTextBox.Location = new System.Drawing.Point(30, 90);
            NicknameTextBox.Name = "NicknameTextBox";
            NicknameTextBox.Size = new System.Drawing.Size(240, 30);
            NicknameTextBox.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            NicknameTextBox.ForeColor = System.Drawing.Color.White;
            NicknameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            NicknameTextBox.TabIndex = 1;

            // LabelNickname
            LabelNickname.AutoSize = true;
            LabelNickname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LabelNickname.Location = new System.Drawing.Point(30, 65);
            LabelNickname.Name = "LabelNickname";
            LabelNickname.Size = new System.Drawing.Size(84, 23);
            LabelNickname.TabIndex = 4;
            LabelNickname.Text = "Nickname:";

            // LoginButton
            LoginButton.Location = new System.Drawing.Point(90, 140);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new System.Drawing.Size(120, 40);
            LoginButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            LoginButton.BackColor = System.Drawing.Color.FromArgb(76, 175, 80); // Dark green
            LoginButton.ForeColor = System.Drawing.Color.White;
            LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LoginButton.FlatAppearance.BorderSize = 0; // Remove border
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;

            // Add controls to the form
            this.Controls.Add(LabelTitle);
            this.Controls.Add(NicknameTextBox);
            this.Controls.Add(LabelNickname);
            this.Controls.Add(LoginButton);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LabelNickname;
    }
}
