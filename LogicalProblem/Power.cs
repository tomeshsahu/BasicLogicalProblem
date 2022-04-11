using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class Power { 
    
            int pwr = 1;
            public void Powerv()
        { 
                Console.WriteLine("Enter Number for End");
                int Num = Convert.ToInt32((Console.ReadLine()));

            for (int i = 0; i <= Num; i++)
            {
                pwr = pwr * 2;
                Console.WriteLine("2 ^ " + "2power" + i + " = " + pwr);

            }
            }
        }
    }

