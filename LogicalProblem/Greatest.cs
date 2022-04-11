using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class Greatest
    {
        public void Largest()
        {
            Console.WriteLine("Please Enter Number1 ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Number2 ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Number3 ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " " + "Number1is Greater");
                }
                else
                {
                    Console.WriteLine(num3 + " " + "Number2 is Greater");
                }
            }
            else
                if (num2 > num3)
            {
                Console.WriteLine(num2 + " " + "Number2 is Greater");
            }
            else
            {
                Console.WriteLine(num3 + " " + "Number3 is Greater");
            }
        }
    }
}
