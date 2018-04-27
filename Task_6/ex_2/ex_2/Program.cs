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
            double n;
            while (!double.TryParse(Console.ReadLine(), out n)) {
                Console.WriteLine("输入非法，请重新输入");
            }
            Console.WriteLine(string.Format("{0:N4}", n));
            Console.ReadLine();
        }
    }
}
