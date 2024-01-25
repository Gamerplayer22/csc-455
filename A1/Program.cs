using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csc_455_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            string x= "0";
            int y = 0;

            while (choice == 1)
            {
                Console.WriteLine("Main menu");
                Console.WriteLine("1. random number");
                Console.WriteLine("2. today`s date");
                Console.WriteLine("3. list of dinosaurs");
                Console.WriteLine("4. string magic");
                Console.WriteLine("5. exit");
                Console.WriteLine("Choose 1-5:");
                x = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                if (x == "1") 
                {
                    Random rnd = new Random();
                    Console.WriteLine("The random number: {0}",rnd.Next(10)+1);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                if (x == "2") 
                {
                    DateTime thisDay = DateTime.Today;
                    Console.WriteLine("Today's date: {0}",thisDay.ToShortDateString());
                    Console.WriteLine();
                    Console.WriteLine();
                }
                if (x == "3") { }
                if (x == "4") { }
                if (x == "5") { choice = 0; }
            }
            Console.WriteLine("Press enter to leave...");
            Console.ReadLine();
        }
    }
}