using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inlamningsuppgift2_L0002B_annkov_0
{
    public partial class Form1 : Form
    {
        List<Seller> sellerHolder;
        string formater = "{0,-30}\t{1,-15}\t{2,-15}\t{3,-5}\n";
        const int salesLevels = 4;
        public Form1()
        {
            InitializeComponent();
            sellerHolder = new List<Seller>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void next_button_Click(object sender, EventArgs e)
        {

            if (InputValid())
            {
                Seller newSeller = SaveNewSellerTemp();
                string message = newSeller.GetInfo() + " är tillagd!";
                this.info_l.Text = message;
                clearAllFields();
            }
            else
            {
                MessageBox.Show("Vänligen kontrollera input");
            }
        }

        private Seller SaveNewSellerTemp()
        {
            Seller newSeller = new Seller()
            {
                Name = this.name_tb.Text,
                Id = this.lastName_tb.Text,
                District = this.id_tb.Text,
                Sales = int.Parse(this.sales_tb.Text)
            };
            sellerHolder.Add(newSeller);
            return newSeller;
        }

        private void clearAllFields()
        {
            this.name_tb.Text = String.Empty;
            this.lastName_tb.Text = String.Empty;
            this.id_tb.Text = String.Empty;
            this.sales_tb.Text = String.Empty;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (hasInput())
            {
                if (InputValid())
                {
                    SaveNewSellerTemp();
                }
                else
                {
                    MessageBox.Show("Vänligen kontrollera input");
                    return;
                }
            }
            TestData();
            sellerHolder.OrderBy(s => s.Sales);

            StringBuilder builder = new StringBuilder();

            builder.AppendFormat(formater, "Namn", "Personnr", "Distrikt", "Antal");
            for (int levels = salesLevels; levels > 0; levels--)
            {
                builder.Append(GetAllSellersInALevelString(this.sellerHolder, levels));
            }

            MessageBox.Show(builder.ToString());

        }

        private string GetAllSellersInALevelString(List<Seller> sellersList, int level)
        {
            StringBuilder builder = new StringBuilder();
            int minSales = GetMinMaxInLevel(level)[0];
            int maxSales = GetMinMaxInLevel(level)[1];
            int counter = 0;
            foreach (Seller seller in sellersList)
            {
                if (seller.Sales >= minSales && seller.Sales <= maxSales)
                {
                    builder.AppendFormat(formater, seller.Name, seller.Id, seller.District, seller.Sales);
                    counter++;
                }
            }

            if (counter > 0)
            {
                builder.Append($"{counter} saljare har uppnat niva {level}\n\n");
            }
            return builder.ToString();
        }

        private int[] GetMinMaxInLevel(int level)
        {
            int min = 0;
            int max = 0;

            switch (level)
            {
                case 1:
                    min = 0;
                    max = 49;
                    break;
                case 2:
                    min = 50;
                    max = 99;
                    break;
                case 3:
                    min = 100;
                    max = 199;
                    break;
                case 4:
                    min = 200;
                    max = int.MaxValue;
                    break;
            }

            int[] result = { min, max };
            return result;
        }

        private bool InputValid()
        {
            int sales;
            if (!int.TryParse(this.sales_tb.Text, out sales)) return false;
            if (String.IsNullOrEmpty(this.lastName_tb.Text)) return false;
            if (String.IsNullOrEmpty(this.id_tb.Text)) return false;
            if (String.IsNullOrEmpty(this.name_tb.Text)) return false;
            return true;
        }

        private bool hasInput()
        {
            if (!String.IsNullOrEmpty(this.sales_tb.Text)) return true;
            if (!String.IsNullOrEmpty(this.lastName_tb.Text)) return true;
            if (!String.IsNullOrEmpty(this.id_tb.Text)) return true;
            if (!String.IsNullOrEmpty(this.name_tb.Text)) return true;
            return false;
        }

        private void TestData()
        {
            Seller one = new Seller()
            {

                Name = "Marilyn Monroe",
                Id = "92879376392",
                District = "Hollywood",
                Sales = 20
            };

            Seller two = new Seller()
            {
                Name = "Mahatma",
                Id = "862693620",
                District = "Bollywoon",
                Sales = 80
            };

            Seller three = new Seller()
            {
                Name = "Darth Vader",
                Id = "92879376392",
                District = "Death Star",
                Sales = 180
            };

            Seller four = new Seller()
            {
                Name = "Sherlock Holmes",
                Id = "82036416",
                District = "22 Baker St",
                Sales = 380
            };

            sellerHolder.Add(three);
            sellerHolder.Add(two);
            sellerHolder.Add(four);
            sellerHolder.Add(one);

        }
    }
}
