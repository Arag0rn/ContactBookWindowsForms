using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataAccess.Entity;
using DataAccess.Repository;

namespace ContactBookText.Forms.ContactsManager
{
    public partial class FormAddPhone : Form
    {               
        public FormAddPhone()
        {
            InitializeComponent();
        }

        private void FormAddPhone_Load(object sender, EventArgs e)
        {
            this.textBoxPhone.Focus();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.textBoxPhone.Text == String.Empty)
            {
                MessageBox.Show("No phone inserted", "No input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Phone phone = new Phone();
                PhonesRepository phonesRepository = new PhonesRepository("phones.txt");

                DialogResult result = MessageBox.Show("Are you sure you want to add this phone", "Adding confirmation",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    phone.ParentContactId = FormViewAllContacts.parentId;
                    phone.PhoneNumber = this.textBoxPhone.Text;
                    phonesRepository.Save(phone);
                    MessageBox.Show("Phone added successfully");

                    FormAddPhone.ActiveForm.Close();
                    FormViewAllContacts formViewAllContacts = new FormViewAllContacts();
                    formViewAllContacts.Show();
                }
            }                        
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormAddPhone.ActiveForm.Close();
            FormViewAllContacts formViewAllContacts = new FormViewAllContacts();
            formViewAllContacts.Show();
        }

        private void textBoxPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int phone;
            if (this.textBoxPhone.Text != String.Empty &&
                !Int32.TryParse(this.textBoxPhone.Text, out phone))
            {
                MessageBox.Show("Input digits only!", "Incorrect input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;   
            }
        }               
    }
}
