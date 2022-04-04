using System;
using ExtensionMethods;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            Console.WriteLine(num1.IsOdd());
            int num2 = 2;
            Console.WriteLine(num2.IsOdd());
            Console.WriteLine(num1.IsEven());
            Console.WriteLine(num2.IsEven());
            string txt = "asdh6";
            Console.WriteLine(txt.DoesContainDigit());
            string txt1 = "ahdadasdk";
            txt1.ToCapitalize();
            string txt2 = "a";
            txt2.ToCapitalize();
            string txt3 = "A";
            txt3.ToCapitalize();
            Console.WriteLine("=============");
            string txt4 = "sfafa";
            foreach (var item in txt4.GetValueIndexes('a'))
            {
                Console.WriteLine(item);
            }
        }
    }
}
