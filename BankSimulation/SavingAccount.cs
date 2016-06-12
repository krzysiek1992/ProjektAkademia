using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    class SavingAccount : CurrentAccount
    {
        private DateTime dateOfClose;
        private int accountRate;

        public DateTime DateOfClose { get; set; }
        public int AccountRate { get; set; }

        public SavingAccount() : base()
        {
            this.AccountType = TypeOfAccount.Saving;
            this.DateOfClose = DateTime.Now;
            this.AccountRate = 0;
        }

        public SavingAccount(int accountBalance, Client accountOwner, DateTime dateOfClose, int accountRate, int accountId) :base(accountBalance, accountOwner, accountId)
        {
            this.AccountType = TypeOfAccount.Saving;
            this.AccountCurrency = Currency.PLN;
            this.DateOfClose = dateOfClose;
            this.AccountRate = accountRate;
        }

        public void setSavingAccountDetails()
        {
            bool correct = true;

            do
            {
                Console.WriteLine("Type rate of saving account: ");
                Console.WriteLine("[1] - 2% \n[2] - 3% \n[3] - 4% ");
                int rate = int.Parse(Console.ReadLine());

                if (rate == 1 || rate == 2 || rate == 3)
                {
                    this.AccountRate = rate;
                    correct = false;
                }
                else
                {
                    Console.WriteLine("Wrong number choosen. Type 1, 2 or 3");
                }
            } while (correct);

            do
            {
                Console.WriteLine("Type period of deposite: \n[1] - 3 months \n[2]  6 months \n[3] - 12 months");
                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        this.DateOfClose = this.DateOfCreate.AddMonths(3);
                        correct = false;
                        break;
                    case 2:
                        this.DateOfClose = this.DateOfCreate.AddMonths(6);
                        correct = false;
                        break;
                    case 3:
                        this.DateOfClose = this.DateOfCreate.AddMonths(12);
                        correct = false;
                        break;
                    default:
                        Console.WriteLine("Wrong number choosen. Type 1, 2 or 3");
                        break;
                }
            } while (correct);
        }

        public void showRateAndDateOfClose()
        {
            Console.WriteLine("Rate of this account is: " + this.AccountRate + "%");
            var days = this.DateOfClose - this.DateOfCreate;
            Console.WriteLine("Date of close is: " + this.DateOfClose + " (days to close: " + days.TotalDays + ")");
        }
    }
}
