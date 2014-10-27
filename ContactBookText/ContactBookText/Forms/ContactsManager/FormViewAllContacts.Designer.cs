namespace ContactBookText.Forms.ContactsManager
{
    partial class FormViewAllContacts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.buttonDeleteContact = new System.Windows.Forms.Button();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.buttonEditContact = new System.Windows.Forms.Button();
            this.dataGridViewSubItems = new System.Windows.Forms.DataGridView();
            this.labelContacts = new System.Windows.Forms.Label();
            this.labelPhones = new System.Windows.Forms.Label();
            this.buttonAddPhone = new System.Windows.Forms.Button();
            this.buttonEditPhone = new System.Windows.Forms.Button();
            this.buttonDeletePhone = new System.Windows.Forms.Button();
            this.groupBoxContactManager = new System.Windows.Forms.GroupBox();
            this.groupBoxPhoneManager = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubItems)).BeginInit();
            this.groupBoxContactManager.SuspendLayout();
            this.groupBoxPhoneManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewItems.MultiSelect = false;
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.Size = new System.Drawing.Size(570, 306);
            this.dataGridViewItems.TabIndex = 0;
            this.dataGridViewItems.SelectionChanged += new System.EventHandler(this.dataGridViewItems_SelectionChanged);
            // 
            // buttonDeleteContact
            // 
            this.buttonDeleteContact.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteContact.FlatAppearance.BorderSize = 0;
            this.buttonDeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteContact.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteContact.Location = new System.Drawing.Point(254, 43);
            this.buttonDeleteContact.Name = "buttonDeleteContact";
            this.buttonDeleteContact.Size = new System.Drawing.Size(100, 26);
            this.buttonDeleteContact.TabIndex = 5;
            this.buttonDeleteContact.Text = "Delete contact";
            this.buttonDeleteContact.UseVisualStyleBackColor = false;
            this.buttonDeleteContact.Click += new System.EventHandler(this.buttonDeleteContact_Click);
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddContact.FlatAppearance.BorderSize = 0;
            this.buttonAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddContact.ForeColor = System.Drawing.Color.White;
            this.buttonAddContact.Location = new System.Drawing.Point(15, 43);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(100, 26);
            this.buttonAddContact.TabIndex = 3;
            this.buttonAddContact.Text = "New contact";
            this.buttonAddContact.UseVisualStyleBackColor = false;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // buttonEditContact
            // 
            this.buttonEditContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEditContact.FlatAppearance.BorderSize = 0;
            this.buttonEditContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditContact.ForeColor = System.Drawing.Color.White;
            this.buttonEditContact.Location = new System.Drawing.Point(135, 43);
            this.buttonEditContact.Name = "buttonEditContact";
            this.buttonEditContact.Size = new System.Drawing.Size(100, 26);
            this.buttonEditContact.TabIndex = 4;
            this.buttonEditContact.Text = "Edit contact";
            this.buttonEditContact.UseVisualStyleBackColor = false;
            this.buttonEditContact.Click += new System.EventHandler(this.buttonEditContact_Click);
            // 
            // dataGridViewSubItems
            // 
            this.dataGridViewSubItems.AllowUserToAddRows = false;
            this.dataGridViewSubItems.AllowUserToDeleteRows = false;
            this.dataGridViewSubItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSubItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubItems.Location = new System.Drawing.Point(588, 62);
            this.dataGridViewSubItems.MultiSelect = false;
            this.dataGridViewSubItems.Name = "dataGridViewSubItems";
            this.dataGridViewSubItems.ReadOnly = true;
            this.dataGridViewSubItems.Size = new System.Drawing.Size(180, 306);
            this.dataGridViewSubItems.TabIndex = 1;
            // 
            // labelContacts
            // 
            this.labelContacts.AutoSize = true;
            this.labelContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContacts.Location = new System.Drawing.Point(263, 23);
            this.labelContacts.Name = "labelContacts";
            this.labelContacts.Size = new System.Drawing.Size(68, 18);
            this.labelContacts.TabIndex = 9;
            this.labelContacts.Text = "Contacts";
            // 
            // labelPhones
            // 
            this.labelPhones.AutoSize = true;
            this.labelPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhones.Location = new System.Drawing.Point(649, 23);
            this.labelPhones.Name = "labelPhones";
            this.labelPhones.Size = new System.Drawing.Size(59, 18);
            this.labelPhones.TabIndex = 10;
            this.labelPhones.Text = "Phones";
            // 
            // buttonAddPhone
            // 
            this.buttonAddPhone.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAddPhone.FlatAppearance.BorderSize = 0;
            this.buttonAddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPhone.ForeColor = System.Drawing.Color.White;
            this.buttonAddPhone.Location = new System.Drawing.Point(16, 43);
            this.buttonAddPhone.Name = "buttonAddPhone";
            this.buttonAddPhone.Size = new System.Drawing.Size(100, 26);
            this.buttonAddPhone.TabIndex = 7;
            this.buttonAddPhone.Text = "Add phone";
            this.buttonAddPhone.UseVisualStyleBackColor = false;
            this.buttonAddPhone.Click += new System.EventHandler(this.buttonAddPhone_Click);
            // 
            // buttonEditPhone
            // 
            this.buttonEditPhone.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonEditPhone.FlatAppearance.BorderSize = 0;
            this.buttonEditPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditPhone.ForeColor = System.Drawing.Color.White;
            this.buttonEditPhone.Location = new System.Drawing.Point(136, 43);
            this.buttonEditPhone.Name = "buttonEditPhone";
            this.buttonEditPhone.Size = new System.Drawing.Size(100, 26);
            this.buttonEditPhone.TabIndex = 8;
            this.buttonEditPhone.Text = "Edit phone";
            this.buttonEditPhone.UseVisualStyleBackColor = false;
            this.buttonEditPhone.Click += new System.EventHandler(this.buttonEditPhone_Click);
            // 
            // buttonDeletePhone
            // 
            this.buttonDeletePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDeletePhone.FlatAppearance.BorderSize = 0;
            this.buttonDeletePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePhone.ForeColor = System.Drawing.Color.White;
            this.buttonDeletePhone.Location = new System.Drawing.Point(255, 43);
            this.buttonDeletePhone.Name = "buttonDeletePhone";
            this.buttonDeletePhone.Size = new System.Drawing.Size(100, 26);
            this.buttonDeletePhone.TabIndex = 9;
            this.buttonDeletePhone.Text = "Delete phone";
            this.buttonDeletePhone.UseVisualStyleBackColor = false;
            this.buttonDeletePhone.Click += new System.EventHandler(this.buttonDeletePhone_Click);
            // 
            // groupBoxContactManager
            // 
            this.groupBoxContactManager.Controls.Add(this.buttonDeleteContact);
            this.groupBoxContactManager.Controls.Add(this.buttonAddContact);
            this.groupBoxContactManager.Controls.Add(this.buttonEditContact);
            this.groupBoxContactManager.Location = new System.Drawing.Point(12, 405);
            this.groupBoxContactManager.Name = "groupBoxContactManager";
            this.groupBoxContactManager.Size = new System.Drawing.Size(369, 100);
            this.groupBoxContactManager.TabIndex = 2;
            this.groupBoxContactManager.TabStop = false;
            this.groupBoxContactManager.Text = "Contact manager";
            // 
            // groupBoxPhoneManager
            // 
            this.groupBoxPhoneManager.Controls.Add(this.buttonAddPhone);
            this.groupBoxPhoneManager.Controls.Add(this.buttonEditPhone);
            this.groupBoxPhoneManager.Controls.Add(this.buttonDeletePhone);
            this.groupBoxPhoneManager.Location = new System.Drawing.Point(399, 405);
            this.groupBoxPhoneManager.Name = "groupBoxPhoneManager";
            this.groupBoxPhoneManager.Size = new System.Drawing.Size(369, 100);
            this.groupBoxPhoneManager.TabIndex = 6;
            this.groupBoxPhoneManager.TabStop = false;
            this.groupBoxPhoneManager.Text = "Phone manager";
            // 
            // FormViewAllContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 538);
            this.Controls.Add(this.groupBoxPhoneManager);
            this.Controls.Add(this.groupBoxContactManager);
            this.Controls.Add(this.labelPhones);
            this.Controls.Add(this.labelContacts);
            this.Controls.Add(this.dataGridViewSubItems);
            this.Controls.Add(this.dataGridViewItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(460, 0);
            this.Name = "FormViewAllContacts";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormViewAllContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubItems)).EndInit();
            this.groupBoxContactManager.ResumeLayout(false);
            this.groupBoxPhoneManager.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button buttonDeleteContact;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.Button buttonEditContact;
        private System.Windows.Forms.DataGridView dataGridViewSubItems;
        private System.Windows.Forms.Label labelContacts;
        private System.Windows.Forms.Label labelPhones;
        private System.Windows.Forms.Button buttonAddPhone;
        private System.Windows.Forms.Button buttonEditPhone;
        private System.Windows.Forms.Button buttonDeletePhone;
        private System.Windows.Forms.GroupBox groupBoxContactManager;
        private System.Windows.Forms.GroupBox groupBoxPhoneManager;

    }
}