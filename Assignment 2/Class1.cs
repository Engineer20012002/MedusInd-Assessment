using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Class1
    {
        static void Main() {
            Console.WriteLine(" First Word:");
            String s1 = Console.ReadLine();
            Console.WriteLine(" Second Word:");
            String s2 = Console.ReadLine();
            if(s1 == s2)
        {
                Console.WriteLine("Same.");
            }
            else
            {
                Console.WriteLine("The words are not Same.");
            }
            Console.ReadLine();

        }
    }
}
