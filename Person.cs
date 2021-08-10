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

        /// <summary>
        /// return all fields as a string
        /// </summary>
        /// <returns>string containing Seller Name Id District and Sales amount</returns>
        public string GetInfo()
        {
            string sellerInfo = $"{Name} {LastName} {Id}";
            return sellerInfo;
        }
    }
}
