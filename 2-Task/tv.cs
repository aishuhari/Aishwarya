using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Task
{
    internal class tv
    {
        public static void Main()
        {
            string package;

            Console.WriteLine("Package A contains - South Special, Children's Club, Movies");
            Console.WriteLine("Package B contains - News, Sports, Movies, Regional");
            Console.WriteLine("Package C contains - Discovery, History, National");

            Console.WriteLine("Enter your Package:");

            package = Console.ReadLine();
            switch (package)
            {
                case "A":
                    Console.WriteLine("Rs. 250");
                    break;
                case "B":
                    Console.WriteLine("Rs.450");
                    break;
                case "C":
                    Console.WriteLine("Rs.350");
                    break;
                default:
                    Console.WriteLine("Enter the package of ur choice: ");
                    break;

            }
        }
    }
}
