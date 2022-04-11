using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class LeapYear
    {
        public void Year()
        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32((Console.ReadLine()));
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine(year + " " + "is Leap Year");
            }
            else
            {
                Console.WriteLine(year + " " + "is Not Leap Year");
            }
        }
    }
}
