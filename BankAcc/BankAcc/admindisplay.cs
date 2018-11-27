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
    {//Declaration 
        Customer ac;
        Account aact;
        string selected;

        public admindisplay()
        {//constructor
            InitializeComponent();


            //Setting properties of the list view for all accounts
            listViewAcc.View = View.Details;
            listViewAcc.GridLines = true;
            listViewAcc.CheckBoxes = true;


            //setting coloums and headers for all accounts
            //listViewer.Columns.Add("Box ", 50);
            listViewAcc.Columns.Add("Check", 50);
            listViewAcc.Columns.Add("Account Number", 120);
            listViewAcc.Columns.Add("Type", 100);
            listViewAcc.Columns.Add("Balance", 120);

            //Setting properties of the list view for all customers
            listViewAcc.Hide();
            listView.Show();
            listView.View = View.Details;
            listView.GridLines = true;
            listView.CheckBoxes = true;

            //setting coloums and headers
            //listViewer.Columns.Add("Box ", 50);
            listView.Columns.Add("Check", 50);
            listView.Columns.Add("ID", 60);
            listView.Columns.Add("First Name", 75);
            listView.Columns.Add("Last Name", 75);
            listView.Columns.Add("Address", 100);
            listView.Columns.Add("Email", 120);

            //make array for listview
            string[] item = new string[6];
            //declare listview items to fill the items
            ListViewItem lview;
            ac = new Customer();
            ac.GetCustomerlist();
            int count = ac.clists.count;

            for (int i = 0; i < count; i++)
            {
                //adding items
                item[1] = ac.clists.cct[i].getcustid();
                item[2] = ac.clists.cct[i].getcustfn();
                item[3] = ac.clists.cct[i].getcustln();
                item[4] = ac.clists.cct[i].getcustadd();
                item[5] = ac.clists.cct[i].getcustem();

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
            string[] item = new string[4];
            aact = new Account();
            aact.GetAllAccountlist();
            
            //declare listview items to fill the items
            ListViewItem lview;
            int count = aact.alist.count;

            for (int i = 0; i < count; i++)
            {
                //adding items
                item[1] = aact.alist.act[i].getAccno();
                item[2] = aact.alist.act[i].getAccty();
                item[3] = aact.alist.act[i].getBal().ToString();

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
            string[] item = new string[6];
            //declare listview items to fill the items
            ListViewItem lview;
            ac = new Customer();
            ac.GetCustomerlist();
            int count = ac.clists.count;
            for (int i = 0; i < count; i++)
            {
                //adding items
                item[1] = ac.clists.cct[i].getcustid();
                item[2] = ac.clists.cct[i].getcustfn();
                item[3] = ac.clists.cct[i].getcustln();
                item[4] = ac.clists.cct[i].getcustadd();
                item[5] = ac.clists.cct[i].getcustem();

                //placing in list view
                lview = new ListViewItem(item);
                listView.Items.Add(lview);
                // ac.clists.cct[i].display();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {//forward to create account page
            CreateAccount ca = new CreateAccount();
            ca.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {//Delete accounts button 

            string selectt = listViewAcc.SelectedItems[0].SubItems[1].Text;
            Console.WriteLine(selectt);
            Account cc = new Account();
            cc.SelectDB(selectt);
            cc.DeleteDB();
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {//forward to create customer page
            CreateCustomer aac = new CreateCustomer();
            aac.Show();
            
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {//delete button for customers
          
            string select = listView.SelectedItems[0].SubItems[1].Text;
          
            Console.WriteLine(select);
           

            Customer cc = new Customer();
            cc.SelectDB(select);
            cc.DeleteDB();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
