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
        Customer c1 = new Customer();
        public Login()
        {
            InitializeComponent();
        }
        //AccountDisplay ad;
        private void Sumitbtn_Click(object sender, EventArgs e)
        {//assigning data to var
            string pw = Passwordtb.Text;
            string cid =  UserNametb.Text;
            string adminu = "admin";
            string adminp = "password";

            if (cid.Equals(adminu) && pw.Equals(adminp))//checking password and id for admin
            {
                Console.WriteLine("Forwarding to admin page");
                admindisplay ad = new admindisplay();
                this.Hide();
                ad.Show();
            }
            else
            {
                try
                {                  
                    c1.SelectDB(cid);//checking id and password for customer
                    if (c1.getcustid().Equals(cid) && c1.getcustpw().Equals(pw))
                    {

                        Console.WriteLine("forwarding to account display page" + c1.getcustfn());
                        AccountDisplay ad = new AccountDisplay(c1);
                      // Form1 aaa = new Form1(c1);
                        //aaa.Show();
                        
                        this.Hide();
                       ad.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username and password");
                        //Console.WriteLine("Wrong username and password");
                    }
                }
                catch(Exception ae)
                {
                    MessageBox.Show(ae.ToString());
                }
            }
            
        }

        private void UserNametb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
