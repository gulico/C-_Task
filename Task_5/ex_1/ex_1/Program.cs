using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_1
{
    class Program
    {
        class Person {
            public string Name = "未命名";
            public int age = 0;
            public string sex = "未知";
        }
        class Student : Person{
            public double[] Scores = new double[5]{0,0,0,0,0};
            public Student() { }
            public Student(string newName, int newage, string newSex)
            {
                this.Name = newName;
                this.age = newage;
                this.sex = newSex;
            }
            public Student(string newName, int newage, string newSex, double[] newScores)
            {
                this.Name = newName;
                this.age = newage;
                this.sex = newSex;
                this.SetScores(newScores);
            }
            public void SetScores(double [] newScores){
                this.Scores = newScores;
            }
            public double GetAverage() {
                return this.Scores.Average();
            }
            public void PrintAverage() { 
                Console.WriteLine(this.Name+"的平均成绩为："+this.GetAverage());            }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("张三",19,"男");
            double[] scores2 = new double[5] { 30, 96, 40, 50, 60 };
            s2.SetScores(scores2);
            double [] scores3 = new double[5]{90,98,92,93,60};
            Student s3 = new Student("李四",20,"女",scores3);
            s1.PrintAverage();
            s2.PrintAverage();
            s3.PrintAverage();
            Console.Read();
        }
    }
}
