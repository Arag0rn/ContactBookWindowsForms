using System;
using System.Windows.Forms;
using DataAccess.Entity;
using DataAccess.Repository;
using DataAccess.Service;

namespace ContactBookText.Forms.ContactsManager
{
    public partial class FormNewContact : Form
    {
        public FormNewContact()
        {
            InitializeComponent();
        }

        private void FormNewContact_Load(object sender, EventArgs e)
        {
            this.textBoxFullName.Focus();
        } 

        private void buttonNewContact_Click(object sender, EventArgs e)
        {            
            if (this.textBoxFullName.Text == String.Empty)
            {
                MessageBox.Show("Name field must not be empty", "Empty name error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to add this contact", "Adding confirmation",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ContactsRepository contactsRepository = new ContactsRepository("contacts.txt");
                    Contact contact = new Contact();
                    contact.ParentUserId = AuthenticationService.LoggedUser.Id;
                    contact.FullName = this.textBoxFullName.Text;
                    contact.Email = this.textBoxEmail.Text;
                    contact.Address = this.textBoxAddress.Text;
                    contact.Company = this.textBoxCompany.Text;

                    contactsRepository.Save(contact);
                    MessageBox.Show("Contact addded successfully!");

                    FormNewContact.ActiveForm.Close();
                    FormViewAllContacts formViewAll = new FormViewAllContacts();
                    formViewAll.Show();
                } 
            }                   
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormNewContact.ActiveForm.Close();
            FormViewAllContacts formViewAllContacts = new FormViewAllContacts();            
            formViewAllContacts.Show();
        }              
    }
}
