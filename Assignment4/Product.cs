using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Sales
    {
        public int salesno { get; set; }
        public int productno { get; set; }
        public double Amount { get; set; }
        public DateTime DateofSale { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; private set; }

        public Salesinformation(int salesNo, int productNo, double price, DateTime dateofSale, int qty)
        {
            salesno = salesNo;
            productno = productNo;
            Amount = Amount;
            DateofSale = dateofSale;
            Quantity = quantity;
            Sales();
        }
        public void Sales()
        {
            TotalAmount = Quantity * Amount;
        }

        public void showData()
        {
            
            Console.WriteLine("Sales No of the product: " + salesno);
            Console.WriteLine("Product No of the product: " + productno);
            Console.WriteLine("Price of the product: " + Price);
            Console.WriteLine("Date of sale of the product: " + DateofSale);
            Console.WriteLine("Quantity of the product: " + Qty);
            Console.WriteLine("Total amount of the product: " + TotalAmount);
            Console.ReadLine();
        }
    }
    public class sales1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter sales no of the product: ");
            int salesno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter product no of the product: ");
            int productno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter price of the product: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter date of sale(dd-mm-yyyy) of the product: ");
            DateTime dateofsale = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter quantity of the product: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Sales sales = new Sales(salesno, productno, Amount, dateofsale, quantity);
            sales.showData();
        }
    }
}