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
        Customer ac = new Customer();
        

        public admindisplay()
        {
            InitializeComponent();


            //Setting properties of the list view
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
    }
}
