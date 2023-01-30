using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Task
{
    internal class NandA
    {
        string name;
        int age;
        public NandA()
        {
            name = "Vishwa";
            age = 20;
        }
        public NandA(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public static void Main(string[] args)
        {
            NandA obj = new NandA();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age);
            NandA bobj = new NandA("Joy", 21);
            Console.WriteLine(bobj.name);
            Console.WriteLine(bobj.age);
        }

    }
}
