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
            byte[] arr = new byte[10];
            for (int i = 0; i < 10; i++)
            {
               arr[i] = (byte)(new Random(i).Next(0, 255));
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("arr[");
                Console.Write(i);
                Console.Write("]=");
                Console.WriteLine(arr[i]);
            }
            Console.Read();

        }
    }
}
