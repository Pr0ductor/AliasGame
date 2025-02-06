using System;
using System.Windows.Forms;

namespace AliasClient
{
    public partial class LoginForm : Form
    {
        public string Nickname { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Nickname = NicknameTextBox.Text;
            if (string.IsNullOrEmpty(Nickname))
            {
                MessageBox.Show("Please enter a nickname.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}