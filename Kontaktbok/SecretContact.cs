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
    //Ärver beteende från klassen 'Contact'.
    class SecretContact : Contact
    {
        /// <summary>
        /// Ärver konstruktorn från klassen 'Contact'.
        /// </summary>
        /// <param name="InpFirstName"></param>
        /// <param name="InpLastName"></param>
        /// <param name="InpPhoneNumber"></param>
        public SecretContact (string InpFirstName, string InpLastName, string InpPhoneNumber) : base (InpFirstName, InpLastName, InpPhoneNumber)
        {
        }

        /// <summary>
        /// Definerar om beteendet för ToString() metoden från baseklassen 'Contact'.
        /// </summary>
        /// <returns>Egenskaperna för kontakten med struktur för hur den ska visas, där egenskapen PhoneNumber har blivit utbytt mot strängen "Hidden Number".</returns>
        public override string ToString()
        {
            return this.LastName + ", " + this.FirstName + ", " + "Hidden Number";
        }
    }
}
