using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    class Address
    { 
        private string street;
        private int streetNumber;
        private string city;
        private int postCode;

        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }

        public Address()
        {
            this.Street = "default";
            this.StreetNumber = 0;
            this.City = "default";
            this.PostCode = 0;
        }

        public Address(string street, int streetNumber, string city, int postCode)
        {
            this.Street = street;
            this.StreetNumber = streetNumber;
            this.City = city;
            this.PostCode = postCode;
        }

        public void setAddressDetails()
        {
            Console.WriteLine("Type address details of new Client: ");

            bool uncorrect = true;
            do
            {
                Console.WriteLine("Type street: ");
                string street = Console.ReadLine();

                if (street.Equals("") || street.Equals(" "))
                {
                    Console.WriteLine("You have to fill it correctly.");
                }
                else
                {
                    this.Street = street;
                    uncorrect = false;
                }
            } while (uncorrect);                    

            uncorrect = true;
            do
            {
                Console.WriteLine("Type street number: ");
                try
                {
                    int streetNumber = int.Parse(Console.ReadLine());
                    this.StreetNumber = streetNumber;
                    uncorrect = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You have to fill this field correctly.");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            } while (uncorrect);

            uncorrect = true;
            do
            {
                Console.WriteLine("Type city: ");
                string city = Console.ReadLine();
                if (city.Equals("") || city.Equals(" "))
                {
                    Console.WriteLine("You have to fill it.");
                }
                else
                {
                    this.City = city;
                    uncorrect = false;
                }
            } while (uncorrect);

            uncorrect = true;
            do
            {
                Console.WriteLine("Type post code: ");
                try
                {
                    int postCode = int.Parse(Console.ReadLine());
                    this.PostCode = postCode;
                    uncorrect = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You have to fill this field correctly.");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            } while (uncorrect);
        }

        public void showAddressDetails()
        {
            Console.WriteLine("Address details:");
            Console.WriteLine("City " + this.City + " Street "+ this.Street + " " + this.StreetNumber + " Post code " + this.PostCode);
        }
    }
}
