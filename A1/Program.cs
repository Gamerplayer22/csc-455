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

                if (x == "3") 
                {
                    List<string> dinosaurs = new List<string>();
                    dinosaurs.Add("Gorgosaurus");
                    dinosaurs.Add("Allosaurus");
                    dinosaurs.Add("Aardonyx");
                    dinosaurs.Add("Megalosaurus");
                    dinosaurs.Add("Abrosaurus");
                    dinosaurs.Add("Homalocephale");
                    dinosaurs.Add("Alvarezsaurus");
                    dinosaurs.Add("Datousaurus");
                    dinosaurs.Add("Ammosaurus");
                    dinosaurs.Add("Capitalsaurus");

                    Console.WriteLine("unordered list: ");
                    foreach (string d in dinosaurs)
                        Console.WriteLine(d);
                    Console.WriteLine();
                    Console.WriteLine("ordered list: ");

                    var result = dinosaurs.OrderBy(n=>n);

                    foreach(var d in result)
                        Console.WriteLine(d);
                    Console.WriteLine();
                    Random rnd = new Random();                    
                    Console.WriteLine("Random dinosaur picked: {0}", dinosaurs[rnd.Next(10)]);
                    Console.WriteLine();
                    Console.WriteLine();
                }

                if (x == "4") { }
                if (x == "5") { choice = 0; }
            }
            Console.WriteLine("Press enter to leave...");
            Console.ReadLine();
        }
    }
}