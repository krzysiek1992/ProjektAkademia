using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{

    class ForeignCurrencyAccount : CurrentAccount
    {
        public ForeignCurrencyAccount() : base()
        {
            this.AccountType = TypeOfAccount.ForeignCurrency;
        }

        public ForeignCurrencyAccount(int accountBalance, Client accountOwner, int accountId, Currency currency) :base(accountBalance, accountOwner, accountId)
        {
            this.AccountType = TypeOfAccount.ForeignCurrency;
            this.AccountCurrency = currency;
        }

        public void setCurrency()
        {
            bool correct = true;

            do
            {
                Console.WriteLine("Choose account currency: \n[1]- EURO \n[2] - USD \n[3]- CHF");
                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        AccountCurrency = Currency.EURO;
                        correct = false;
                        break;
                    case 2:
                        AccountCurrency = Currency.USD;
                        correct = false;
                        break;
                    case 3:
                        AccountCurrency = Currency.CHF;
                        correct = false;
                        break;
                    default:
                        Console.WriteLine("Wrong number choosen. Type 1, 2 or 3");
                        break;
                }
            } while (correct);
        }

        public void showBalanceInPLN()
        {
            if(this.AccountCurrency == Currency.CHF)
            {
                int amount = this.AccountBalance;
                double inPLN = amount * 3.9;
                Console.WriteLine("Account balance in PLN: " +inPLN);
            }
            else if (this.AccountCurrency == Currency.EURO)
            {
                int amount = this.AccountBalance;
                double inPLN = amount * 4.4;
                Console.WriteLine("Account balance in PLN: " + inPLN);
            }
            else if (this.AccountCurrency == Currency.USD)
            {
                int amount = this.AccountBalance;
                double inPLN = amount * 3.8;
                Console.WriteLine("Account balance in PLN: " + inPLN);
            }

        }
    }
}
