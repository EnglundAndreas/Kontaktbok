using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Laboration 3 - Telefonboken
//Andreas Englund
//Version 1.0 2015-11-25

namespace Kontaktbok
{
    class PhoneBook
    {
        //Lista där alla kontakter lagras.
        List<Contact> contacts = new List<Contact>();

        /// <summary>
        /// Metod för att lägga till en kontakt i listan.
        /// </summary>
        /// <param name="CurrentContact"></param>
        public void Add(Contact CurrentContact)
        {
            contacts.Add(CurrentContact);
        }
        /// <summary>
        /// Metod för att ta bort en kontakt i listan.
        /// </summary>
        /// <param name="CurrentContact"></param>
        public void Remove(Contact CurrentContact)
        {
            contacts.Remove(CurrentContact);
        }
        /// <summary>
        /// Metod för att samla/skriva ut kotakterna i listan.
        /// </summary>
        /// <returns>Hela listan med kontakterna.</returns>
        public List<Contact> GetAll()
        {
            return contacts;
        }
    }
}
