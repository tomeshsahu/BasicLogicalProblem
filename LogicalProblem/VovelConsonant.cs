using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class VovelConsonant
    {
        public void Vovel()
        {
            Console.WriteLine("Please Enter Single Charactor ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine(ch + " " + "is a Vovel");
            }
            else
            {
                Console.WriteLine(ch + " " + "is a Consonant");
            }

        }
    }
}
