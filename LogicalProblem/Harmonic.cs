using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
   public class Harmonic
    {
            double result = 0.0;
            public void Harmo()
        { 
                Console.WriteLine("Enter Number ");
                int Num = Convert.ToInt32((Console.ReadLine()));

                for (int i = 1; i <= Num; i++)
                {
                    result = result + (0.1) / i;

                }
            Console.WriteLine(result);

            }
        }
    }

