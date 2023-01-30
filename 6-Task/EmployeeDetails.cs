using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TASK
{
    internal class EmployeeDetails
    {
        public int EmplId { get; set; }
        public string? EmplName { get; set; }
        public string? Emplgender { get; set; }
        public int Emplage { get; set; }

        public void readfEmp()
        {
            FileStream emp = new FileStream("C:\\Inatech\\EmployeeDetails.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(emp);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
        }


        public static void Main(string[] args)
        {
            EmployeeDetails emp = new EmployeeDetails();
            Console.WriteLine("Enter Employee Name:");
            emp.EmplName = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender:");
            emp.Emplgender = Console.ReadLine();
            Console.WriteLine("Enter Employee ID:");
            emp.EmplId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Age:");
            emp.Emplage = Convert.ToInt32(Console.ReadLine());

            FileStream Emp = new FileStream("C:\\Inatech\\EmployeeDetails.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(Emp);
            sw.Write(emp.EmplName);
            sw.Write(emp.Emplgender);
            sw.Write(emp.Emplage);
            sw.Write(emp.EmplId);
            sw.Flush();
            sw.Close();
            Emp.Close();
            emp.readfEmp();
        }
        


    }
}
