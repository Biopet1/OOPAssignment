namespace HumanProject
{
    public abstract class Human
    {
        private int firstName;
        private string lastName;
        private int Wage;
        private int HoursWorked;
        public int FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int HourWorked
        {
            get { return HoursWorked; }
            set { HoursWorked = value; }
        }
        public int Wages
        {
            get { return Wage; }
            set { Wage = value; }
        }
        public Human(int FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }
        public Human(int hoursWorked, int wage) 
        {
            this.HoursWorked = hoursWorked;
            this.Wage = wage;
        }

        
        


        
    }
}