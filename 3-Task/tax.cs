using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Task
{
    internal class tax
    {
        class BaseClass
        {
            public void CalculateTax()
            {
                double vat = 0.2;
                double price = 100;
                double tax = price * vat;
                Console.WriteLine("VAT: " + tax);
            }
        }

        class DerivedClass : BaseClass
        {
            public new void CalculateTax()
            {
                double gst = 0.12;
                double price = 100;
                double tax = price * gst;
                Console.WriteLine("GST: " + tax);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                BaseClass baseClass = new BaseClass();
                baseClass.CalculateTax();

                DerivedClass derivedClass = new DerivedClass();
                derivedClass.CalculateTax();

                Console.ReadLine();
            }
        }

    }
}
