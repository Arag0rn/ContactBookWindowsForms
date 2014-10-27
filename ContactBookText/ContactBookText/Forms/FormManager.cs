using System;
using System.Windows.Forms;
using DataAccess.Entity;
using DataAccess.Repository;
using DataAccess.Service;
using ContactBookText.Forms.ContactsManager;
using ContactBookText.Forms.UsersManager;

namespace ContactBookText.Forms
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonContacts_Click(object sender, EventArgs e)
        {
            FormViewAllContacts formViewAllContacts = new FormViewAllContacts();
            formViewAllContacts.Show();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            if (AuthenticationService.LoggedUser.adminPrivilegeIndex != 1)
            {
                MessageBox.Show("You do not have permission to this section!", "Limited permissions",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                FormViewAllUsers formViewAllUsers = new FormViewAllUsers();
                formViewAllUsers.Show();
            }
        }
    }
}
