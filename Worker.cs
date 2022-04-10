using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanProject
{
    public class Worker :Human
    {
        public Worker(int hoursWorked,int wage) : base(hoursWorked, wage)
        {
           
        }
        public void CalculateHourlyWage()
        {
            Console.WriteLine(" Your Hourly wage rate is: {0}", HourWorked*Wages);
        }
    }
    class Program
    {
        static void Main()
        {
            var w1 = new Worker(3, 4);
        }
    }
}
