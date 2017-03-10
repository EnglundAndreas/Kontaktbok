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
    class Contact
    {
        /// <summary>
        /// Egenskaper för kontaktklassen. Klassens egenskaper kan nås publikt (get), men de kan endast ändras (set) privat inom klassen.
        /// </summary>
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }

        /// <summary>
        /// Konstruktor som tar emot användarinput och sparar input som Contactklassens egenskaper.
        /// </summary>
        /// <param name="InpFirstName"></param>
        /// <param name="InpLastName"></param>
        /// <param name="InpPhoneNumber"></param>
        public Contact(string InpFirstName, string InpLastName, string InpPhoneNumber)
        {
            this.FirstName = InpFirstName;
            this.LastName = InpLastName;
            this.PhoneNumber = InpPhoneNumber;
        }
        /// <summary>
        /// Definerar om beteendet för ToString() metoden från baseklassen 'Object'.
        /// </summary>
        /// <returns>Egenskaperna för kontakten med struktur för hur den ska visas.</returns>
        public override string ToString()
        {
            return this.LastName + ", " + this.FirstName + ", " + this.PhoneNumber;
        }
    }
}
