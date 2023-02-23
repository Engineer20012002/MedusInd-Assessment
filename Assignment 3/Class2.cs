using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Class2
    {
       
            static void Main(string[] args)
            {
                Console.WriteLine("Enter your first name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter your last name:");
                string lastName = Console.ReadLine();

                 Class2 a = new Class2();
                Display(firstName.ToUpper(), lastName.ToUpper());
            }

            public static void Display(string firstName, string lastName)
            {
                Console.Write(firstName);
                Console.Write(lastName);
                Console.Read();
            }
        }
    }

