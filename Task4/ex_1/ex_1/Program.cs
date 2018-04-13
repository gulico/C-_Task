using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_1
{
    class Program
    {
        class Book
        {
            public string Name;
            public double Price;
            public string Press;
            public Book() { }
            public Book(string newName,double newPrice,string newPress) {
                this.Name = newName;
                this.Price = newPrice;
                this.Press = newPress;
            }
            public void Print() {
                Console.WriteLine("书名："+this.Name);
                Console.WriteLine("价格："+this.Price);
                Console.WriteLine("出版社：" + this.Press);
            }
        }
        static void Main(string[] args)
        {
            Book b1 = new Book("c#程序设计实用教程", 39.8, "人民邮电出版社");
            b1.Print();
            Console.Read();
        }
    }
}
