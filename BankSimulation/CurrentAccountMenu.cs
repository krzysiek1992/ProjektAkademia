using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{

    static class CurrentAccountMenu
    {

        public static void addCurrentAccount(List<CurrentAccount> CurrentAccountsList, ref int idNumber)
        {
            CurrentAccount nextAccount = new CurrentAccount();
            nextAccount.setAccountDetails(ref idNumber);

            foreach (CurrentAccount account in CurrentAccountsList)
            {
                if (account.AccountOwner.Pesel == nextAccount.AccountOwner.Pesel)
                {
                    Console.WriteLine("Error. Client with " + nextAccount.AccountOwner.Pesel + " PESEL has already had Current Accout.");
                    break;
                }
                else
                {
                    CurrentAccountsList.Add(nextAccount);
                    Console.WriteLine("Account has been created.");
                    break;
                }
            }
        }

        public static void showCurrentAccountsList(List<CurrentAccount> CurrentAccountsList)
        {
            foreach (CurrentAccount Account in CurrentAccountsList)
            {
                Account.showAccountDetails();
                Console.WriteLine(" ");
            }
        }

        public static void findAccountByPesel(List<CurrentAccount> AccountsList)
        {
            Console.WriteLine("Type Client PESEL you want to find");
            int toFind = int.Parse(Console.ReadLine());
            foreach (CurrentAccount Account in AccountsList)
            {
                if (Account.AccountOwner.Pesel == toFind)
                {
                    Console.WriteLine("Client with PESEL: " + toFind + " has Current Account with ID: " + Account.AccountID);
                    Console.WriteLine("Type of account is: " + Account.AccountType);
                }
                else
                {
                    Console.WriteLine("PESEL not found, try again.");
                }
            }
        }

        public static void depositeMoney(List<CurrentAccount> list)
        {
            Console.WriteLine("Type ID of account to make deposite: ");
            int id = int.Parse(Console.ReadLine());
            foreach (CurrentAccount account in list)
            {
                if (account.AccountID == id)
                {
                    account.depositeMoney();
                }
                else
                {
                    Console.WriteLine("ID not found.");
                }
            }
        }

        public static void moneyTransfer(List<CurrentAccount> list)
        {
            Console.WriteLine("Type ID of account to make credit transfer: ");
            int id = int.Parse(Console.ReadLine());
            foreach (CurrentAccount account in list)
            {
                if (account.AccountID == id)
                {
                    account.creditTransfer();
                }
                else
                {
                    Console.WriteLine("ID not found.");
                }
            }
        }

        public static void exampleList (List<CurrentAccount> list)
        {
            Address address1 = new Address("FirstStreet", 1, "FirstCity", 12345);
            Client client1 = new Client("Ed", "Small", 12345678910 , address1);
            CurrentAccount account1 = new CurrentAccount(1000, client1, 1);

            Address address2 = new Address("SecondStreet", 1, "SecondCity", 23456);
            Client client2 = new Client("Jim", "Big", 54345678910, address2);
            CurrentAccount account2 = new CurrentAccount(500, client2, 2);

            list.Add(account1);
            list.Add(account2);
        }

    }
}
