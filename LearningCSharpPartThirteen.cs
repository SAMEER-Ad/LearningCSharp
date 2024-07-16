using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_PartThirteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //odd even split of 20 whole numbers
            //we list instead of array because we dont know the size of array initially
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {

                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }

            
            }
            Console.WriteLine("odd list: ");
            for (int i = 0; i <odd.Count; i++)
            {
                Console.WriteLine(odd[i]);
            }
            Console.WriteLine("even list: ");
            for (int i = 0; i < even.Count; i++)
            {
                Console.WriteLine(even[i]);
            }
            Console.ReadLine();

        }
    }
}
