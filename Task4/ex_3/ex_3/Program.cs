using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3
{
    class Program
    {
        class A {
            private static int staticNumber;
            private int number = 0;
            static A(){
                staticNumber = 50;
            }
            public bool Input() {
                string input = Console.ReadLine();
                if (input.ToList().Any(i => "0123456789".ToList().All(n => i != n)))
                {
                    Console.WriteLine("Bad input!");
                    staticNumber = 100;
                    number = 100;
                    return false;
                }
                else {
                    int ans = int.Parse(input);
                    staticNumber = ans;
                    number = ans;
                    return true;
                }
            }
            public void print() {
                Console.WriteLine("staticNumber = " + staticNumber);
                Console.WriteLine("number = " + number);
            }
        }
        static void Main(string[] args)
        {
            A a = new A();
            a.print();
            //12eed
            a.Input();
            a.print();
            //123
            a.Input();
            a.print();
            Console.Read();
        }
    }
}
