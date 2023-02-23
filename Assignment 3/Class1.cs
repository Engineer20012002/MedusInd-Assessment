using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Sem { get; set; }
        public string Branch { get; set; }
        public int[] Marks { get; set; }

        public Student(int rollNo, string name, string @class, string semester, string branch) 
        {
            RollNo = rollNo;
            Name = name;
            Class = @class;
            Sem = semester;
            Branch = branch;

            GetMarks();
            DisplayData();
            DisplayResult();
        }
        public void GetMarks()  //For getting marks
        {
            Marks = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter marks for {0}:", i + 1);
                Marks[i] = int.Parse(Console.ReadLine());
            }
        }
        public void DisplayResult()
        {
            int totalMarks = 0;
            foreach (int mark in Marks)
            {
                totalMarks += mark;
            }

            double averageMarks = totalMarks / 5.0;

            if (Marks.Any(m => m < 35))
            {
                Console.WriteLine("Failed");
            }
            else if (averageMarks < 50)
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("Passed");
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("Roll No: {0}", RollNo);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Class: {0}", Class);
            Console.WriteLine("Semester: {0}", Sem);
            Console.WriteLine("Branch: {0}", Branch);

            Console.WriteLine("Marks:");


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject {0}: {1}", i + 1, Marks[i]);
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter student details:");
            Console.Write("Roll No: ");
            int rollNo = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Class: ");
            string @class = Console.ReadLine();

            Console.Write("Semester: ");
            string sem = Console.ReadLine();

            Console.Write("Branch: ");
            string branch = Console.ReadLine();

            Student stud = new Student(rollNo, name, @class, sem, branch);
            Console.Read();
        }
    }
}
