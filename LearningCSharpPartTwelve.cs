using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_PartTwelve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dict = new Dictionary<string,int>();
            dict.Add("samir", 12);
            dict.Add("hari", 45);
            dict.Add("aakriti", 435);
            dict.Add("ram", 34);
            dict.Add("sita", 43);
            dict.Add("pranisha", 12);
            //dict.Add("pranisha", 112);doesnt work
            /*             //correct vay to declare : Dictionary<int, string> dict1 = new Dictionary<int,string>();
                        //dict1.Add(12, "pranisha");*/


            /*            for (int i = 0; i < dict.Count; i++)
                        {
                           Console.WriteLine(dict.ElementAt(i)); //for output

                        }*/
            Console.WriteLine("write to search");
            string val = Console.ReadLine();
            if (dict.ContainsKey(val))
            {
                Console.WriteLine($" {val} {dict[val]} exists.");
            }
            else
            {
                Console.WriteLine($" {dict[val]} does not exist.");
            }

            Console.ReadLine();
        }
    }
}
