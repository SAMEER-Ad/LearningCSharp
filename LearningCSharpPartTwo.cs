using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpPartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("write " + i + "th number");
                string dummy = Console.ReadLine();
                arr[i] = Convert.ToInt32(dummy);
                
            }
            for (int i = 0; i < arr.Length; i++) { 
            
              Console.WriteLine("the "+i+"th number is "+arr[i]);
            
            }
            
            Console.ReadLine();
          
        }
    }
}
