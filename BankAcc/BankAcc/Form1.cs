
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
    public partial class Form1 : Form
    {
        Customer aas;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Customer ac)
        {
            aas = ac;
            

        }
            private void Customerbtn_Click(object sender, EventArgs e)
            {
                //Customer cc1 = new Customer("5768", "passwordhh","Kevin","Davisfjjff","Goergis","Goodday@gmail.com");
                Customer cc1 = new Customer();
                cc1.SelectDB("3006");
                //cc1.InsertDB();
                //cc1.Upddate();
                //cc1.DeleteDB();
                cc1.display();
                /**
                cc1.setcustfn("kevin");
                cc1.setcustln("davis");
                cc1.setcustadd("georgis");
                cc1.setcustem("Williy is the heyu");
                cc1.display();**/

            }

            private void Accountbtn_Click(object sender, EventArgs e)
            {
                // Account aa1 = new Account("9584747", "custid", "Rothc", 7685.57);
                Account aa1 = new Account();
                aa1.SelectDB("90003");

                //aa1.setAccno("9584747");
                //aa1.setAccty("SAVing");
                //aa1.setBal(6758.67);
                //aa1.setcid("999954");
                // aa1.DeleteDB();

                aa1.display();
            }
        
    }
}
