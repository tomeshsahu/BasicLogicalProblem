using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class FlipCoin
    {
        const double IS_HEAD = 0.5;
        int headCount = 0, tailCount = 0;
        int percentage = 0;
        int tailper = 0;
        public void Flip()
        {
            Console.WriteLine("Enter Number of Flips");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Random random = new Random();
                int Option = random.Next(0, 2);
                if (Option < IS_HEAD)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }

            }
            Console.WriteLine("Head Coin " + " " + headCount);
            Console.WriteLine("Tail Coin" + " " + tailCount);

            percentage = headCount * 100 / num;
            tailper = 100 - percentage;
            Console.WriteLine("Percentage of Headcoin" + " " + percentage);
            Console.WriteLine("Percentage of Tailcoin" + " " + tailper);
        }
    }
}
