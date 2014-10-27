using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DataAccess.Service;
using DataAccess.Entity;
using DataAccess.Repository;

namespace ContactBookText.Forms.UsersManager
{
    public partial class FormViewAllUsers : Form
    {
        internal static int userId;        
        internal static string userPassword;
        internal static string userFirstName;
        internal static string userLastName;

        User user = new User();
        UsersRepository usersRepository = new UsersRepository("users.txt");
        ContactsRepository contactsRepository = new ContactsRepository("contacts.txt");                    
        
        public FormViewAllUsers()
        {
            InitializeComponent();

            RefreshItems();            
        }

        private void FormViewAllUsers_Load(object sender, EventArgs e)
        {            
            this.dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dataGridViewItems.Columns[0].Visible = false;
            this.dataGridViewItems.Columns[1].Visible = false;

            this.dataGridViewItems.Columns[2].Width = 121;
            this.dataGridViewItems.Columns[4].Width = 130;
            this.dataGridViewItems.Columns[5].Width = 130;

            this.dataGridViewItems.Columns[2].HeaderText = "Username";
            this.dataGridViewItems.Columns[3].HeaderText = "Password";
            this.dataGridViewItems.Columns[4].HeaderText = "First name";
            this.dataGridViewItems.Columns[5].HeaderText = "Last name";            
        }

        private void RefreshItems()
        {
            List<User> users = usersRepository.GetAll();
            dataGridViewItems.DataSource = users;
        }  

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormViewAllUsers.ActiveForm.Close();
            FormNewUser formNewUser = new FormNewUser();
            formNewUser.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            userId = Convert.ToInt32(this.dataGridViewItems.CurrentRow.Cells[0].Value);           
            userPassword = this.dataGridViewItems.CurrentRow.Cells[3].Value.ToString();
            userFirstName = this.dataGridViewItems.CurrentRow.Cells[4].Value.ToString();
            userLastName = this.dataGridViewItems.CurrentRow.Cells[5].Value.ToString();

            FormViewAllUsers.ActiveForm.Close();
            FormEditUser formEditUSer = new FormEditUser();
            formEditUSer.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            userId = Convert.ToInt32(this.dataGridViewItems.CurrentRow.Cells[0].Value);
            if (userId == AuthenticationService.LoggedUser.Id)
            {
                MessageBox.Show("You can't delete yourself!", "Logged user error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Contact contact = contactsRepository.GetById(userId);
            try
            {
                if (userId == contact.ParentUserId)
                {
                    MessageBox.Show("Can't delete. User has saved contacts!", "User records not empty",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    User user = usersRepository.GetById(userId);
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete " +
                        user.FirstName + " " +
                        user.LastName + "?",
                        "Delete user",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        usersRepository.Delete(user);
                        MessageBox.Show("User deleted successfully");
                        RefreshItems();
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("User deleted successfully");
            }            
        }              
    }
}
