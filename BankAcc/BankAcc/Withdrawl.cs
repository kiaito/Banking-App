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
  

    public partial class Withdrawl : Form
    {
        Customer cc1;
        double obal;
        double nbal;
        double tbal;

        public Withdrawl()
        {
            InitializeComponent();
        }

        public Withdrawl(Customer c1)
        {
            InitializeComponent();
            cc1 = c1;
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            //accessing account table to retrieve balance
            Account a1 = new Account();
            a1.SelectDB(textboxAcc.Text);
            obal = a1.getBal();
            tbal = double.Parse(textBoxAm.Text);
            nbal = obal - tbal;
            if (nbal < 0)//Checking to see if balance is negative 0
            {
                MessageBox.Show("Insufficient Funds cannot withdrawl that amount");
            }
            else
            {
                
                //assigning  new balance to account
                a1.setBal(nbal);
                a1.Upddate();
                MessageBox.Show("Withdrawl Successful \n Your new balance is "+nbal);
                this.Hide();
            }
           


        }
    }
}
