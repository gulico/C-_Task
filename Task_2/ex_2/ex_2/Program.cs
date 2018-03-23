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
            int[] arr = new int[10] { 11,33,44,21,5,7,9,10,40,35};
            bool[] flag = new bool[10];
            for (int i=0; i < 10; i++)
            {
                flag[i] = false;
            }
            int sum = 5;
            int cnt = 0;
            string ans = "" ;
            while (sum>0)
            {
                int ramdom = new Random(cnt).Next(0,9);
                cnt++;
                if (flag[ramdom] == false) {
                    flag[ramdom] = true;
                    sum--;
                    ans = ans+" "+arr[ramdom];
                }
            }
            Console.WriteLine(ans);
            Console.Read();
        }
    }
}
