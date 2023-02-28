using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Man
    {
        protected string Name { get; set; }
        protected string Address { get; set; }
         
        public Man(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
    public class Sanjay  : Man
    {
        string RegisterNo { get; set; }
        double Fees { get; set; }
        string Specialization { get; set; }

        public Sanjay(string name, string address, string regNo, double fees, string specification)
            : base(name, address)
        {
            RegisterNo = regNo;
            FeesCharge = fees;
            Specialization = specification
        }

        public void ShowData()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Name of the man: " + Name);
            Console.WriteLine("Address of the man: " + Address);
            Console.WriteLine("Registration number of the man : " + RegNo);
            Console.WriteLine("Fees Charged for the man: " + FeesCharge);
            Console.WriteLine("Specification of the man: " + Specialization);
            Console.Read();
        }
    }

    public class engineer
    {
        public static void Main()
        {
            Console.Write("Enter the name of the Engineer: ");
            string name = Console.ReadLine();

            Console.Write("Enter the address of the Engineer: ");
            string address = Console.ReadLine();

            Console.Write("Enter the registration number of the Engineer: ");
            string registerNo = Console.ReadLine();

            Console.Write("Enter the fees charged by the Engineer: ");
            double fees = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the specialization of the doctor: ");
            string specialization = Console.ReadLine();

            Doctor doctor = new Doctor(name, address, registerNo, fees, specialization);
            doctor.ShowData();
        }
    }

}