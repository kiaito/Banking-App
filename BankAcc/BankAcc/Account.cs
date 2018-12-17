using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
   public class Account
    {
        //Declaration
        string AccNo;
        string Custid;
        string AccTy;
        double Bal;
       public  AccountList alist = new AccountList();

        //Blank Constructor
        public Account()
        {
            AccNo = "";
            Custid = "";
            AccTy = "";
            Bal = 0;

        }
        //All args Constructor
        public Account( string an, string cid, string ty, double bl)
        {
            AccNo = an;
            Custid = cid;
            AccTy = ty;
            Bal = bl;
        }
        // Getters and Setters
        public void setAccno(string ac)
        {
            AccNo = ac;
        }
        public string getAccno()
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
            Console.WriteLine("The Customer ID = " + getcid());
            Console.WriteLine("The Account type is = " + getAccty());
            Console.WriteLine("The Account balance is = " + getBal());
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

        public void SelectDB(string an)

        {// select statement pulling info from account table

            DBSetup();

            cmd = "Select * from Accounts where AcctNo = '" + an + "'";

            OleDbDataAdapter2.SelectCommand.CommandText = cmd;

            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection;

            Console.WriteLine(cmd);

            try

            {

                OleDbConnection.Open();

                System.Data.OleDb.OleDbDataReader dr;

                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();



                dr.Read();

                AccNo = an;

                setcid(dr.GetValue(1) +"");

                setAccty(dr.GetValue(2) + "");

                setBal(double.Parse(dr.GetValue(3) + ""));

               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection.Close();
            }
            //GetList();
        }
        // end SelectDB
        //------Insert Database method-------//

        public void InsertDB()

        {// insert method for insert data

            DBSetup();



            cmd = "Insert into Accounts values(" + getAccno() + "," + "'" + getcid() + "'," + "'" + getAccty()

                + "'," + getBal() + " )";

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

            cmd = "Update Accounts set AcctNo ='" + getAccno() + "',"

                + "Cid ='" + getcid() + "',"

                + "Type ='" + getAccty() + "',"

                + "Balance =" + getBal() + " "

               + "where AcctNo ='" + getAccno() + "'";



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


            cmd = "Delete from Accounts where AcctNo = '" + getAccno() + "'";



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

        public void GetAllAccountlist()
            //Method for getting the liust of accountskm nb
        {
            DBSetup();


            cmd = "Select * from Accounts";

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

                    alist.add(s1);
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
        }//end get accountlist
    }
}
