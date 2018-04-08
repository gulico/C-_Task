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
            Student stu1 = new Student();
            stu1.Name = "赵四";
            stu1.Age = 28;
            stu1.Sex = "男";
            stu1.SetAcores(98,99,100);
            Student stu2 = new Student("张三", 12, "男");
            stu2.SetAcores(78, 98, 80);
            Student stu3 = new Student("李四", 15, "女",45,60,78);
            Console.WriteLine(stu1.Name + "的平均成绩为："+stu1.GetAverage());
            Console.WriteLine(stu2.Name + "的平均成绩为：" + stu2.GetAverage());
            Console.WriteLine(stu3.Name + "的平均成绩为：" + stu3.GetAverage());
            Console.Read();
        }
    }
    public class Person {
        public string Name = "";
        public int Age = 0;
        public string Sex = "未知";
    }
    public class Student :Person{
        public double Score1 = 0;
        public double Score2 = 0;
        public double Score3 = 0;
        public Student() {}
        public Student(string newName,int newAge,string newSex) {
            Name = newName;
            Age = newAge;
            Sex = newSex;
        }
        public Student(string newName, int newAge, string newSex, double s1, double s2, double s3)
        {
            Name = newName;
            Age = newAge;
            Sex = newSex;
            this.SetAcores(s1, s2, s3);
        }
        public void SetAcores(double s1,double s2,double s3) {
            Score1 = s1;
            Score2 = s2;
            Score3 = s3;
        }
        public double GetAverage() { 
            double avg;
            avg = (Score1 + Score2 + Score3) / 3.0;
            return avg;
        }
    }
}
