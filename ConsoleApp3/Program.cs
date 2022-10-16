using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 3, 3, 0, 0, 3, 0, 3, 0, 3};
            int l = a.Length;
            int sum = 0, temposum = 0;

            for (int i = 0; i < l; i++)
            {
                if (a[i] == 0)
                {
                    temposum = 0;
                    continue;
                }
                else if (a[i] == 3)
                {
                    temposum += a[i];
                    if (sum < temposum)
                    {
                        sum = temposum;
                    }
                }
            }
            Console.WriteLine(sum);

        }
    }

}
