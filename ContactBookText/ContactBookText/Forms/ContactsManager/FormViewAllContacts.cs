using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DataAccess.Service;
using DataAccess.Entity;
using DataAccess.Repository;

namespace ContactBookText.Forms.ContactsManager
{    
    public partial class FormViewAllContacts : Form
    {
        internal static int phoneId;
        internal static int parentId;
        internal static string phoneNumber;

        internal static int contactId;
        internal static string contactName;
        internal static string contactEmail;
        internal static string contactAddress;
        internal static string contactCompany;
    
        PhonesRepository phonesRepository = new PhonesRepository("phones.txt");
        ContactsRepository contactsRepository = new ContactsRepository("contacts.txt");        

        public FormViewAllContacts()
        {
            InitializeComponent();

            RefreshItems();            
        }        

        private void FormViewAllContacts_Load(object sender, EventArgs e)
        {
            this.dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dataGridViewItems.Columns[0].Visible = false;
            this.dataGridViewItems.Columns[1].Visible = false;

            this.dataGridViewItems.Columns[2].HeaderText = "Name";
            this.dataGridViewItems.Columns[3].HeaderText = "email";
            this.dataGridViewItems.Columns[4].HeaderText = "Address";
            this.dataGridViewItems.Columns[5].HeaderText = "Company";

            this.dataGridViewItems.Columns[2].Width = 120;
            this.dataGridViewItems.Columns[3].Width = 157;
            this.dataGridViewItems.Columns[4].Width = 150;


            foreach (Contact contact in contactsRepository.GetAll(AuthenticationService.LoggedUser.Id))
            {
                if (AuthenticationService.LoggedUser.Id == contact.ParentUserId)
                {
                    this.dataGridViewSubItems.Columns[0].Visible = false;
                    this.dataGridViewSubItems.Columns[1].Visible = false;

                    this.dataGridViewSubItems.Columns[2].HeaderText = "Phones";

                    this.dataGridViewSubItems.Columns[2].Width = 137;
                }
            }            
        }                  

        private void RefreshItems()
        {                        
            List<Contact> contacts = contactsRepository.GetAll(AuthenticationService.LoggedUser.Id);            
            this.dataGridViewItems.DataSource = contacts;           
        }

        private void RefreshSubItems()
        {            
            int parentContactId = Convert.ToInt32(this.dataGridViewItems.CurrentRow.Cells[0].Value);
            List<Phone> phones = phonesRepository.GetAll(parentContactId);
            this.dataGridViewSubItems.DataSource = phones;
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            FormViewAllContacts.ActiveForm.Close();
            FormNewContact formNewContact = new FormNewContact();
            formNewContact.ShowDialog();
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewItems.Rows.Count == 0)
            {
                MessageBox.Show("No contacts to delete", "No saved contacts",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                contactId = Convert.ToInt32(this.dataGridViewItems.CurrentRow.Cells[0].Value);
                contactName = this.dataGridViewItems.CurrentRow.Cells[2].Value.ToString();
                contactEmail = this.dataGridViewItems.CurrentRow.Cells[3].Value.ToString();
                contactAddress = this.dataGridViewItems.CurrentRow.Cells[4].Value.ToString();
                contactCompany = this.dataGridViewItems.CurrentRow.Cells[5].Value.ToString();

                FormViewAllContacts.ActiveForm.Close();
                FormEditContact formEditContact = new FormEditContact();
                formEditContact.ShowDialog();
            }
        }     

        private void buttonDeleteContact_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewItems.Rows.Count == 0)
            {
                MessageBox.Show("No contacts to delete", "No saved contacts",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int contactId = Convert.ToInt32(this.dataGridViewItems.CurrentRow.Cells[0].Value);
                Contact contact = contactsRepository.GetById(contactId);
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete " +
                    contact.FullName.ToString() + "?",
                    "Delete contact",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    contactsRepository.Delete(contact);
                    MessageBox.Show("Contact deleted successfully");
                    RefreshItems();
                }  
            }                      
        }               

        private void buttonAddPhone_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewItems.Rows.Count == 0)
            {
                MessageBox.Show("No contacts to add phone", "No contacts to add phone",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            parentId = Convert.ToInt32(this.dataGridViewItems.CurrentRow.Cells[0].Value);
            
            FormViewAllContacts.ActiveForm.Close();
            FormAddPhone formAddPhone = new FormAddPhone();
            formAddPhone.ShowDialog();
        }

        private void buttonEditPhone_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewSubItems.Rows.Count == 0)
            {
                MessageBox.Show("No phones to edit", "No saved phones",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                phoneId = Convert.ToInt32(this.dataGridViewSubItems.CurrentRow.Cells[0].Value);
                parentId = Convert.ToInt32(this.dataGridViewItems.CurrentRow.Cells[0].Value);
                phoneNumber = this.dataGridViewSubItems.CurrentRow.Cells[2].Value.ToString();

                FormViewAllContacts.ActiveForm.Close();
                FormEditPhone formEditPhone = new FormEditPhone();
                formEditPhone.ShowDialog();
            }            
        }

        private void buttonDeletePhone_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewSubItems.Rows.Count == 0)
            {
                MessageBox.Show("No phones to delete", "No saved phones",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int phoneId = Convert.ToInt32(this.dataGridViewSubItems.CurrentRow.Cells[0].Value);
                Phone phone = phonesRepository.GetById(phoneId);

                int contactId = Convert.ToInt32(this.dataGridViewItems.CurrentRow.Cells[0].Value);
                Contact contact = contactsRepository.GetById(contactId);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete " +
                    contact.FullName.ToString() + "'s phone " + phone.PhoneNumber.ToString() + "?",
                    "Delete phone",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    phonesRepository.Delete(phone);
                    MessageBox.Show("Phone deleted successfully");
                    RefreshItems();
                } 
            }            
        }

        private void dataGridViewItems_SelectionChanged(object sender, EventArgs e)
        {
            RefreshSubItems();
        }
    }
}
