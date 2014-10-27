using System;
using System.Windows.Forms;
using DataAccess.Service;

namespace ContactBookText.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.textBoxUsername.Focus();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = this.textBoxUsername.Text;
            string password = this.textBoxPassword.Text;

            AuthenticationService.AuthenticateUser(username, password);
            if (AuthenticationService.LoggedUser != null)
            {
                this.textBoxUsername.Text = String.Empty;
                this.textBoxPassword.Text = String.Empty;

                FormLogin.ActiveForm.Close();

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.textBoxUsername.Text = String.Empty;
                this.textBoxPassword.Text = String.Empty;
                this.textBoxUsername.Focus();
                MessageBox.Show("Invalid username or password", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
