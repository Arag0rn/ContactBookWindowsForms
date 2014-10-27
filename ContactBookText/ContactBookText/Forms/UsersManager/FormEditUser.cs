using System;
using System.Windows.Forms;
using DataAccess.Entity;
using DataAccess.Repository;
using DataAccess.Service;

namespace ContactBookText.Forms.UsersManager
{
    public partial class FormEditUser : Form
    {
        public FormEditUser()
        {
            InitializeComponent();
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            this.textBoxFirstName.Focus();
            
            this.textBoxFirstName.Text = FormViewAllUsers.userFirstName;
            this.textBoxLastName.Text = FormViewAllUsers.userLastName;
            this.textBoxPassword.Text = FormViewAllUsers.userPassword;
            this.textBoxConfirmPassword.Text = FormViewAllUsers.userPassword;
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if (this.textBoxFirstName.Text == String.Empty ||
                this.textBoxLastName.Text == String.Empty ||                
                this.textBoxPassword.Text == String.Empty ||
                this.textBoxConfirmPassword.Text == String.Empty)
            {
                MessageBox.Show("All fields required", "Empty field(s) error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBoxConfirmPassword.Text != textBoxPassword.Text)
            {
                this.textBoxPassword.Text = String.Empty;
                this.textBoxConfirmPassword.Text = String.Empty;

                MessageBox.Show("Password don't match", "Password error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                UsersRepository usersRepository = new UsersRepository("users.txt");
                User user = usersRepository.GetById(FormViewAllUsers.userId);

                DialogResult result = MessageBox.Show("Are you sure you want to edit " +
                    user.FirstName.ToString() + " " + user.LastName.ToString(), "Edit user",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (checkBoxAdminPrivilege.Checked)
                    {
                        user.adminPrivilegeIndex = 1;
                    }
                    else
                    {
                        user.adminPrivilegeIndex = 0;
                    }
                    
                    user.FirstName = this.textBoxFirstName.Text;
                    user.LastName = this.textBoxLastName.Text;                    
                    user.Password = this.textBoxPassword.Text;
                    
                    usersRepository.Update(user);                    
                    FormNewUser.ActiveForm.Close();
                    MessageBox.Show("User edited successfully!");

                    FormViewAllUsers formViewAllUsers = new FormViewAllUsers();
                    formViewAllUsers.Show();
                }               
            } 
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormEditUser.ActiveForm.Close();
            FormViewAllUsers formViewAllUsers = new FormViewAllUsers();
            formViewAllUsers.Show();
        }       
    }
}
