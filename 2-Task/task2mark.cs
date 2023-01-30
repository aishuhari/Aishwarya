using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Task
{
    internal class task2mark
    {
        public float percent(float tot)
        {
            float perc = (tot / 500) * 100;
            return perc;
        }
        public static void Main()
        {
            float tot = 0, perc;
            int[] ar = new int[5];
            Console.WriteLine("Enter the Marks obtained:");
            for (int i = 0; i < 5; i++)
                ar[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 5; i++)
                tot += ar[i];
            task2mark obj = new task2mark();
            perc = obj.percent(tot);
            Console.WriteLine("the total is: {0}", tot);
            Console.WriteLine("the percentage is: {0}", perc);

        }
    }
}
