using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{

    public enum Currency { PLN, EURO, USD, CHF }
    public enum TypeOfAccount { Current, ForeignCurrency, Saving}

    class CurrentAccount : IComparable<CurrentAccount>
    {
        public int AccountID { get; set; }
        public int AccountBalance { get; set; }
        public Client AccountOwner { get; set; }
        public DateTime DateOfCreate { get; set; }
        public Currency AccountCurrency { get; set; }
        public TypeOfAccount AccountType { get; set; }

        public CurrentAccount()
        {
            this.AccountType = TypeOfAccount.Current;
            this.AccountOwner = new Client();
            this.AccountCurrency = Currency.PLN;
            this.DateOfCreate = DateTime.Now;
            this.AccountID = 0;
        }

        public CurrentAccount(int accountBalance, Client accountOwner, int accountId)
        {
            this.DateOfCreate = DateTime.Now;
            this.AccountCurrency = Currency.PLN;
            this.AccountBalance = accountBalance;
            this.AccountOwner = accountOwner;
            this.AccountID = accountId;
            this.AccountType = TypeOfAccount.Current;
        }

        public void creditTransfer()
        {
            Console.WriteLine("How many do you want to transfer? Type: ");
            int value = int.Parse(Console.ReadLine());

            if (value <= 0)
            {
                Console.WriteLine("You have to type positive number.");
            }
            else
            {
                if (this.AccountBalance > value)
                {
                    this.AccountBalance -= value;
                    Console.WriteLine("Operation completed successfully.");
                }
                else
                {
                    Console.WriteLine("Not enough money.");
                    Console.WriteLine("Balance of account with ID:" + this.AccountID + " is " + this.AccountBalance);
                }

                Console.ReadKey();
            }
        }

        public void depositeMoney()
        {
            Console.WriteLine("How many do you want to deposite? Type: ");
            int value = int.Parse(Console.ReadLine());

            if (value <= 0)
            {
                Console.WriteLine("You have to type positive number.");
            }
            else
            {
                this.AccountBalance += value;
                Console.WriteLine("Operation completed successfully.");
                Console.ReadKey();
            }
        }

        public void setAccountDetails(ref int idNumber)
        {
            idNumber++;
            bool uncorrect = true;

            do
            {
                try
                {                    
                     Console.WriteLine("Type balance: ");
                     int balance = int.Parse(Console.ReadLine());
                
                     if (balance <= 0)
                     {
                         Console.WriteLine("You have to type positive number.");
                     }
                     else
                     {
                        this.AccountBalance = balance;
                        uncorrect = false;
                     }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Error. Try to type correct number.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Error. Try to type correct number.");
                }
            } while (uncorrect);

            this.AccountID = idNumber;
            Client client = new Client();
            client.setClientDetails();
            this.AccountOwner = client;
        }

        public void showAccountDetails()
        {
            Console.WriteLine("ID: " + this.AccountID);
            this.AccountOwner.showClientDetails();
            Console.WriteLine("Account Balance: " + this.AccountBalance);
        }

        public int CompareTo(CurrentAccount surnameAccount)
        {
            return this.AccountOwner.Surname.CompareTo(surnameAccount.AccountOwner.Surname);
        }

    }
}
