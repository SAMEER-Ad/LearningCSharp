using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpPartSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            //to reverse string
                        Console.WriteLine("write a string:");
                        string val = Console.ReadLine();
                        int strln = val.Length;
                        Console.WriteLine("lengts of string is "+strln+"and reversed string is: ");
                        while (strln >0) {

                            Console.Write(val[strln-1]);
                            strln--;

                        }

                        Console.ReadLine();*/


            bool val = false;
            while (val != true)
            {
                Console.WriteLine("type first password: ");
                string p1 = Console.ReadLine();

                if (p1.Length == 0)
                {
                    Console.WriteLine("this is empty type it again ");
                    Console.WriteLine();
                    while (p1.Length == 0)
                    {
                        Console.WriteLine("type first password: ");
                       p1 = Console.ReadLine();
                    }
                }
                Console.WriteLine("type  second password: ");
                string p2 = Console.ReadLine();
                if (p2.Length == 0)
                {
                    Console.WriteLine("this is empty type it again ");
                    while (p2.Length == 0)
                    {
                        Console.WriteLine("type second  password: ");
                        p2 = Console.ReadLine();
                    }
                }

                if (p1 == p2)
                {
                    Console.WriteLine("password match");
                    val = true;
                }
                else
                {
                    Console.WriteLine("password didnt match");
                    val = false;
                    Console.WriteLine("-----again-----");
                }

            }
            Console.ReadLine();

        }
    }
}
