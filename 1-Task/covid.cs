using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task
{
    internal class covid
    {

        public static void Main(string[] args)
        {
            string ans;
            Console.WriteLine("Do you have travel hitory(y/n): ");
            ans = Console.ReadLine();
            if (ans != null && ans.Contains('y'))
            {
                Console.WriteLine("Do you have temperature(y/n): ");
                ans = Console.ReadLine();
                if (ans != null && ans.Contains('y'))
                {
                    Console.WriteLine("Do you have cough/cold(y/n): ");
                    ans = Console.ReadLine();
                    if (ans != null && ans.Contains('y'))
                    {
                        Console.WriteLine("You are adviced to Take a SWAB TEST");
                    }
                    else { Console.WriteLine("You are adviced to be in QUARENTINE "); }
                }
                else { Console.WriteLine("You are adviced to be in HOME QUARENTINE for 28days"); }

            }
            else { Console.WriteLine("You are SAFE from COVID-19"); }

        }


    }
}
