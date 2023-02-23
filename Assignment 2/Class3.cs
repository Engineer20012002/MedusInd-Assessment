using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
        public class Account
        {
            int AccountNo;
            String CustomerName;
            String AccountType;
            String transType;
            Double Amount;
            Double Balance;
            public Account(int AccountNo, string CustomerName, string AccountType, string transType, double Amount)
            {
                this.AccountNo = AccountNo;
                this.CustomerName = CustomerName;
                this.AccountType = AccountType;
                this.transType = transType;
                this.Amount = Amount;
                this.Balance = 100;
            }
            public void Credit(double Amount)
            {
                Balance += Amount;
            }

            public void Debit(double Amount)
            {
                Balance -= Amount;
            }
            public void ShowData() //show data func...
            {
                Console.WriteLine("Enter Account Number:");
                this.AccountNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Customer’s Name:");
                this.CustomerName = Console.ReadLine();
                Console.WriteLine("Enter Account Type:");
                this.AccountType = Console.ReadLine();
                Console.WriteLine("Enter Transaction Type(d->deposit / w->withdrawal):");
                this.transType = Console.ReadLine();
                Console.WriteLine("Enter Amount:");
                this.Amount = Convert.ToDouble(Console.ReadLine());
                if(transType == "d")
                        {
                    transType = "Deposit";
                    Balance = Balance + Amount;
                }
                else if (transType == "w" && Amount < Balance)
            {
                    transType = "Withdrawal";
                    Balance = Balance - Amount;
                }
                else if (transType == "w" && Amount > Balance)
            {
                    transType = "Transaction is not possible.";
                }
                Console.WriteLine("Account Number:"+AccountNo);
                Console.WriteLine("Customer Name:"+CustomerName);
                Console.WriteLine("Account Type:" +AccountType);
                Console.WriteLine("Transaction Type:" +transType);
                Console.WriteLine("Amount:"+Amount);
                Console.WriteLine("Balance:"+Balance);
            }
        }
        public class Account763
        {
            public static void Main(string[] args)
            {
                Account myacc = new Account(0938238,"Sanjay","savings","a", 200.00);
                myacc.Credit(100);
                myacc.Debit(50);
                myacc.ShowData();
                Console.Read();
            }

        }
    }
