using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            String s = Console.ReadLine();
            String r = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r += s[i];
            }
            Console.WriteLine("The reverse of the Text is " + r);
            Console.ReadLine();

        }
    }
}
