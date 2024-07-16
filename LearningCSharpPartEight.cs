using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpPartEight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=5;
           string dummy;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter a number "+ i+" :");
                 dummy =  Console.ReadLine();
                int num=0;
                int.TryParse(dummy, out num);
                if (num == 0)
                {
                    Console.WriteLine("-------wrong input try again--------");
                    Console.Write("enter a number{0}: ", arr[i]);
                    dummy = Console.ReadLine();

                }

                arr[i] = Convert.ToInt32(dummy);

            }

            for (int i = 0; i < n; i++)
            {

                Console.Write(arr[i]+" ");

            }
            Console.ReadLine();
        }
    }
}
