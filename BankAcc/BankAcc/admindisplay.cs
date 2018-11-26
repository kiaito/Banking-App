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
    public partial class admindisplay : Form
    {
        Customer ac;
        Account aact;

        public admindisplay()
        {
            InitializeComponent();


            //Setting properties of the list view for all accounts
            listViewAcc.View = View.Details;
            listViewAcc.GridLines = true;
            listViewAcc.CheckBoxes = false;

            //setting coloums and headers for all accounts
            //listViewer.Columns.Add("Box ", 50);
            listViewAcc.Columns.Add("Account Number", 120);
            listViewAcc.Columns.Add("Type", 100);
            listViewAcc.Columns.Add("Balance", 120);

            //Setting properties of the list view for all customers
            listViewAcc.Hide();
            listView.Show();
            listView.View = View.Details;
            listView.GridLines = true;
            listView.CheckBoxes = false;

            //setting coloums and headers
            //listViewer.Columns.Add("Box ", 50);
            listView.Columns.Add("Customer ID", 70);
            listView.Columns.Add("First Name", 100);
            listView.Columns.Add("Last Name", 120);
            listView.Columns.Add("Address", 100);
            listView.Columns.Add("Email", 120);

            //make array for listview
            string[] item = new string[5];
            //declare listview items to fill the items
            ListViewItem lview;
            ac = new Customer();
            ac.GetCustomerlist();
            int count = ac.clists.count;

            for (int i = 0; i < count; i++)
            {
                //adding items
                item[0] = ac.clists.cct[i].getcustid();
                item[1] = ac.clists.cct[i].getcustfn();
                item[2] = ac.clists.cct[i].getcustln();
                item[3] = ac.clists.cct[i].getcustadd();
                item[4] = ac.clists.cct[i].getcustem();

                //placing in list view
                lview = new ListViewItem(item);
                listView.Items.Add(lview);
               // ac.clists.cct[i].display();
            }


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {//View all account button
            listView.Hide();
            listViewAcc.Show();
            listViewAcc.Items.Clear();
            Account aact;
           

            //make array for listview
            string[] item = new string[3];
            aact = new Account();
            aact.GetAllAccountlist();
            
            //declare listview items to fill the items
            ListViewItem lview;
            int count = aact.alist.count;

            for (int i = 0; i < count; i++)
            {
                //adding items
                item[0] = aact.alist.act[i].getAccno();
                item[1] = aact.alist.act[i].getAccty();
                item[2] = aact.alist.act[i].getBal().ToString();

                //placing in list view
                lview = new ListViewItem(item);
                listViewAcc.Items.Add(lview);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {//view all customers button

            listViewAcc.Hide();
            listView.Items.Clear();
            listView.Show();

            //make array for listview
            string[] item = new string[5];
            //declare listview items to fill the items
            ListViewItem lview;
            ac = new Customer();
            ac.GetCustomerlist();
            int count = ac.clists.count;
            for (int i = 0; i < count; i++)
            {
                //adding items
                item[0] = ac.clists.cct[i].getcustid();
                item[1] = ac.clists.cct[i].getcustfn();
                item[2] = ac.clists.cct[i].getcustln();
                item[3] = ac.clists.cct[i].getcustadd();
                item[4] = ac.clists.cct[i].getcustem();

                //placing in list view
                lview = new ListViewItem(item);
                listView.Items.Add(lview);
                // ac.clists.cct[i].display();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            ca.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {//Delete accounts button 
            
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            CreateCustomer aac = new CreateCustomer();
            aac.Show();
            
        }
    }
}
