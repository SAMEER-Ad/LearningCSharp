using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharpPartThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write a number: ");
            var a = Console.ReadLine();
            int num = Convert.ToInt32(a);
            if (iseven(num))
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
            Console.ReadLine();
        }

        static bool iseven(int number1)
        {
            if(number1%2==0)
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
