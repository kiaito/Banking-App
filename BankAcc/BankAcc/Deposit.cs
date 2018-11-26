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
    public partial class Deposit : Form
    {
        //Customer ca1;
        double obal;
        double nbal;
        double tbal;

        public Deposit()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {

            try
            {//accessing account table to retrieve balance
                Account a1 = new Account();
                a1.SelectDB(textBoxAcc.Text);
                obal = a1.getBal();
                tbal = double.Parse(textBoxAm.Text);
           



            if (nbal < 0)//Checking to see if balance is negative 0
            {
                MessageBox.Show("Insufficient Funds");
            }
            else
            {
                nbal = obal + tbal;
                //assigning  new balance to account
                a1.setBal(nbal);
                a1.Upddate();
                MessageBox.Show("Deposit Successful \n Your new balance is "+ nbal);
                this.Hide();
            }
            }
            catch (Exception aa)
            {
                MessageBox.Show("Please enter a Number.");
            }

        }
    }
}
