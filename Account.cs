using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
   public abstract class Account
    {
        public Customer CustomerAccount { get; set; }
        public Individual IndividualPerson { get; set; }
        public decimal Balance { get; set; }
        public float InterestRate { get; set; }
        public int number_of_months { get; set; }

        public abstract void DepositMoney();
        
        public abstract double CalculateInterestRate();
        
        
        
    }
}
