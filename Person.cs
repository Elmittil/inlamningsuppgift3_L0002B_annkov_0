using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlamningsuppgift2_L0002B_annkov_0
{
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        string formater = "Namn:\t{0}\nEfternamn:\t{1}\nPersonnummer:\t{2}\nKön:\t{3}";

        /// <summary>
        /// return all fields as a string
        /// </summary>
        /// <returns>string containing Name LastName Id and Gender</returns>
        public string GetInfo()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(formater, Name, LastName, Id, Gender);
            return builder.ToString();
        }

        internal bool isIdValid()
        {

            return false;
        }

        /// <summary>
        /// Assigns a value to Gender based on the birth number values
        /// </summary>
        internal void assignGender()
        {
            int genderDigit = getGenderDigit(); 
            if (genderDigit % 2 == 0)
            { Gender = "Kvinna"; }
            else { Gender = "Man"; }
        }

        /// <summary>
        /// Extracts the third character from the Id's birth number and returns it as a digit
        /// </summary>
        internal int getGenderDigit()
        {
            int genderDigit = 0;
            Id.Trim();
            string genderChar = Id.Substring(9);
            int.TryParse(genderChar, out genderDigit);
            
            return genderDigit;
        }
    }
}
