using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{

    public class DepositAccount : Account,IWithdraw
    {
        public override double CalculateInterestRate()
        {

            if (Balance < 0 && Balance > 1000)
            {
                return number_of_months * InterestRate;
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

        public void WithdrawMoney()
        {
            throw new NotImplementedException();
        }
    }
}
   
