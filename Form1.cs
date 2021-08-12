using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inlamningsuppgift3_L0002B_annkov_0
{
    public partial class Form1 : Form
    {
        Person newPerson;
        
        string message;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void clearAllFields()
        {
            this.name_tb.Text = String.Empty;
            this.lastName_tb.Text = String.Empty;
            this.id_tb.Text = String.Empty;
        }

        private void verify_button_Click(object sender, EventArgs e)
        {
            
            if (hasInput())
            {
                if (InputValid())
                {
                    newPerson = new Person()
                    {
                        Name = this.name_tb.Text,
                        Id = this.id_tb.Text,
                        LastName = this.lastName_tb.Text
                    };
                    verifyId();
                }
                else
                {
                    MessageBox.Show("Vänligen kontrollera input");
                    return;
                }
            }

         
        }

        private void verifyId()
        {
            if (newPerson.isIdValid())
            {
                message = newPerson.GetInfo();
            } else
            {
                message = "Personnummer felaktigt, försök igen!";
                //clearAllFields();
            }
            this.result_l.Text = message;
        }

        
        //check if names contain numbers!!!
        //check if id contains letters !!!
        private bool InputValid()
        {
            if (String.IsNullOrEmpty(this.lastName_tb.Text)) return false;
            if (this.lastName_tb.Text.Any(char.IsDigit)) return false;
            if (String.IsNullOrEmpty(this.id_tb.Text)) return false;
            if (String.IsNullOrEmpty(this.name_tb.Text)) return false;
            if (this.name_tb.Text.Any(char.IsDigit)) return false;

            return true;
        }

        private bool hasInput()
        {
            if (!String.IsNullOrEmpty(this.lastName_tb.Text)) return true;
            if (!String.IsNullOrEmpty(this.id_tb.Text)) return true;
            if (!String.IsNullOrEmpty(this.name_tb.Text)) return true;
            return false;
        }
    }
}
