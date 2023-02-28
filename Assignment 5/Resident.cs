using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public interface Student1
    {
        int idno { get; set; }
        string Name { get; set; }
        int Fees { get; set; }
        void ShowDetails();
    }
    public class DayScholar : Student1
    {
        public int idno { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Dayscholar Details");
            Console.WriteLine("id of the student: " + idno);
            Console.WriteLine(" Name of the student: " + Name);
            Console.WriteLine("Fees: " + Fees);
            Console.WriteLine();
        }
    }
    public class Resident : Student1
    {
        public int idno { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Resident Details of the student");
            Console.WriteLine(" ID of the student: " + idno);
            Console.WriteLine(" Name of the student: " + Name);
            Console.WriteLine("Fees: " + Fees);
            Console.WriteLine();
        }
    }
    class Interface
    {
        public static void Main()
        {
            DayScholar a = new DayScholar();
            
            Console.WriteLine(" Student Id: ");
            a.idno = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(" Student Name: ");
            a.Name = Console.ReadLine();

            Console.WriteLine(" fees amount: ");
            a.Fees = Convert.ToInt32(Console.ReadLine());

            a.ShowDetails();
            
            Resident b = new Resident();

            Console.WriteLine(" Student Id: ");
            b.idno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Student Name: ");
            b.Name = Console.ReadLine();

            Console.WriteLine(" fees amount: ");
            b.Fees = Convert.ToInt32(Console.ReadLine());

            b.ShowDetails();

            Console.Read();
        }
    }
}