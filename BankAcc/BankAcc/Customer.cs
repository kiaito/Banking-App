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
    //Declarations
    public class Customer
    {
        string CustID;
        string CustPW;
        string CustFN;
        string CustLN;
        string CustADD;
        string CustEmail;
         public AccountList alists = new AccountList();

        

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
            alists.display();
        }



        //---------BEHAVIOR---------//

        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;

        public System.Data.OleDb.OleDbCommand OleDbSelectCommand;

        public System.Data.OleDb.OleDbCommand OleDbInsertCommand;

        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand;

        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand;

        public System.Data.OleDb.OleDbConnection OleDbConnection;

        public string cmd;

        //---------Database Setup -------//

        public void DBSetup()
        {
            OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();

            OleDbSelectCommand = new System.Data.OleDb.OleDbCommand();

            OleDbInsertCommand = new System.Data.OleDb.OleDbCommand();

            OleDbUpdateCommand = new System.Data.OleDb.OleDbCommand();

            OleDbDeleteCommand = new System.Data.OleDb.OleDbCommand();

            OleDbConnection = new System.Data.OleDb.OleDbConnection();

            OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand;

            OleDbDataAdapter2.InsertCommand = OleDbInsertCommand;

            OleDbDataAdapter2.SelectCommand = OleDbSelectCommand;

            OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand;

            OleDbConnection.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" +

            "ocking Mode=1;Data Source=c:\\Users\\grob1\\Documents\\ChattBankMDB.mdb;J" +

            "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +

            "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +

            "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +

            "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +

            "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";

        } //end DB setup


        //----Select Database Connection-----//

        public void SelectDB(string id)

        {

            DBSetup();

            cmd = "Select * from Customers where CustID = '" + id + "'";

            OleDbDataAdapter2.SelectCommand.CommandText = cmd;

            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection;

            Console.WriteLine(cmd);

            try

            {

                OleDbConnection.Open();

                System.Data.OleDb.OleDbDataReader dr;

                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();



                dr.Read();

                CustID = id;

                setcustpw(dr.GetValue(1) + "");

                setcustfn(dr.GetValue(2) + "");

                setcustln(dr.GetValue(3) + "");

                setcustadd(dr.GetValue(4) + "");

                setcustem(dr.GetValue(5) + "");           
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection.Close();
            }
            GetSchedule();
        }
        // end SelectDB


        // getting schedule list

        public void GetSchedule()

        {
            cmd = "Select AcctNo from Accounts where Cid = '" + CustID + "'";

            OleDbDataAdapter2.SelectCommand.CommandText = cmd;

            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection;

            Console.WriteLine(cmd);

            string acct = "";

            Account s1 = new Account();

            try

            {
                OleDbConnection.Open();

                System.Data.OleDb.OleDbDataReader dr;

                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();
                while (dr.Read())
                {
                   acct = (dr.GetValue(0) + "");

                    s1 = new Account();

                    s1.SelectDB(acct);
                    
                    alists.add(s1);
                }
            }
            catch (Exception ex)
           {
                Console.WriteLine(ex);
            }

            finally
            {
                OleDbConnection.Close();

            }
        }






        //------Insert Database method-------//

        public void InsertDB()

        {

            DBSetup();



            cmd = "Insert into Customers values(" + getcustid() + "," + "'" + getcustpw() + "'," + "'" + getcustfn()

                + "'," + "'" + getcustln() + "'," + "'" + getcustadd()

                + "'," + "'" + getcustem() + "')";

            OleDbDataAdapter2.InsertCommand.CommandText = cmd;

            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection;

            Console.WriteLine(cmd);

            try

            {

                OleDbConnection.Open();

                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();

                if (n == 1)

                {

                    Console.WriteLine("Data Inserted");

                }

                else

                {

                    Console.WriteLine("Error: Inserting Data");

                }

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex);

            }

            finally

            {

                OleDbConnection.Close();

            }

        } //End InsertDB()

        //------Update into Database-------//

        public void Upddate()

        {

            DBSetup();

            cmd = "Update Customers set CustID ='" + getcustid() + "',"

                + "CustPassword ='" + getcustpw() + "',"

                + "CustFirstName ='" + getcustfn() + "',"

                + "CustLastName ='" + getcustln() + "',"

                + "CustAddress ='" + getcustadd() + "',"

                + " CustEmail ='" + getcustem() + "'"

               + "where CustID ='" + getcustid()+ "'";



            OleDbDataAdapter2.InsertCommand.CommandText = cmd;

            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection;

            Console.WriteLine(cmd);

            try

            {

                OleDbConnection.Open();

                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();

                if (n == 1)

                {

                    Console.WriteLine("Data Updated");

                }

                else

                {

                    Console.WriteLine("Error: Updating Data");

                }

            }

            catch (Exception ex)

            {
                Console.WriteLine(ex);
            }

            finally
            {
                OleDbConnection.Close();

            }

        } //End UpdateDB()

        //Deleting DadaBase Method

        public void DeleteDB()

        {

            DBSetup();

            cmd = "Delete from Customers where CustID = '" + getcustid() +"'";



            OleDbDataAdapter2.InsertCommand.CommandText = cmd;

            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection;

            Console.WriteLine(cmd);

            try

            {

                OleDbConnection.Open();

                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();

                if (n == 1)

                {

                    Console.WriteLine("Data Deleted");

                }

                else

                {

                    Console.WriteLine("Error: Deleting Data");

                }

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex);

            }

            finally

            {

                OleDbConnection.Close();

            }

        }//End of Delete()

    }
}