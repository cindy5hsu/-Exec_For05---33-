using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                int i, fact = 1, number;
                Console.Write("請輸入數字: ");
                number = int.Parse(Console.ReadLine());
                for (i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                Console.Write("階乘 " + number + " 是: " + fact);
        }

    }
}

