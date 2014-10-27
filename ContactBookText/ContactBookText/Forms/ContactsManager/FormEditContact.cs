using System;
using System.Windows.Forms;
using DataAccess.Entity;
using DataAccess.Repository;
using DataAccess.Service;

namespace ContactBookText.Forms.ContactsManager
{
    public partial class FormEditContact : Form
    {                
        public FormEditContact()
        {
            InitializeComponent();        
        }

        private void FormEditContact_Load(object sender, EventArgs e)
        {
            this.textBoxFullName.Focus();
            
            this.textBoxFullName.Text = FormViewAllContacts.contactName;
            this.textBoxEmail.Text = FormViewAllContacts.contactEmail;
            this.textBoxAddress.Text = FormViewAllContacts.contactAddress;
            this.textBoxCompany.Text = FormViewAllContacts.contactCompany;
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {                                      
            if (this.textBoxFullName.Text == String.Empty)
            {
                MessageBox.Show("Name field must not be empty", "Empty name error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {                
                DialogResult result = MessageBox.Show("Are you sure you want to edit " +
                    this.textBoxFullName.Text,
                    "Edit contact",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ContactsRepository contactsRepository = new ContactsRepository("contacts.txt");
                    Contact contact = new Contact();
                    contact.Id = FormViewAllContacts.contactId;
                    contact.ParentUserId = AuthenticationService.LoggedUser.Id;
                    contact.FullName = this.textBoxFullName.Text;
                    contact.Email = this.textBoxEmail.Text;
                    contact.Address = this.textBoxAddress.Text;
                    contact.Company = this.textBoxCompany.Text;

                    contactsRepository.Save(contact);
                    MessageBox.Show("Contact edited successfully");

                    FormEditContact.ActiveForm.Close();
                    FormViewAllContacts formViewAllContacts = new FormViewAllContacts();
                    formViewAllContacts.Show();
                }
            }            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormEditContact.ActiveForm.Close();
            FormViewAllContacts formViewAllContacts = new FormViewAllContacts();
            formViewAllContacts.Show();
        }        
    }
}
