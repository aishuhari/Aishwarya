﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Task
{
    internal class login
    {
        
       
            string email = "vrvicky911@gnail.com";
        string pass = "Brucelee@911";
        int pin = 0911;
        int pin_num = 0911;
        string Mid = "Vicky911";
        long mb = 9092219410;
        public void validate(string p1, string p2)
        {
            this.email = p1;
            this.pass = p2;
            if (p1 == email && p2 == pass)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect email or password!!!");
            }
        }
        public void validate(string p1, int p2)
        {
            this.Mid = p1;
            this.pin = p2;
            if (p1 == Mid && p2 == pin)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect email or password!!!");
            }
        }
        public void validate(long p1, int p2)
        {
            this.mb = p1;
            this.pin_num = p2;
            if (p1 == mb && p2 == pin_num)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect email or password!!!");
            }
        }

        public static void Main(string[] args)
        {
            login obj = new login();
            Console.WriteLine("Enter Login Credentials:");
            Console.Write("a.Login with Email id and password\t");
            Console.Write("b.Login with Membership id and pin\t");
            Console.WriteLine("c.Login with Mobile no and pin\t");
            string ch = Console.ReadLine();
            switch (ch)
            {
                case "a":
                    Console.WriteLine("Enter Email id:");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string pass = Console.ReadLine();
                    obj.validate(email, pass);
                    break;
                case "b":
                    Console.WriteLine("Enter Membership id:");
                    string Mid = Console.ReadLine();
                    Console.WriteLine("Enter pin:");
                    int pin = Convert.ToInt32(Console.ReadLine());
                    obj.validate(Mid, pin);
                    break;
                case "c":
                    Console.WriteLine("Enter mobile number:");
                    long mb = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter pin:");
                    int pin_num = Convert.ToInt32(Console.ReadLine());
                    obj.validate(mb, pin_num);

                    break;
                default:

                    break;




            }

        }
    }
}
