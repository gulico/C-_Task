using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入年份：");
            string year = Console.ReadLine();
            Console.WriteLine("请输入月份：");
            string month = Console.ReadLine();
            if (int.Parse(month) == 2)
            {
                bool Leap = false;
                if (int.Parse(year) % 4 == 0&&int.Parse(year)%100!=0)
                    Leap = true;
                else if(int.Parse(year)%400==0)
                    Leap=true;

                if (Leap)
                    Console.WriteLine("本月有29");
                else
                    Console.WriteLine("本月有28天");

            }
            else {
                if (int.Parse(month) <= 7)
                {
                    if (int.Parse(month) % 2 == 0)
                        Console.WriteLine("本月有30天");
                    else
                        Console.WriteLine("本月有31天");
                }
                else {
                    if (int.Parse(month) % 2 == 0)
                        Console.WriteLine("本月有31天");
                    else
                        Console.WriteLine("本月有30天");
                }
            }
            Console.ReadLine();

        }
    }
}
