using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileio64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Student\Desktop\number.txt", input);
            string fileRead = File.ReadAllText(@"C:\Users\Student\Desktop\number.txt");
            Console.WriteLine("Here is what you're file contains: " + fileRead);
            Console.ReadLine();

        }
    }
}
