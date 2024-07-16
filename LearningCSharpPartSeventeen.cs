using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCSharpPartSeventeen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=30;
            asg(num,out num);
            Console.WriteLine(num);
            Console.ReadLine();
           
        }
        static void asg(int ab,out int num)
        {
            num = ab*30;
        }
    }
}
