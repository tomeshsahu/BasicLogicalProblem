using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class Reminder
    {
            int Quadrant = 0, Remi = 0;
            public void QuadrantReminder()
            {
                Console.WriteLine("Please Enter Number ");
                int Num = Convert.ToInt32((Console.ReadLine()));

                Quadrant = Num / 10;
                Console.WriteLine(Quadrant + " " + "It is Quadrant of" + " " + Num);
                Remi = Num % 10;
                Console.WriteLine(Remi + " " + "It is Reminder of" + " " + Num);
            }
        }
    }



