using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAcc
{
    public partial class CreateAccount : Form
    {//Declarations
        Customer c1;
        public CreateAccount()
        {
            InitializeComponent();
        }

        public CreateAccount(Customer cc1)
        {//Constructor  setting textbox
            InitializeComponent();
            c1 = cc1;
            textBoxid.Text = c1.getcustid();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//Create new account button
            //checking for empty textboxs
            if (textBoxid.Text.Equals("") || textBoxAcct.Text.Equals("") || ComboBoxType.Text.Equals("") || textBoxBal.Text.Equals(""))
            {
                MessageBox.Show("Please make sure all fields are filled out with the correct information");
            }
            else
            {
                //set properties and insert 
                Account actnew = new Account();
                actnew.setcid(textBoxid.Text);
                actnew.setAccno(textBoxAcct.Text);
                actnew.setAccty(ComboBoxType.Text);
                actnew.setBal(Double.Parse(textBoxBal.Text));
                actnew.display();
                actnew.InsertDB();
                this.Hide();
                MessageBox.Show("New Account Created Successfully");

            }
        }

        private void custidlb_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcctNumberlb_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Typelb_Click(object sender, EventArgs e)
        {

        }
    }
}
