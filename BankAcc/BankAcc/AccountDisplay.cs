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
public partial class AccountDisplay : Form
    {
        string custid;
        Customer aact;
        
      public AccountDisplay()
        {
            InitializeComponent();
        }

        public AccountDisplay(string ac)
            {
            custid = ac;
            aact = new Customer();
            aact.SelectDB(custid);
            string fname = aact.getcustfn();
            Console.WriteLine(fname);
            Console.WriteLine(aact.getcustfn());
            //fullnamelb.Text = aact.getcustfn().ToString() + aact.getcustln().ToString();
            //MessageBox.Show(aact.getcustfn().ToString());
        }

    private void AccountDisplay_Load(object sender, EventArgs e)
        {

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        
    }
}
