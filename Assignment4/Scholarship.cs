using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class scholarship
    {
        public int total;
        public float fees;

        public float Merit(int x, float y)
        {
            if (x >= 70 && x <= 80)
            {
                return (y * 20) / 100;
            }
            else if (x > 80 && x <= 90)
            {
                return (y * 30) / 100;
            }
            else if (x > 90)
            {
                return (y * 50) / 100;
            }
            else
            {
                return 0;
            }
        }
        static void Main(String[] args)
        {
            scholarship a = new scholarship();

            Console.WriteLine("Please Enter Total Marks: ");
            a.total = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Fees: ");
            a.fees = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Scholarship Amount is: " + a.Merit(a.total, a.fees));
            Console.ReadLine();
        }
    }

}