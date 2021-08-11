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

        /// <summary>
        /// return all fields as a string
        /// </summary>
        /// <returns>string containing Seller Name Id District and Sales amount</returns>
        public string GetInfo()
        {
            string sellerInfo = $"{Name} {LastName} {Id}";
            return sellerInfo;
        }

        internal bool isIdValid()
        {

            return false;
        }

        //Assigns a value to Gender based on the birth number values
        internal void assignGender()
        {
            int genderDigit = getGenderDigit(); 
            if (genderDigit % 2 == 0)
            { Gender = "Kvinna"; }
            else { Gender = "Man"; }
        }

        //Extracts the third character from the Id's birth number and returns it as a digit
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
