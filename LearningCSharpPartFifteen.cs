using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpPartFifteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ab = sum("write something");
           
                
                Console.WriteLine(ab);
                Console.ReadLine();
        }

        static int sum(string name)
        {
            Console.WriteLine(name);
            string na = Console.ReadLine();
            if (int.TryParse(na,out int result))
            {
                int d = Convert.ToInt32(na);
                return d;
            }
            else
            {
                return 0;
            }
        }
        
    }
}
