using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    public class Bank
    {
        public string BankName { get; set; }
        public int BankDepartmentNumber { get; set; }
        public Address BankAddress { get; set; }

        public Bank() { }    

        public Bank(string bankName, int bankDepartmentNumber, Address bankAddress)
        {
            this.BankName = bankName;
            this.BankDepartmentNumber = bankDepartmentNumber;
            this.BankAddress = bankAddress;
        }
    }
}
