using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 4;
            int num = 1;
            for (; cnt >=0; --cnt, num += 2){
                int cnttemp = cnt;
                while (cnttemp > 0)
                {
                    Console.Write(" ");
                    cnttemp--;
                }
                int numtemp = num;
                while (numtemp > 0)
                {
                    Console.Write("*");
                    numtemp--;
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
