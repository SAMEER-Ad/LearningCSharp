using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LearningCSharpPartFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            bool suc= true;
            while (suc)
            {
                Console.WriteLine("write a number: ");
                string dummynum = Console.ReadLine();
                suc = int.TryParse(dummynum, out num);
                Console.WriteLine(num);
                if (num != 0)
                {
                    int abn = Convert.ToInt32(dummynum);
                    Console.WriteLine("the given number is: " + abn);
                    suc = false;
                }
                else
                {
                    Console.WriteLine("conversion failed");
                    /*num = 0;*/
                    suc = true;
                }


            }



            Console.ReadLine();

        }
    }
}
