using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    class Client
    {
        private string name; 
        private string surname; 
        private long pesel; 
        private Address clientAddress; 

        public string Name { get; set; }
        public  string Surname { get; set; }
        public long Pesel { get; set; }
        public Address ClientAddress { get; set; }

        public Client()
        {
            this.Name = "default";
            this.Surname = "default";
            this.pesel = 0;
            this.ClientAddress = new Address();
        }

        public Client(string name, string surname, long pesel, Address clientAddress)
        {
            this.Name = name;
            this.Surname = surname;
            this.Pesel = pesel;
            this.ClientAddress = clientAddress;
        }

        public void setClientDetails()
        {
            Console.WriteLine("Type personal details of new client: ");

            bool isValid = true;
            do
            {

                Console.WriteLine("Type name: ");
                string name = Console.ReadLine();
                if (name.Equals("") || name.Equals(" "))
                {
                    Console.WriteLine("You have to fill it.");
                }
                else
                {
                    this.Name = name;
                    isValid = false;
                }
            } while (isValid);

            bool isCorrect = true;
            do
            {

                Console.WriteLine("Type surname: ");
                string surname = Console.ReadLine();
                if (surname.Equals("") || surname.Equals(" "))
                {
                    Console.WriteLine("You have to fill it.");
                }
                else
                {
                    this.Surname = surname;
                    isCorrect = false;
                }
            } while (isCorrect);
            
            bool uncorrect = true;
            do
            {                
                Console.WriteLine("Type PESEL: ");
                try
                {
                    long pesel = long.Parse(Console.ReadLine());
                    this.Pesel = pesel;
                    uncorrect = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You have to type number.");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }

            } while (uncorrect);

            Address address = new Address();
            address.setAddressDetails();
            this.ClientAddress = address;
        }

        public void showClientDetails()
        {
            Console.WriteLine("Account Owner Details:");
            Console.WriteLine("PESEL: " + this.Pesel+ " Name: " + this.Name + " Surname: " + this.Surname);
            this.ClientAddress.showAddressDetails();
        }
    }
}
