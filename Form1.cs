using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inlamningsuppgift2_L0002B_annkov_0
{
    public partial class Form1 : Form
    {
        Person newPerson;
        string formater = "{0,-30}\t{1,-15}\t{2,-15}\t{3,-5}\n";
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

            StringBuilder builder = new StringBuilder();

            builder.AppendFormat(formater, "Namn", "Personnr", "Distrikt", "Antal");
          
                builder.Append("");


            MessageBox.Show(builder.ToString());

        }

        private void verifyId()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendFormat(formater, newPerson.Name, newPerson.LastName, newPerson.Id, newPerson.Gender);

            //figure out how to get gender. 
            MessageBox.Show(builder.ToString());
            if (newPerson.verifyId())
            {
                message = 
            }  
            

        }

        
        //check if names contain numbers!!!
        //check if id contains letters !!!
        private bool InputValid()
        {
            if (String.IsNullOrEmpty(this.lastName_tb.Text)) return false;
            if (String.IsNullOrEmpty(this.id_tb.Text)) return false;
            if (String.IsNullOrEmpty(this.name_tb.Text)) return false;
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
