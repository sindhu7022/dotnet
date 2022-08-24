// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class multiplicationofnum
    {
        public static void Main()
        {
            int n1, n2, n3;


            Console.WriteLine("enter first number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sec number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            n3 = Convert.ToInt32(Console.ReadLine());
            int tot = n1 * n2 * n3;
            Console.WriteLine($"multiplication is {tot}");
        }
    }
}







