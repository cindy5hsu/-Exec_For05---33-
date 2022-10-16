using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //呈现1 - 20.若是3的倍数显示foo,若是5的倍数显示bar 若是15的 「但数显示foobar,其针显示数值
            for(int i = 1; i < 20; i++)
            {
                //檢查每個數字并且印出 data
                if(i % 3==0 && i % 5 == 0)
                {
                    Console.WriteLine("foobar\n");
                }
                else if(i%3 == 0)
                {
                    Console.WriteLine("foo\n");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("bar\n");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
