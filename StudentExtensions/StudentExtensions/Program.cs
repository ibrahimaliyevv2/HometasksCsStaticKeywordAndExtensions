using System;
using ClassLibrary;
namespace StudentExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fullName;
            string groupNo;
            byte age;

            do
            {
                Console.WriteLine("Adinizi daxil edin:)");
                fullName = Console.ReadLine();
            } while (!fullName.CheckFullname());

            do
            {
                Console.WriteLine("Qrup nomrenizi daxil edin: (1 boyuk herf, 3 reqem)");
                groupNo = Console.ReadLine();
            } while (!groupNo.CheckGroupNo());

            Console.WriteLine("Yashinizi daxil edin:");
            age = Convert.ToByte(Console.ReadLine());

            Student student = new Student(fullName, groupNo, age);
            Console.WriteLine(student.FullName, student.GroupNo, student.Age);
        }
    }
}
