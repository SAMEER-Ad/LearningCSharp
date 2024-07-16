using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_PartNine
{
    internal class Program
    {
        //to reverse array
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int num = arr.Length;
            int[] dummy =new int[num];
            num -= 1;
            
                for (int i = 0; i <= num; i++)
                {
                    dummy[i] = arr[num- i];
                }
                
            
            for (int i = 0; i <num+1; i++)
            {
                Console.WriteLine(dummy[i] +" ");
            }
            Console.ReadLine();

        }
    }
}
