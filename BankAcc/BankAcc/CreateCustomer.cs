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
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {//Checking if textboxes are empty
            if (textBoxcid.Text.Equals("")|| textBoxPw.Text.Equals("") ||
                textBoxFname.Text.Equals("") || textBoxLname.Text.Equals("")||
                textBoxaddress.Text.Equals("") || textBoxEmail.Text.Equals(""))
            {
                MessageBox.Show("Please make sure all fields are filled out.");
            }
            else
            {
                Customer ac = new Customer();
                ac.setcustid(textBoxcid.Text);
                ac.setcustpw(textBoxPw.Text);
                ac.setcustfn(textBoxFname.Text);
                ac.setcustln(textBoxLname.Text);
                ac.setcustadd(textBoxaddress.Text);
                ac.setcustem(textBoxEmail.Text);
                ac.InsertDB();
                this.Hide();
                MessageBox.Show("New Customer Created!");

            }
        }
    }
}
