using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    static class ForeignCurrencyAccountMenu
    {

        public static void addForeignAccount(List<ForeignCurrencyAccount> ForeignCurrencyAccountsList, ref int idNumber)
        {
            ForeignCurrencyAccount nextAccount = new ForeignCurrencyAccount();
            nextAccount.setAccountDetails(ref idNumber);

            foreach (ForeignCurrencyAccount account in ForeignCurrencyAccountsList)
            {
                if (account.AccountOwner.Pesel == nextAccount.AccountOwner.Pesel)
                {
                    Console.WriteLine("Error. Client with " + nextAccount.AccountOwner.Pesel + " PESEL has already had Current Accout.");
                    break;
                }
                else
                {
                    ForeignCurrencyAccountsList.Add(nextAccount);
                    Console.WriteLine("Account has been created.");
                    break;
                }
            }
        }

        public static void showForeignAccountsList(List<ForeignCurrencyAccount> AllAccountsList)
        {
            foreach (CurrentAccount Account in AllAccountsList)
            {
                Account.showAccountDetails();
                Console.WriteLine(" ");
            }
        }

        public static void findAccountByPesel(List<ForeignCurrencyAccount> AccountsList)
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

        public static void showAccountWithBalanceInPLN(List<ForeignCurrencyAccount> list)
        {
            Console.WriteLine("Type account ID to show balance in PLN: ");
            int id = int.Parse(Console.ReadLine());

                foreach (ForeignCurrencyAccount account in list)
                {
                    if (account.AccountID == id)
                    {
                        Console.WriteLine(" ");
                        account.showBalanceInPLN();
                        account.showAccountDetails();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Account not found.");
                    }
                    Console.WriteLine("Account ID: " + account.AccountID);
                account.showBalanceInPLN();
            }
        }

        public static void exampleList(List<ForeignCurrencyAccount> list)
        {
            Address address1 = new Address("FirstStreet", 1, "FirstCity", 12345);
            Client client1 = new Client("Ed", "Small", 12345678910, address1);
            ForeignCurrencyAccount account1 = new ForeignCurrencyAccount(1200,client1,3, Currency.EURO);

            Address address2 = new Address("SecondStreet", 1, "SecondCity", 23456);
            Client client2 = new Client("Jim", "Big", 54345678910, address2);
            ForeignCurrencyAccount account2 = new ForeignCurrencyAccount(400,client2,4,Currency.USD);

            list.Add(account1);
            list.Add(account2);
        }
    }
}
