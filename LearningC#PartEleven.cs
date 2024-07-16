using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_Part_Eleven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //understanding of list
            int[] arr = { 1, 2, 3, 4, 5 };
            List<int> lliisstt = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                lliisstt.Add(num);
            }

            for (int i = 0; i <lliisstt.Count; i++)
            {
                Console.WriteLine(lliisstt[i]);

            }
            Console.ReadLine();
        }
    }
}
