using System;
using System.Windows.Forms;
using DataAccess.Entity;
using DataAccess.Repository;
using DataAccess.Service;

namespace ContactBookText.Forms.UsersManager
{
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
        }

        private void FormNewUser_Load(object sender, EventArgs e)
        {
            this.textBoxFirstName.Focus();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            short adminIndex;
            if (checkBoxAdminPrivilege.Checked)
            {                
                adminIndex = 1;
            }
            else
            {                
                adminIndex = 0;
            }
            
            if (this.textBoxFirstName.Text == String.Empty ||
                this.textBoxLastName.Text == String.Empty ||
                this.textBoxUsername.Text == String.Empty ||
                this.textBoxPassword.Text == String.Empty ||
                this.textBoxConfirmPassword.Text == String.Empty)
            {
                MessageBox.Show("All fields required", "Empty field(s) error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (this.textBoxConfirmPassword.Text != this.textBoxPassword.Text)
            {
                this.textBoxPassword.Text = String.Empty;
                this.textBoxConfirmPassword.Text = String.Empty;

                MessageBox.Show("Password don't match", "Password error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                User user = new User();
                user.Id = AuthenticationService.LoggedUser.Id;
                UsersRepository usersRepository = new UsersRepository("users.txt");
                
                DialogResult result = MessageBox.Show("Are you sure you want to add this user", "Adding confirmation",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (User item in usersRepository.GetAll())
                    {
                        if (this.textBoxUsername.Text == item.Username)
                        {
                            this.textBoxUsername.Text = String.Empty;
                            MessageBox.Show("Username already exists!", "Username coincidence",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;   
                        }
                    }
                    
                    user.adminPrivilegeIndex = adminIndex;
                    user.FirstName = this.textBoxFirstName.Text;
                    user.LastName = this.textBoxLastName.Text;
                    user.Username = this.textBoxUsername.Text;
                    user.Password = this.textBoxPassword.Text;

                    usersRepository.Insert(user);                    
                    MessageBox.Show("User saved successfully!");

                    FormNewUser.ActiveForm.Close();
                    FormViewAllUsers formViewAllUsers = new FormViewAllUsers();
                    formViewAllUsers.Show();
                }               
            }   
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormNewUser.ActiveForm.Close();
            FormViewAllUsers formViewAllUsers = new FormViewAllUsers();
            formViewAllUsers.Show();            
        }       
    }
}
