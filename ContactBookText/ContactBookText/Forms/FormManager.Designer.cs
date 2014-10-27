namespace ContactBookText.Forms
{
    partial class FormManager
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
            this.buttonContacts = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonContacts
            // 
            this.buttonContacts.BackgroundImage = global::ContactBookText.Properties.Resources.contacts;
            this.buttonContacts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonContacts.FlatAppearance.BorderSize = 0;
            this.buttonContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContacts.ForeColor = System.Drawing.Color.White;
            this.buttonContacts.Location = new System.Drawing.Point(69, 58);
            this.buttonContacts.Name = "buttonContacts";
            this.buttonContacts.Size = new System.Drawing.Size(120, 120);
            this.buttonContacts.TabIndex = 1;
            this.buttonContacts.Text = "Contacts";
            this.buttonContacts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonContacts.UseVisualStyleBackColor = true;
            this.buttonContacts.Click += new System.EventHandler(this.buttonContacts_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackgroundImage = global::ContactBookText.Properties.Resources.Users;
            this.buttonUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.Location = new System.Drawing.Point(248, 58);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(120, 120);
            this.buttonUsers.TabIndex = 2;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 248);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonContacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonContacts;
        private System.Windows.Forms.Button buttonUsers;
    }
}