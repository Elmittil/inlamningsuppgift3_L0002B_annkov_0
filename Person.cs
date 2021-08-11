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
            //sum of all digits inn a number
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (number / 10 > 0)
            {
                sum = sum + (number % 10);
                number = number / 10;
            }


            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        internal void formatId()
        {
            Id.Trim();

            //remove first two chars if the string starts with "19"
            if (Id.Substring(0,1).Equals("19"))
            {
                Id.Remove(0, 2);
            }
            //remove a "-" if used
            if (Id.Contains("-"))
            {
                Id.Remove(6);
            }
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
            formatId();
            int genderDigit = 0;
            string genderChar = Id.Substring(8);
            int.TryParse(genderChar, out genderDigit);
            
            return genderDigit;
        }
        /// <summary>
        /// Extracts the last character from the Id and returns it as a digit
        /// </summary>
        internal int getControlDigit()
        {
            int controlDigit = -5;
            formatId();
            string genderChar = Id.Substring(9);
            int.TryParse(genderChar, out controlDigit);

            return controlDigit;
        }
    }
}
