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
            char ch1 = char.ToLower(ch);


            if (ch1 == 'a' || ch1 == 'e' || ch1 == 'i' || ch1 == 'o' || ch1 == 'u')
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
