using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_1
{
    class Program
    {
        static void func1()//第一种方法
        {
            Console.Write("请输入一个字符串：");
            string str = Console.ReadLine();
            string str2 = str.Replace("ab","cd");
            Console.WriteLine("将ab替换为cd之后的字符串为：" + str);
            int count = (str.Length - str.Replace("ab", "").Length)/2;
            Console.WriteLine("共替换了" + count + "次。");
        }
        static void func2() { //第二种方法
            Console.Write("请输入一个字符串：");
            string str = Console.ReadLine();
            string str2 = "ab";
            int index;
            int count = 0;
            while((index = str.IndexOf(str2))>=0){
                str = str.Remove(index, str2.Length);
                str = str.Insert(index, "cd");
                count++;
            }
            Console.WriteLine("将ab替换为cd之后的字符串为：" + str);
            Console.WriteLine("共替换了" + count + "次。");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("第一种方式");
            func1();
            Console.WriteLine("第二种方式");
            func2();
            Console.ReadLine();
        }
    }
}
