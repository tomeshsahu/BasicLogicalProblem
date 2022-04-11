using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class PrimeFactor
    {
            const int PRIME = 2;
            int Count;
            public void Prime()
            {
                Console.WriteLine("Please Enter Number ");
                int Num = Convert.ToInt32((Console.ReadLine()));

                for (int i = 1; i <= Num; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            Count++;
                        }
                    }
                    if (Count == PRIME)
                    {
                        Console.WriteLine("Prime Factors is" + i);
                    }
                    Count = 0;

                }
            }
        }
}
