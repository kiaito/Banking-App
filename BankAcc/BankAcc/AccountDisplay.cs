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
        //string custid;
        Customer aact;
        //= new Customer();
        string vid = "";
           
        public AccountDisplay()
        {
            InitializeComponent();
        }

            public AccountDisplay(Customer aa)
        { //constructor for taking the object

            InitializeComponent();
            aact = aa;
            vid = aact.getcustid();//for view all accounts button
            //setting textbox info
            Custidtb.Text = aact.getcustid();
            Nametb.Text = aact.getcustfn() + "  " + aact.getcustln();
            Emailtb.Text = aact.getcustem();

            //Making all textboxes and labels disappear
            listViewer.Visible = true;
            Custidlb.Visible = false;
            textBoxcid.Visible = false;
            textBoxFname.Visible = false;
            Fnamelb.Visible = false;
            textBoxLname.Visible = false;
            lastNamelb.Visible = false;
            Addresslb.Visible = false;
            textBoxaddress.Visible = false;
            Email.Visible = false;
            textBoxEmail.Visible = false;
            Passwordlb.Visible = false;
            textBoxPw.Visible = false;
            upDatebtn.Visible = false;
            Depositbtn.Visible = true;
            Withdrawlbtn.Visible = true;

            //Setting properties of the list view
            listViewer.View = View.Details;
            listViewer.GridLines = true;
            listViewer.CheckBoxes = false;

            //setting coloums and headers
            //listViewer.Columns.Add("Box ", 50);
            listViewer.Columns.Add("Account Number", 120);
            listViewer.Columns.Add("Type", 100);
            listViewer.Columns.Add("Balance", 120);

            //make array for listview
            string[] item = new string[3];
            //declare listview items to fill the items
            ListViewItem lview;
            int count = aact.alists.count;

            for (int i = 0; i < count; i++)
            {
                //adding items
                item[0] = aact.alists.act[i].getAccno();
                item[1] = aact.alists.act[i].getAccty();
                item[2] = aact.alists.act[i].getBal().ToString();

                //placing in list view
                lview = new ListViewItem(item);
                listViewer.Items.Add(lview);
            }

        }

      

    private void AccountDisplay_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {//view accounts button

            //hiding all the labels and text boxes for accounts to be displayed
            Custidlb.Visible = false;
            textBoxcid.Visible = false;
            textBoxFname.Visible = false;
            Fnamelb.Visible = false;
            textBoxLname.Visible = false;
            lastNamelb.Visible = false;
            Addresslb.Visible = false;
            textBoxaddress.Visible = false;
            Email.Visible = false;
            textBoxEmail.Visible = false;
            Passwordlb.Visible = false;
            textBoxPw.Visible = false;
            upDatebtn.Visible = false;          
            Depositbtn.Visible = true;
            Withdrawlbtn.Visible = true;
            listViewer.Visible = true;
            listViewer.Items.Clear();

            Customer aad = new Customer();
            aad.SelectDB(vid);

            //make array for listview
            string[] item = new string[3];
            //declare listview items to fill the items
            ListViewItem lview;
            int count = aad.alists.count;

            for (int i = 0; i < count; i++)
            {
                //adding items
                item[0] = aad.alists.act[i].getAccno();
                item[1] = aad.alists.act[i].getAccty();
                item[2] = aad.alists.act[i].getBal().ToString();

                //placing in list view
                lview = new ListViewItem(item);
                listViewer.Items.Add(lview);
            }
            aact = aad;

            //listViewer.Update();
            
        }

        private void fullnamelb_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(aact.getcustfn());
            
            MessageBox.Show(aact.getcustfn());
        }

        private void PersonalInfo_Click(object sender, EventArgs e)
        {
            try
            {
                listViewer.Hide();

                //Putting object data into textboxes
                textBoxPw.Text = aact.getcustpw();
                textBoxFname.Text = aact.getcustfn();
                textBoxLname.Text = aact.getcustln();
                textBoxaddress.Text = aact.getcustadd();
                textBoxEmail.Text = aact.getcustem();
                textBoxcid.Text = aact.getcustid();
            }
            catch(Exception ae)
            {
                Console.WriteLine(ae);
            }

            // making labels and texboxes visible for editing
            Custidlb.Visible = true;
            textBoxcid.Visible = true;
            textBoxFname.Visible = true;
            Fnamelb.Visible = true;
            textBoxLname.Visible = true;
            lastNamelb.Visible = true;
            Addresslb.Visible = true;
            textBoxaddress.Visible = true;
            Email.Visible = true;
            textBoxEmail.Visible = true;
            Passwordlb.Visible = true;
            textBoxPw.Visible = true;
            upDatebtn.Visible = true;
            Depositbtn.Visible = false;
            Withdrawlbtn.Visible = false;
        }

        private void Create_Click(object sender, EventArgs e)
        {//forward to create account page
            CreateAccount ca = new CreateAccount(aact);
            ca.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {//logout 
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void Depositbtn_Click(object sender, EventArgs e)
        {//forward to deposit button 
            Deposit dep = new Deposit();
            dep.Show();
        }

        private void Withdrawlbtn_Click(object sender, EventArgs e)
        {//forward to withdrawl page
            Withdrawl wl = new Withdrawl(aact);
            wl.Show();
        }

        private void upDatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                //setting the object properties to the textboxes
                aact.setcustpw(textBoxPw.Text);
                aact.setcustfn(textBoxFname.Text);
                aact.setcustln(textBoxLname.Text);
                aact.setcustadd(textBoxaddress.Text);
                aact.setcustem(textBoxEmail.Text);
                aact.Upddate();
                MessageBox.Show("Data Update Successful");
                Custidtb.Text = aact.getcustid();
                Nametb.Text = aact.getcustfn() + "  " + aact.getcustln();
                Emailtb.Text = aact.getcustem();

            }
            catch(Exception ae)
            {
                Console.WriteLine(ae);
            }
        }
    }
}
