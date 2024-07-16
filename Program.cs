using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace learningcsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your name:");
            string name = Console.ReadLine();

            Console.Write("enter your age:");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);
            if (isagevalid(age))
            {
                Console.WriteLine("age is valid.");
            }
            else
            {
                Console.WriteLine("age is invalid.");
                return;
            }


            Console.Write("enter your phone number:");
            string phoneNumber = Console.ReadLine();
            if (IsValidPhoneNumber(phoneNumber))
            {
                Console.WriteLine("The phone number is valid.");
            }
            else
            {
                Console.WriteLine("The phone number is invalid.");
                return;
            }
            Console.ReadLine();
        }

        static bool IsValidPhoneNumber(string number)
        {
            if (number.Length == 10 && number.StartsWith("9"))
            {
                foreach (char c in number)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        static bool isagevalid(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
