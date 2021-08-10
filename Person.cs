using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlamningsuppgift2_L0002B_annkov_0
{
    public class Seller
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string District { get; set; }
        public int Sales { get; set; }

        /// <summary>
        /// return all fields as a string
        /// </summary>
        /// <returns>string containing Seller Name Id District and Sales amount</returns>
        public string GetInfo()
        {
            string sellerInfo = $"{Name} {Id} {District} {Sales}";
            return sellerInfo;
        }
    }
}
