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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        AccountDisplay ad;
        private void Sumitbtn_Click(object sender, EventArgs e)
        {
            string pw = Passwordtb.Text;
            string cid =  UserNametb.Text;
            string adminu = "admin";
            string adminp = "password";

            if (cid.Equals(adminu) && pw.Equals(adminp))
            {
                Console.WriteLine("Forwarding to admin page");
            }
            else
            {
                try
                {
                    Customer c1 = new Customer();
                    c1.SelectDB(cid);
                    if (c1.getcustid().Equals(cid) && c1.getcustpw().Equals(pw))
                    {

                        Console.WriteLine("forwarding to account display page" + c1.getcustfn());
                        AccountDisplay ad = new AccountDisplay(cid);
                        Form1 aaa = new Form1(cid);
                        aaa.Show();
                        this.Hide();
                       // ad.Show();
                    }
                    else
                    {
                        Console.WriteLine("Wrong username and password");
                    }
                }
                catch(Exception ae)
                {
                    MessageBox.Show(ae.ToString());
                }
            }
            
        }
    }
}
