using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpPartEighteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //refrence parameter
            int num = 10;
            iref(ref num);
            Console.WriteLine(num);
            Console.ReadLine();
        }
        static void iref(ref int num)
        {
            num = 30;
        }
    }
}
