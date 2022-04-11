using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class Swap
    {
            int temp = 0;
            public void Swapp()
            {
                Console.WriteLine("Please Enter Number1 ");
                int Num1 = Convert.ToInt32((Console.ReadLine()));

                Console.WriteLine("Please Enter Number2 ");
                int Num2 = Convert.ToInt32((Console.ReadLine()));

                temp = Num1;
                Num1 = Num2;
                Num2 = temp;

                Console.WriteLine("Number1 = " + Num1);
                Console.WriteLine("Number2 = " + Num2);

            }
        }
    }

