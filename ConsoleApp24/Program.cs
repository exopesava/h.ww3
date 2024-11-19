using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    public class Student
    {
        public string id;
        public string name;
        public double mark;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("Enter the number of students : ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Student is:");
                Console.Write("Enter the ID: ");
                string id = Console.ReadLine();
                Console.Write("Enter the name: ");
                string name = Console.ReadLine();
                Console.Write("Enter mark: ");
                double mark = double.Parse(Console.ReadLine());
                students.Add(new Student
                {
                    id = id,
                    name = name,
                    mark =
                mark
                });
            }
            Console.WriteLine("Students :");
            foreach (Student student in students)
            {
                if (student.mark >= 50)
                {
                    Console.WriteLine(student.name);
                }
            }
            Console.Read();
        }
    }
    }

