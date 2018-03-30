/*
 * 题目描述：
 * 从键盘接收一个字符串（不多于80个字符），
 * 将其中的数字字符按原顺序组成一个新字符串，
 * 将其中的英文字母都用大写按原顺序组成另一个新字符串，
 * 然后再输出这两个新字符串，每个一行。
 * 如果原字符串中没有数字字符或没有英文字母，
 * 则输出"There are not digits."或"There are not letters." 。
 * 当接收的字符串为”**”时程序结束。
 * */

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
            string str; 
            str = Console.ReadLine();
            while (String.Compare(str, "**") != 0)
            {
                string digits="";//数字
                string letters="";//字母
                foreach (char temp in str) {
                    if (temp >= '0' && temp <= '9')
                    {
                        digits = String.Concat(digits, temp);
                    }
                    else if((temp>='a'&&temp<='z')||(temp>='A'&&temp<='Z'))
                    {
                        letters = String.Concat(letters, temp);
                    }
                }
                
                letters = letters.ToUpper();
                if (digits.Length == 0)
                {
                    Console.WriteLine("There are not digits.");
                }
                else { 
                    Console.WriteLine(digits);
                }
                if (letters.Length == 0)
                {
                    Console.WriteLine("There are not digits.");
                }
                else
                {
                    Console.WriteLine(letters);
                }
                str = Console.ReadLine();
            }
        }
    }
}
