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

        // clears all fields on button click
        private void clear_button_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        // sets text boxes and result label too empty strings
        private void clearAllFields()
        {
            this.name_tb.Text = String.Empty;
            this.lastName_tb.Text = String.Empty;
            this.id_tb.Text = String.Empty;
            this.result_l.Text = String.Empty;
        }


        // veryfy button creates a new person
        // validates Id and innput
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

        // sets the message in result label according to whether the id is valid
        private void verifyId()
        {
            if (newPerson.IsIdValid())
            {
                message = newPerson.GetInfo();
            } else
            {
                message = "Personnummer felaktigt, försök igen!";
                //clearAllFields();
            }
            this.result_l.Text = message;
        }

        
        //checks input for text boxes.  names contain no numbers. 
        private bool InputValid()
        {
            if (String.IsNullOrEmpty(this.lastName_tb.Text)) return false;
            if (this.lastName_tb.Text.Any(char.IsDigit)) return false;
            if (String.IsNullOrEmpty(this.id_tb.Text)) return false;
            if (String.IsNullOrEmpty(this.name_tb.Text)) return false;
            if (this.name_tb.Text.Any(char.IsDigit)) return false;

            return true;
        }

        //checks id all text boxes are not null,
        private bool hasInput()
        {
            if (!String.IsNullOrEmpty(this.lastName_tb.Text)) return true;
            if (!String.IsNullOrEmpty(this.id_tb.Text)) return true;
            if (!String.IsNullOrEmpty(this.name_tb.Text)) return true;
            return false;
        }
    }
}
