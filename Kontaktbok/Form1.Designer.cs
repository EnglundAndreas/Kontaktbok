namespace Kontaktbok
{
    partial class Form1
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
            this.txtNewContact = new System.Windows.Forms.TextBox();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.chkIsSecret = new System.Windows.Forms.CheckBox();
            this.Kontaktbok = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewContact
            // 
            this.txtNewContact.Location = new System.Drawing.Point(36, 51);
            this.txtNewContact.Name = "txtNewContact";
            this.txtNewContact.Size = new System.Drawing.Size(268, 20);
            this.txtNewContact.TabIndex = 0;
            this.txtNewContact.Text = "Förnamn, Efternamn, Telefonnummer";
            this.txtNewContact.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveContact.Location = new System.Drawing.Point(322, 47);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(52, 26);
            this.btnSaveContact.TabIndex = 1;
            this.btnSaveContact.Text = "Save";
            this.btnSaveContact.UseVisualStyleBackColor = true;
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(36, 122);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(268, 160);
            this.lstContacts.Sorted = true;
            this.lstContacts.TabIndex = 2;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(322, 122);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(164, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Text = "Förnamn";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(322, 160);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(164, 20);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.Text = "Efternamn";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(322, 198);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(164, 20);
            this.txtPhoneNumber.TabIndex = 5;
            this.txtPhoneNumber.Text = "Telefonnummer";
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Enabled = false;
            this.btnDeleteContact.Location = new System.Drawing.Point(322, 259);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteContact.TabIndex = 6;
            this.btnDeleteContact.Text = "Delete";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // chkIsSecret
            // 
            this.chkIsSecret.AutoSize = true;
            this.chkIsSecret.Location = new System.Drawing.Point(36, 77);
            this.chkIsSecret.Name = "chkIsSecret";
            this.chkIsSecret.Size = new System.Drawing.Size(88, 17);
            this.chkIsSecret.TabIndex = 7;
            this.chkIsSecret.Text = "Hide Number";
            this.chkIsSecret.UseVisualStyleBackColor = true;
            this.chkIsSecret.CheckedChanged += new System.EventHandler(this.chkIsSecret_CheckedChanged);
            // 
            // Kontaktbok
            // 
            this.Kontaktbok.AutoSize = true;
            this.Kontaktbok.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kontaktbok.Location = new System.Drawing.Point(33, 101);
            this.Kontaktbok.Name = "Kontaktbok";
            this.Kontaktbok.Size = new System.Drawing.Size(80, 18);
            this.Kontaktbok.TabIndex = 8;
            this.Kontaktbok.Text = "All contacts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contact book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contact details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kontaktbok);
            this.Controls.Add(this.chkIsSecret);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.btnSaveContact);
            this.Controls.Add(this.txtNewContact);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewContact;
        private System.Windows.Forms.Button btnSaveContact;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.CheckBox chkIsSecret;
        private System.Windows.Forms.Label Kontaktbok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

