using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/******
 * Author: :Levi Llewellyn 
 * Created: November 2018
 * Banp Application 
 * Customer Business Object
 * ****/
namespace BankAcc
{
    class Customer
    {
        string CustID;
        string CustPW;
        string CustFN;
        string CustLN;
        string CustADD;
        string CustEmail;

        //Constructor set the property values
        public Customer()
        {
            CustID = "";
            CustPW = "";
            CustFN = "";
            CustLN = "";
            CustADD = "";
            CustEmail = "";
        }
        //All args constructor
        public Customer(string id, string pw, string fn, string ln, string add, string em)
        {
            CustID = id;
            CustPW = pw;
            CustFN = fn;
            CustLN = ln;
            CustADD = add;
            CustEmail = em;
        }

        //Getters and Setters
        public void setcustid(string id)
        {
            CustID = id;
        }
        public string getcustid()
        {
            return CustID;
        }
        public void setcustpw(string pw)
        {
            CustPW = pw;
        }
        public string getcustpw()
        {
            return CustPW;
        }
        public void setcustfn(string fn)
        {
            CustFN = fn;
        }
        public string getcustfn()
        {
            return CustFN;
        }
        public void setcustln(string ln)
        {
            CustLN = ln;
        }
        public string getcustln()
        {
            return CustLN;
        }
        public void setcustadd(string add)
        {
            CustADD = add;
        }
        public string getcustadd()
        {
            return CustADD;
        }
        public void setcustem(string em)
        {
            CustEmail = em;
        }
        public string getcustem()
        {
            return CustEmail;
        }

        public void display()
        {
            Console.WriteLine("Customer id = " + getcustid());
            Console.WriteLine("Customer First Name = " + getcustfn());
            Console.WriteLine("Customer LAst Name = " + getcustln());
            Console.WriteLine("Customer Address = " + getcustadd());
            Console.WriteLine("Customer Email = " + getcustem());
            Console.WriteLine("Customer Password = " + getcustpw());
        }
    }
}