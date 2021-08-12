using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlamningsuppgift3_L0002B_annkov_0
{
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        private string NumericId { get; set; }

        string formater = "Namn:\t\t{0}\nEfternamn:\t\t{1}\nPersonnummer:\t\t{2}\nKön:\t\t{3}";

        /// <summary>
        /// return all fields as a string
        /// </summary>
        /// <returns>string containing Name LastName Id and Gender</returns>
        public string GetInfo()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(formater, Name, LastName, Id, Gender);
            string result = builder.ToString();
            return result;
        }


        /// <summary>
        /// multiplies every other digit in personal number by 2 starting with the first one.Sum all the digits.If the digit is evenly divided by 2 – return true
        /// </summary>
        /// returns true if control sup is evenly dividable by 10
        public bool isIdValid()
        {
            FormatId();
            assignGender();
            int controlDigit = getControlDigit();

            List<int> digitsInId = new List<int>();

            //fill a list with integers that correspond to each characteri n Id
            foreach(char character in NumericId)
            {
                int bar;
                if (!int.TryParse(character.ToString(), out bar))
                {
                    Console.WriteLine("Cannot parse " + character + "to" + bar);
                }
                digitsInId.Add(int.Parse(character.ToString()));
            }

            //remove control digit from sequence
            //digitsInId.RemoveAt(9);

            

            //sum of all digits in an id
            int sum = 0;

            //multiply every other digitin digitsInId by 2, startion with 0
            for (int i = 0; i < 10; i++)
            {
                if(i == 0 || i%2 == 0)
                {
                    digitsInId[i] = digitsInId[i] * 2;
                }
            }

            //sum of all Numbers. Numbers that consist of 2 digits are summed up as two numbers.
            foreach(int digit in digitsInId)
            {
                if (digit > 9)
                {
                    sum = sum + (digit / 10) + (digit % 10);
                } else
                {
                    sum = sum + digit;
                }
            }

            if (sum%10 == 0) { return true; }
            else { return false; }
        

        /// <summary>
        /// 
        /// </summary>
        internal void FormatId()
        {
            Id.Trim();

            //remove first two chars if the string starts with "19"
            if (Id.Substring(0,1).Equals("19"))
            {
                Id.Remove(0, 2);
            }
            //remove a "-" if used
            var str = Id;
            str = new string((from c in str
                              where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
                              select c
                   ).ToArray());
            NumericId = str;
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
            string genderChar = NumericId.Substring(8);
            int.TryParse(genderChar, out genderDigit);
            
            return genderDigit;
        }
        /// <summary>
        /// Extracts the last character from the Id and returns it as a digit
        /// </summary>
        internal int getControlDigit()
        {
            int controlDigit = -5;
            string genderChar = NumericId.Substring(9);
            int.TryParse(genderChar, out controlDigit);

            return controlDigit;
        }
    }
}
