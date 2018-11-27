using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    public class CustomerList
    {//Declarations 
        public int count;
        public Customer[] cct = new Customer[50];
        public CustomerList()
        {
        }
        public void add(Customer s)
        {//add customer method
            cct[count] = s;
            count++;
        }
        public void delsec(Customer s)
        {//delete customer method
            for (int i = 0; i < cct.Length; i++)
            {
                if (s.getcustid() == cct[i].getcustid())
                {
                    cct[count] = cct[count - 1];
                }
            }
            count--;
        }
        public void display()
        {//display method
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("--------------------------");
                cct[i].display();
            }
        }

    }
}
