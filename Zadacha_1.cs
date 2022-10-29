using System;

namespace ConsoleApp1
{
 class Printer
    {

        public void Print(string value,string value2)
        {
            Console.WriteLine("Your Name: " + value + " " + value2);
        }
       
    }
    class Program:Printer
    {
        private String Name;
        private String LastName;
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Enter your name: ");
            program.Name = Console.ReadLine();
            Console.WriteLine("Enter your lastname: ");
            program.LastName = Console.ReadLine();
            program.Print(program.Name,program.LastName);
        }
    }
}
