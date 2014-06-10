using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuzlaHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudent = 0;
            int totalStudents = 6;
            String[] studentNames = new String[6];
            String firstName;
            String lastName;

            Console.WriteLine("Homework by Sandy Smajic");
            while (countStudent < totalStudents)
            {
                Console.WriteLine("Enter Student Name: ");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter Student Last Name: ");
                lastName = Console.ReadLine();

                studentNames[countStudent] = firstName + " " + lastName;
                countStudent++;
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Total {0} students is entered", totalStudents);
            Console.WriteLine("");

            foreach (string s in studentNames)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");
            Array.Sort(studentNames);
            Console.WriteLine("Stored Students");
            Console.WriteLine("");

            foreach (string s in studentNames)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}