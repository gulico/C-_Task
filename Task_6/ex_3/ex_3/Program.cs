/*
 * 3、	使用字典Dictionary<string，int>保存班级信息（班级号，人数），
 * 自行添加若干成员，
 * 试获取“10-5”班和“10-6”班的人数之和。
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> d1 = new Dictionary<string,int>();
            d1.Add("10-5", 50);
            d1.Add("10-6", 32);
            d1.Add("10-1", 40);
            d1.Add("10-2", 60);
            int sum = d1["10-5"] + d1["10-6"];
            Console.WriteLine("10-5班和10-6班人数之和为：" + sum);
            Console.ReadLine();
        }
    }
}
