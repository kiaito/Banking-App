using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    public class CustomerList
    {
        public int count;
        public Customer[] cct = new Customer[50];
        public CustomerList()
        {
        }
        public void add(Customer s)
        {
            cct[count] = s;
            count++;
        }
        public void delsec(Customer s)
        {
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
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("--------------------------");
                cct[i].display();
            }
        }

    }
}
