using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Multi
    {
        public static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("multiplication table");
            Console.WriteLine("enter the table:");
            n=Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=20;i++)
            {
                Console.WriteLine("{0} * {1} = {2}",n,i,n*i);
            }
        }
    }
}
