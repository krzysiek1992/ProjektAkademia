using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    static class Menu 
    {
        public static void showMenu()
        {
            Console.Clear();
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("Type [sign] to choose option: ");
            Console.WriteLine("[1] - Show current accounts menu. ");
            Console.WriteLine("[2] - Show foreign currency accounts menu.");
            Console.WriteLine("[3] - Show saving accounts menu. ");
            Console.WriteLine("[0] - Exit! ");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||");
        }

        public static void showCurrentAccountMenu()
        {
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("Type [sign] to choose option: ");
            Console.WriteLine("[1] - Add new account.");
            Console.WriteLine("[2] - Show account list (order by history of account creation).");
            Console.WriteLine("[3] - Find account by Owner PESEL.");
            Console.WriteLine("[4] - Sort accounts by Owner Surname.");
            Console.WriteLine("[5] - Deposite money.");
            Console.WriteLine("[6] - Make money transfer.");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
        }

        public static void showForeignAccountMenu()
        {
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("Type [sign] to choose option: ");
            Console.WriteLine("[1] - Add new account.");
            Console.WriteLine("[2] - Show accounts list (order by history of account creation).");
            Console.WriteLine("[3] - Show accounts list with balance in PLN");
            Console.WriteLine("[4] - Find account by Owner PESEL.");
            Console.WriteLine("[5] - Sort accounts by Owner Surname.");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
        }

        public static void showSavingAccoungMenu()
        {
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("Type [sign] to choose option: ");
            Console.WriteLine("[1] - Add new account.");
            Console.WriteLine("[2] - Show account list (order by history of account creation).");
            Console.WriteLine("[3] - Find account by Owner PESEL.");
            Console.WriteLine("[4] - Sort accounts by Owner Surname.");
            Console.WriteLine("[5] - Show rate and date of close of choosen account.");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
        }

        public static void pressToContinue()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
