using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataAccess.Entity;
using DataAccess.Repository;

namespace ContactBookText.Forms.ContactsManager
{
    public partial class FormEditPhone : Form
    {
        public FormEditPhone()
        {
            InitializeComponent();
        }

        private void FormEditPhone_Load(object sender, EventArgs e)
        {
            this.textBoxPhone.Focus();
            this.textBoxPhone.Text = FormViewAllContacts.phoneNumber;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.textBoxPhone.Text == String.Empty)
            {
                MessageBox.Show("No phone inserted",
                    "No input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit this phone",
                    "Edit confirmation",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {                    
                    PhonesRepository phonesRepository = new PhonesRepository("phones.txt");
                    Phone phone = new Phone();
                    phone.Id = FormViewAllContacts.phoneId;
                    phone.ParentContactId = FormViewAllContacts.parentId;
                    phone.PhoneNumber = this.textBoxPhone.Text;
                    phonesRepository.Save(phone);
                    MessageBox.Show("Phone edited successfully");

                    FormAddPhone.ActiveForm.Close();
                    FormViewAllContacts formViewAll = new FormViewAllContacts();
                    formViewAll.Show();
                }
            }            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormEditPhone.ActiveForm.Close();
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
