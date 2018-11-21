using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
   
    class AccountList
    {
        int count;
       Account[] act = new Account[10];
        public AccountList()
        {

        }
        public void add(Account s)
        {
           act[count] = s;
            count++;
        }
        public void delsec(Account s)

        {

            for (int i = 0; i < act.Length; i++)
            {

                if (s.getAccno() == act[i].getAccno())
                {
                    act[count] = act[count - 1];
                }
            }
            count--;
        }
        public void display()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("--------------------------");
                act[i].display();
            }
        }
    }
}
