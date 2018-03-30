/*
 * 题目描述：
 * 设A[1…..n]是一个包含n个不同数的数组，
 * 如果在i<j的情况下，有A[i]>A[j],则（i,j）就称为A中的一个逆序对。
 * 请编写程序，
 * 根据用户输入的正整数n(n>=2)和n个不同的数，
 * 求出数组A[n]的逆序对个数。
 * 其中，第一行输入数组包含的元素个数n，
 * 第二行输入n个不同的数（以逗号分隔）。
 * 假设有数组A[10]，给数组输入10个数，则
 * 
 * 样例输入：
 * 10
 * 1，2，3，6，4，5，7，8，9，10
 * 样例输出：
 * 2
 */

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
            int num = int.Parse(Console.ReadLine().Trim());
            while(num>0){
                int [] array = new int[num];
                string str = Console.ReadLine().Trim();

                string[] temp = new string[num];
                temp = str.Split('，');
                for (int i = 0; i < num; i++) {
                    array[i] = int.Parse(temp[i]);
                }
                int sum=0;
                for(int i=1;i<num;++i){
                    for(int j=i-1;j>=0;--j){
                        if(array[i]<array[j])
                            sum++;
                    }
                }
                Console.WriteLine(sum);
                num = int.Parse(Console.ReadLine());
            }
        }
 
    }
}
