using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TASK
{
    internal class Deserts
    {
        public static void Main()
        {

            ArrayList dsrts = new ArrayList();
            dsrts.Add("Browine");
            dsrts.Add("Waffle");
            dsrts.Add("Rasmalai");
            dsrts.Add("Donut");
            dsrts.Add("Gulab Jamun");

          

            FileStream fs = new FileStream("C:\\Inatech\\Deseerts.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (object i in dsrts)
            sw.WriteLine(i);
            sw.Flush();
            sw.Close();
            fs.Close();

           

            FileInfo info = new FileInfo("C:\\Inatech\\Deseerts.txt");
            Console.WriteLine("Creation Time : {0}", info.CreationTime);
            Console.WriteLine("Size : {0}", info.Length);



        }


    }
}
