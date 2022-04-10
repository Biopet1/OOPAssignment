namespace BankProject
{
    public class LoanAccount : Account
    {
        //public Account MyAccount { get; set; }
        
        public override double CalculateInterestRate()
        {
            //if(CustomerAccount.GetType() == typeof(Individual))
            //{

            //}
            var Person = new Individual();

            var C1 = new Company();
            if (number_of_months > 3 && CustomerAccount != Person)
            {
                return number_of_months * InterestRate;
            }
           else if (number_of_months > 2 && CustomerAccount != C1)
            {
                return number_of_months * InterestRate;
            }
            else {
                return 0;
            }
        }

        public override void DepositMoney()
        {
            throw new NotImplementedException();
        }
    }
}