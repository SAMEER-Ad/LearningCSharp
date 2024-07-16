using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpPartSixteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("write a name: ");
                name.Add(Console.ReadLine());
            }

            Console.WriteLine("Enter a name to check if it exists:");
            string nameToCheck = Console.ReadLine();
            bool exists = Issstue(nameToCheck, name, out int index);
            Console.WriteLine($"{exists} at position  {index}");
         Console.ReadLine();
        }           
        static bool Issstue(string s, List<string> name,out int index)
        {
            index = -1;
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].ToLower() == s.ToLower())
                {
                   index= i;
                    
                }

               
            }
           return index > -1;
        }

    }
}