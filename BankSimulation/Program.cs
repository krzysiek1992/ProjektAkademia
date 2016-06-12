using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int idNumber = 6;
            int option = 0;
            int optionMenuForeign = 0;
            int optionMenuCurrent = 0;
            int optionMenuSaving = 0;

            List<CurrentAccount> CurrentAccountsList = new List<CurrentAccount>();
            List<ForeignCurrencyAccount> ForeignCurrencyAccountsList = new List<ForeignCurrencyAccount>();
            List<SavingAccount> SavingAccountList = new List<SavingAccount>();

            CurrentAccountMenu.exampleList(CurrentAccountsList);                       // dodaje przykladowe konta
            ForeignCurrencyAccountMenu.exampleList(ForeignCurrencyAccountsList);
            SavingAccountMenu.exampleList(SavingAccountList);         

            do
            {
                Console.Clear();
                Menu.showMenu();
                
                bool uncorrect = true;
                do
                {
                    try
                    {
                        option = int.Parse(Console.ReadLine());
                        uncorrect = false;
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

                switch (option)
                    {
                    case 1:
                        Console.Clear();
                        Menu.showCurrentAccountMenu();


                        bool isValid1 = true;
                        do
                        {
                            try
                            {
                                optionMenuCurrent = int.Parse(Console.ReadLine());
                                isValid1 = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error. Type correct.");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error. Type correct.");
                            }
                        } while (isValid1);


                        switch (optionMenuCurrent)
                        {
                            case 1:
                                CurrentAccountMenu.addCurrentAccount(CurrentAccountsList, ref idNumber);
                                Menu.pressToContinue();
                                break;
                            case 2:
                                CurrentAccountMenu.showCurrentAccountsList(CurrentAccountsList);
                                Menu.pressToContinue();
                                break;
                            case 3:
                                CurrentAccountMenu.findAccountByPesel(CurrentAccountsList);
                                Menu.pressToContinue();
                                break;
                            case 4:
                                CurrentAccountsList.Sort();
                                CurrentAccountMenu.showCurrentAccountsList(CurrentAccountsList);
                                Menu.pressToContinue();
                                break;
                            case 5:
                                CurrentAccountMenu.depositeMoney(CurrentAccountsList);
                                Menu.pressToContinue();
                                break;
                            case 6:
                                CurrentAccountMenu.moneyTransfer(CurrentAccountsList);
                                Menu.pressToContinue();
                                break;
                            default:
                                Console.WriteLine("Error. Type correct.");
                                Menu.pressToContinue();
                                break;
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Menu.showForeignAccountMenu();

                        bool isValid2 = true;
                        do
                        {
                            try
                            {
                                optionMenuForeign = int.Parse(Console.ReadLine());
                                isValid2 = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error. Type correct.");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error. Type correct.");
                            }
                        } while (isValid2);


                        switch (optionMenuForeign)
                        {
                            case 1:
                                ForeignCurrencyAccountMenu.addForeignAccount(ForeignCurrencyAccountsList, ref idNumber);
                                Menu.pressToContinue();
                                break;
                            case 2:                               
                                ForeignCurrencyAccountMenu.showForeignAccountsList(ForeignCurrencyAccountsList);
                                Menu.pressToContinue();
                                break;
                            case 3:
                                ForeignCurrencyAccountMenu.showAccountWithBalanceInPLN(ForeignCurrencyAccountsList);
                                Menu.pressToContinue();
                                break;
                            case 4:
                                ForeignCurrencyAccountMenu.findAccountByPesel(ForeignCurrencyAccountsList);
                                Menu.pressToContinue();
                                break;
                            case 5:
                                ForeignCurrencyAccountsList.Sort();
                                ForeignCurrencyAccountMenu.showForeignAccountsList(ForeignCurrencyAccountsList);
                                Menu.pressToContinue();
                                break;
                            default:
                                Console.WriteLine("Wrong number. Type correct.");
                                Menu.pressToContinue();
                                break;
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Menu.showSavingAccoungMenu();

                        bool isValid3 = true;
                        do
                        {
                            try
                            {
                                optionMenuSaving = int.Parse(Console.ReadLine());
                                isValid3 = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error. Type correct.");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error. Type correct.");
                            }
                        } while (isValid3);


                        switch (optionMenuSaving)
                        {
                            case 1:
                                SavingAccountMenu.addSavingAccount(SavingAccountList, ref idNumber);
                                Menu.pressToContinue();
                                break;
                            case 2:
                                SavingAccountMenu.showSavingAccountsList(SavingAccountList);
                                Menu.pressToContinue();
                                break;
                            case 3:
                                SavingAccountMenu.findAccountByPesel(SavingAccountList);
                                Menu.pressToContinue();
                                break;
                            case 4:
                                SavingAccountList.Sort();
                                SavingAccountMenu.showSavingAccountsList(SavingAccountList);
                                Menu.pressToContinue();
                                break;
                            case 5:
                                SavingAccountMenu.showRateAndDateOfCloseList(SavingAccountList);
                                Menu.pressToContinue();
                                break;
                            default:
                                Console.WriteLine("Wrong number. Type correct.");
                                Menu.pressToContinue();
                                break;
                        }
                        break;

                    case 0:
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong number. Type correct.");
                        Console.ReadKey();
                        break;
                }

            } while (true);

        }
    }
}
