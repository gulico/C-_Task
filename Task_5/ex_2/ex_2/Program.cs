using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2
{
    class Program
    {
        class Digit {
            private char Number;
            public void Input(){
                Console.Write("请输入一个0-9的数字：");
                this.Number = Convert.ToChar(Console.ReadLine().Trim());
            }
            public void Output() {
                Console.WriteLine("Number的值为：" + Number);
            }
            public char GetNumber() {
                return Number;
            }
        }
        class MultiDigit : Digit{ 
            private char[] MultiNumber = new char[2];
            public void Input() {
                Console.Write("请输入一个0-99的数字：");
                string str = Console.ReadLine().Trim();
                this.MultiNumber = str.ToCharArray(0, str.Length);
                    
            }
            public void Input(Digit d1,Digit d2)
            {
                MultiNumber[0] = d1.GetNumber();
                MultiNumber[1] = d2.GetNumber();
            }
            public void Output()
            {
                Console.WriteLine("Number的值为：" + this.MultiNumber[0]+this.MultiNumber[1]);
            }
            public char[] Output(int flag)
            {
                  return MultiNumber;
            }
        }
        static void Main(string[] args)
        {
            Digit d1 = new Digit();
            d1.Input();
            Console.WriteLine("d1：");
            d1.Output();
            Digit d2 = new Digit();
            d2.Input();
            Console.WriteLine("d2：");
            d2.Output();
            MultiDigit d3 = new MultiDigit();
            d3.Input();
            Console.WriteLine("d3：");
            d3.Output();

            MultiDigit d4 = new MultiDigit();
            d4.Input(d1,d2);
            Console.WriteLine("d4：");
            d4.Output();
            Console.WriteLine("第二种output：" + d4.Output(1)[0]+d4.Output(0)[1]);
            Console.ReadLine();
        }
    }
}
