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
    public class Engineer : Man
    {
        string RegisterNo { get; set; }
        double Fees { get; set; }
        string Specification { get; set; }

        public Engineer(string name, string address, string registerNo, double fees, string specification)
            : base(name, address)
        {
            RegisterNo = registerNo;
            Fees = fees;
            Specification = specification;
        }

        public void ShowData()
        {
            
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Registration number: " + RegisterNo);
            Console.WriteLine("Fees Charged: " + Fees);
            Console.WriteLine("Specialization: " + Specification);
            Console.Read();
        }
    }

    public class engineer
    {
        public static void Main()
        {
            Console.Write("Enter the name of the doctor: ");
            string name = Console.ReadLine();

            Console.Write("Enter the address of the doctor: ");
            string address = Console.ReadLine();

            Console.Write("Enter the registration number of the doctor: ");
            string registerNo = Console.ReadLine();

            Console.Write("Enter the fees charged by the doctor: ");
            double fees = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the specialization of the doctor: ");
            string specification = Console.ReadLine();

            Engineer doctor = new Engineer(name, address, registerNo, fees, specification);
            doctor.ShowData();
        }
    }

}