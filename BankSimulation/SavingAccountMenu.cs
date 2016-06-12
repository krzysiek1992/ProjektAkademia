using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    static class SavingAccountMenu
    {

        public static void addSavingAccount(List<SavingAccount> SavingAccountList, ref int idNumber)
        {
            SavingAccount nextAccount = new SavingAccount();
            nextAccount.setAccountDetails(ref idNumber);

            foreach (SavingAccount account in SavingAccountList)
            {
                if (account.AccountOwner.Pesel == nextAccount.AccountOwner.Pesel)
                {
                    Console.WriteLine("Error. Client with " + nextAccount.AccountOwner.Pesel + " PESEL has already had Current Accout.");
                    break;
                }
                else
                {
                    SavingAccountList.Add(nextAccount);
                    Console.WriteLine("Account has been created.");
                    break;
                }
            }
        }

        public static void showSavingAccountsList(List<SavingAccount> SavingAccountList)
        {
            foreach (CurrentAccount Account in SavingAccountList)
            {
                Account.showAccountDetails();
                Console.WriteLine(" ");
            }
        }

        public static void findAccountByPesel(List<SavingAccount> SavingAccountList)
        {
            Console.WriteLine("Type Client PESEL you want to find");
            int toFind = int.Parse(Console.ReadLine());
            foreach (SavingAccount Account in SavingAccountList)
            {
                if (Account.AccountOwner.Pesel == toFind)
                {
                    Console.WriteLine("Client with PESEL: " + toFind + " has Current Account with ID: " + Account.AccountID);
                    Console.WriteLine("Type of account is: " + Account.AccountType);
                }
                else
                {
                    Console.WriteLine("PESEL not found, try again.");
                    Console.WriteLine("Press any key to continue.");
                }
            }
        }

        public static void showRateAndDateOfCloseList(List<SavingAccount> list)
        {
            Console.WriteLine("Type account ID to show rate and date of close: ");
            int id = int.Parse(Console.ReadLine());

            foreach (SavingAccount account in list)
            {
                if (account.AccountID == id)
                {
                    Console.WriteLine(" ");
                    account.showRateAndDateOfClose();
                    break;
                }
                else
                {
                    Console.WriteLine("Account not found.");
                }
            }
        }

        public static void exampleList(List<SavingAccount> list)
        {
            DateTime date1 = DateTime.Now; DateTime date2 = date1.AddMonths(3);

            Address address1 = new Address("FirstStreet", 1, "FirstCity", 12345);
            Client client1 = new Client("Ed", "Small", 12345678910, address1);
            SavingAccount account1 = new SavingAccount(300, client1, date2, 2, 5);

            Address address2 = new Address("SecondStreet", 1, "SecondCity", 23456);
            Client client2 = new Client("Jim", "Big", 54345678910, address2);
            SavingAccount account2 = new SavingAccount(1000, client2, date2, 2, 6);

            list.Add(account1);
            list.Add(account2);
        }

    }
}
