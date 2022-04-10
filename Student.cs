using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanProject
{
    public class Student:Human
    {
        public int Mark { get; set; }
        public Student(int FirstName, string LastName,int mark) : base(FirstName, LastName)
        {
            this.Mark = mark;
        }

        

    }
}
