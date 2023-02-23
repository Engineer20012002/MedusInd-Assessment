using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
            class Occurance
        {
            public static void Main()
            {
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();

                Console.WriteLine("Enter the letter to count :");
                char l = Console.ReadLine()[0];

                int count = CounttheOccurrences(input, l);
                Console.WriteLine($"The letter {l}  {count} times in the string.");
                Console.Read();
            }

            public static int CounttheOccurrences(string input, char let)
            {
                int count = 0;

                foreach (char i in input)
                {
                    if (i == let)
                    {
                        count++;
                    }
                }

                return count;

            }
        }
    }

