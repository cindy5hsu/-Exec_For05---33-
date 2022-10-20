using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用迴圈呈现指定的结果
            
            for(int i = 0; i < 5; i++)//使用for迴圈印出5行
            {
                for (int j = 1; j < 5-i; j++)//印圖案
                    Console.Write("+");
                //檢查 value & 印出圖案
                if (i != 4)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write(i+1);
                    }
                }
                else
                {
                    for(int j = 0; j < 4; j++)
                    {
                        Console.Write(i+1);
                    }
                }
                Console.WriteLine();

            }


        }
    }

    /////++++
}
