
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Customerbtn_Click(object sender, EventArgs e)
        {
            Customer cc1 = new Customer();
            cc1.setcustfn("kevin");
            cc1.setcustln("davis");
            cc1.setcustadd("georgis");
            cc1.setcustem("Williy is the heyu");
            cc1.display();

        }

        private void Accountbtn_Click(object sender, EventArgs e)
        {
            Account aa1 = new Account();
            aa1.setAccno(34544);
            aa1.setAccty("SAV");
            aa1.setBal(6758.67);
            aa1.setcid("987");
            aa1.display();
        }
    }
}
