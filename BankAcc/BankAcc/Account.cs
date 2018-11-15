using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    class Account
    {
        //Declaration
        int AccNo;
        string Custid;
        string AccTy;
        double Bal;

        //Blank Constructor
        public Account()
        {
            AccNo = 0;
            Custid = "";
            AccTy = "";
            Bal = 0;

        }
        //All args Constructor
        public Account( int an, string cid, string ty, double bl)
        {
            AccNo = an;
            Custid = cid;
            AccTy = ty;
            Bal = bl;
        }
        // Getters and Setters
        public void setAccno(int ac)
        {
            AccNo = ac;
        }
        public int getAccno()
        {
            return AccNo;
        }
        public void setcid(string cc)
        {
            Custid = cc;
        }
        public string getcid()
        {
            return Custid;
        }
        public void setAccty(string at)
        {
            AccTy = at;
        }
            public string getAccty()
        {
            return AccTy;
        }
        public void setBal(double bl)
        {
            Bal = bl;
        }
        public double getBal()
        {
            return Bal;
        }

        // console display method
        public void display()
        {
            Console.WriteLine("The Account number is = "+ getAccno());
            Console.WriteLine("The Account ID = " + getcid());
            Console.WriteLine("The Account type is = " + getAccty());
            Console.WriteLine("The Account balance is = " + getBal());
        }
    }
}
