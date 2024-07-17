//works but
//not a selection short 
//lots of sonfusion 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionShortingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2,6, 9, 7, 4,5,6,43,54,64,65 };
            //done by me i am the great because it is most easier than youtubes once
            for (int j = 0; j < arr.Length; j++)
            {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i+1]){
                    int min;
                    min=arr[i+1];
                    arr[i+1] = arr[i];
                    arr[i] = min;


                }
            }
            }

            for (int i = 0; i <arr.Length; i++)
            {
                Console.WriteLine(arr[i] +" ");
            }
            Console.ReadLine();
        }
    }
}
