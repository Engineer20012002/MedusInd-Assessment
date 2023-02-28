using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public abstract class Student
    {
        public string Name;
        public int idno;
        public double Grade;
        public abstract bool Ispassed(double grade);
    }

    class UG : Student
    {
        public override bool Ispassed(double grade)
        {
            if(grade > 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Graduate : Student
    {
        public override bool Ispassed(double grade)
        {
            if (grade > 80.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class student
    {
        static void Main(string[] args)
        {
            UG a = new UG();

            Console.Write(" name of the undergraduate student: ");
            a.Name = Console.ReadLine();

            Console.Write(" student ID: ");
            a.idno = Convert.ToInt32(Console.ReadLine());

            Console.Write(" grade for the course: ");
            a.Grade = Convert.ToDouble(Console.ReadLine());

            bool status = a.Ispassed(a.Grade);
            Console.WriteLine("Status for {0} with ID {1}: {2}", a.Name, a.idno, status);

            Graduate b = new Graduate();

            Console.Write(" name of the graduate student: ");
            b.Name = Console.ReadLine();

            Console.Write(" student ID: ");
            b.idno = Convert.ToInt32(Console.ReadLine());

            Console.Write(" grade for the course: ");
            b.Grade = Convert.ToDouble(Console.ReadLine());

            status = b.Ispassed(b.Grade);
            Console.WriteLine("Status for {0} with ID {1}: {2}", b.Name, b.idno, status);

            Console.ReadLine();
        }
    }
}