using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpPartFourteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array of miltiple
            int num = 7;
            int length = 5;
            int[] res = new int[length];
            for (int i = 1; i <= res.Length; i++)
            {
                res[i-1] = i*num;
            }
            foreach(int i in res)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
