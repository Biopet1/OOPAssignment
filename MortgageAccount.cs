using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class MortgageAccount : Account
    {
        
        Individual Ind1=new Individual();
        public override double CalculateInterestRate()
        {
            

            var C1 = new Company();
            var Person = new Individual();
            if ( number_of_months < 12 && CustomerAccount == C1)
            {
                return 0.5 * (number_of_months * InterestRate);
            }
            else if (number_of_months < 6 && CustomerAccount == Person)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }

        public override void DepositMoney()
        {
            throw new NotImplementedException();
        }
    }
}
