using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class EvenOdd
    {

        public void Even()
        {
            Console.WriteLine("Please Enter Number ");
            int Num = Convert.ToInt32((Console.ReadLine()));

            if (Num % 2 == 0)
            {
                Console.WriteLine(Num + " " + " is a Odd Number");
            }
            else
            {
                Console.WriteLine(Num + " " + "is a Even Number");
            }

        }
    }
}
