using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2
{
    class Program
    {
        class Course
        {
            public string Name;
            public enumTime Time; 
            public enum enumTime { 
                春季学期=0,
                秋季学期=0
            }
            private int Count;

            public static int Counter = 0;

            public Course() {
                Counter++;
                this.Name = "";
                this.Time = enumTime.春季学期;
                this.Count = 0;
            }
            public Course(string newName,enumTime newTime,int newConut) {
                Counter++;
                this.Name = newName;
                this.Time = newTime;
                this.Count = newConut;
                if (this.Count > 100 || this.Count < 0)
                    Console.WriteLine("选课人数范围0~100，请重新定义");
            }
            public void print() {
                Console.WriteLine("课程：" + this.Name);
                Console.WriteLine("开学时间：" + this.Time);
                Console.WriteLine("选课人数：" + this.Count);
                Console.WriteLine("全部课程数量：" + Counter);
            }
        }
        
        static void Main(string[] args)
        {
            Course c1 = new Course("C#", Course.enumTime.秋季学期, 101);
            c1.print();
            Course c2 = new Course("C++", Course.enumTime.春季学期, 80);
            c2.print();
            Console.Read();
        }
    }
}
