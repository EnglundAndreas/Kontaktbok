using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Laboration 3 - Telefonboken
//Andreas Englund
//Version 1.0 2015-11-25

namespace Kontaktbok
{
    public partial class Form1 : Form
    {

        PhoneBook book;

        public Form1()
        {
            InitializeComponent();
            book = new PhoneBook();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Rensar listobjektet och uppdaterar med nya kontakter från PhoneBook klassen.
        /// </summary>
        private void UpdateListBox()
        { 
            lstContacts.Items.Clear();
            List<Contact> contacts = book.GetAll();
            lstContacts.Items.AddRange(contacts.ToArray()); //AddRange används för att lägga till en array av kontakter i listobjektet.
            txtNewContact.Clear();  //Tar bort texten från inputrutan.
        }

        //Autogenererad metod som körs när användaren klickar på 'Save' knappen.
        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            string [] input = txtNewContact.Text.Split(',');

            //Om användaren inte angivit korrekt input, visas ett felmeddelande.
            if (input.Length != 3)
                MessageBox.Show("Fel input, kontakten kan inte läggas till.");
            //Annars kollas om 'Hidden Contact' checkboxen är iklickad och då läggs en hemlig kontakt till i PhoneBooklistan och listobjektet uppdateras.
            else if (chkIsSecret.Checked == true)
            {
                SecretContact CurrentContact = new SecretContact(input[0].Trim(), input[1].Trim(), input[2].Trim());
                book.Add(CurrentContact);
                UpdateListBox();
            }
            //I andra fall (normalfall) läggs en vanlig kontakt till i PhoneBooklistan och listobjektet uppdateras.
            else 
            {
                Contact CurrentContact = new Contact(input[0].Trim(), input[1].Trim(), input[2].Trim());
                book.Add(CurrentContact);
                UpdateListBox();

            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Följande metod körs när när användaren trycker på ett objekt i listan. Syftet är att visa kontaktuppgifterna från markerad kontakt i tre textboxar,
        /// samt tillgängligör 'Delete' knappen, så att den inte kan klickas på om en kontakt inte är markerad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContacts.SelectedItem!=null)     //Gör så att koden endast körs om man har något markerat och inte bara klickat på kontaktlistobjektet.
           {
                Contact CurrentContact = (Contact)lstContacts.SelectedItem; //Instansierar ett objekt från klassen Contact. Vilket objekt som instansieras beror på vilken kontakt som markeras.
                txtFirstName.Text = CurrentContact.FirstName;
                txtLastName.Text = CurrentContact.LastName;
                txtPhoneNumber.Text = CurrentContact.PhoneNumber;
                btnDeleteContact.Enabled = true;
            }
        }

        /// <summary>
        /// Följande metod körs när användaren körs när användaren har en kontakt markerad och trycker på 'Delete' knappen. Syftet är att ta bort kontakten från kontaktboken 
        /// och uppdatera listobjeketet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedItem != null)
            {
                book.Remove((Contact)lstContacts.SelectedItem);
                UpdateListBox();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtPhoneNumber.Text = "";
                MessageBox.Show("Kontakten har blivit borttagen.");
                btnDeleteContact.Enabled = false;
            }
        }

        private void chkIsSecret_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
