using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class Swap
    {
            
            public void Swapp()
            {
                Console.WriteLine("Please Enter Number1 ");
                int a = Convert.ToInt32((Console.ReadLine()));

                Console.WriteLine("Please Enter Number2 ");
                int b = Convert.ToInt32((Console.ReadLine()));

            a = a + b;
            b = a - b;
            a = a - b;
                Console.WriteLine("Number1 = " + a);
                Console.WriteLine("Number2 = " + b);

            }
        }
    }

