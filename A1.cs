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
            int x = 0;

            while (choice!=1)
            {
                Console.WriteLine("Main menu");
                Console.WriteLine("1. random number");
                Console.WriteLine("2. today`s date");
                Console.WriteLine("3. list of dinosaurs");
                Console.WriteLine("4. string magic");
                Console.WriteLine("5. exit");
                Cosnole.WriteLine("Choose 1-5:");
                Console.ReadLine(x);
                if(x==1) { }
                if(x==2) { }
                if (x==3) { }
                if (x == 4) { }
                if( x==5) { choice = 0; }
            }
        }
    }
}