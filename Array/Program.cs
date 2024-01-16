using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //陣列求10個數字的平均值
            //Console.WriteLine($"請輸入10個數值");
            //double[] arrayforten = new double[10];
            //for (int i = 0; i < arrayforten.Length; i++)
            //{
            //    Console.Write($"第{i + 1}個數值為");
            //    arrayforten[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //double sum = 0;
            //double avg ;
            //foreach (double item in arrayforten)
            //{
            //    sum += item;
            //}
            //avg = sum / arrayforten.Length;
            //Console.WriteLine($"平均值為{avg}");
            //Console.ReadKey();

            //p.9 求10個數字的最大值
            //Console.WriteLine($"請輸入10個數值");
            //double[] maxarray = new double[10];
            //for (int i = 0; i < maxarray.Length; i++)
            //{
            //    Console.Write($"第{i + 1}個數值為");
            //    maxarray[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //double max = double.MinValue;
            //foreach (double item in maxarray)
            //{
            //    if (item > max)
            //    {
            //        max = item;
            //    }
            //}
            //Console.WriteLine($"這10個數最大值為{max}");
            //Console.ReadKey();

            //p.11 10個數字至A[ ]，再輸入x，判斷x是否存在於A陣列中，如果存在，輸出所在的(索引)
            //Console.WriteLine($"請輸入10個值");
            //int[] searcharry = new int[10];
            //for (int i = 0; i < searcharry.Length; i++)
            //{
            //    Console.Write($"第{i + 1}個數值為");
            //    searcharry[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine($"請輸入要找的值");
            //int x = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < searcharry.Length; i++)
            //{
            //    if (searcharry[i] == x)
            //    {
            //        Console.WriteLine($"{x}索引值為{i}");
            //        break;
            //    }
            //    if (i == searcharry.Length - 1)
            //    {
            //        Console.WriteLine($"不存在");
            //        break;
            //    }
            //}
            //Console.ReadKey();

            // p.15 二維陣列:第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣
            //int[,] arrayA = new int[2, 3];
            //int[,] arrayB = new int[2, 3];
            //int[,] arrayC = new int[2, 3];

            ////arrayA
            //Console.WriteLine($"請輸入A陣列的值");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"A陣列第{i + 1},{j + 1}個數值為");
            //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            ////arrayB
            //Console.WriteLine($"請輸入B陣列的值");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"B陣列第{i + 1},{j + 1}個數值為");
            //        arrayB[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            ////arrayC
            //Console.WriteLine($"相加後C陣列值為");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arrayC[i, j] = arrayA[i, j] + arrayB[i, j];
            //    }
            //}
            //foreach (int item in arrayC)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //p.17 兩個矩陣相乘
            //int[,] arrayA = new int[2, 3];
            //int[,] arrayB = new int[3, 1];
            //int[,] arrayC = new int[2, 1];

            ////arrayA
            //Console.WriteLine($"請輸入A陣列的值");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"A陣列第{i + 1},{j + 1}個數值為");
            //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            ////arrayB
            //Console.WriteLine($"請輸入B陣列的值");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 1; j++)
            //    {
            //        Console.Write($"B陣列第{i + 1}個數值為");
            //        arrayB[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            ////arrayC
            //Console.WriteLine($"相乘後C陣列值為");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 1; j++)
            //    {
            //        for (int z = 0; z < 3; z++)
            //        {
            //            arrayC[i, j] += arrayA[i, z] * arrayB[z, j];
            //        }
            //    }
            //}
            //foreach (int item in arrayC)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //p.20 ch5-1 10個數字讀入A陣列，然後逐一檢查此陣列，如A[i]>5，則令A[i]=A[i]-5，否則A[i]=A[i]+5

            //int[] arrayA = new int[10];
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    Console.Write($"第{i + 1}個數值為");
            //    arrayA [i]= Convert.ToInt32(Console.ReadLine());

            //    if (arrayA[i] > 5)
            //    {
            //        arrayA[i] -= 5;
            //    }
            //    else {
            //        arrayA[i] += 5;
            //    }
            //}
            //foreach (int item in arrayA)
            //{
            //    Console.WriteLine($"結果為{item}");
            //}
            //Console.ReadKey();

            //p.20 ch5-2 將10個數字讀入A陣列，對每一個數字，令A[i]=A[i]+i
            //int[] arrayA = new int[10];
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    Console.Write($"第{i + 1}個數值為");
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //    arrayA[i] += i;
            //}
            //foreach (int item in arrayA)
            //{
            //    Console.WriteLine($"結果為{item}");
            //}
            //Console.ReadKey();

            //p.20 ch5-3 將10個數字讀入A陣列，A[i]≥0，令B[i]=1，否則令B[i]=0
            //int[] arrayA = new int[10];
            //int[] arrayB = new int[10];
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    Console.Write($"第{i + 1}個數值為");
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());


            //    if (arrayA[i] >= 0)
            //    {
            //        arrayB[i] = 1;
            //    }
            //    else {
            //        arrayB[i] = 0;
            //    }
            //}
            //foreach (int item in arrayB)
            //{
            //    Console.WriteLine($"arrayB的數值結果為{item}");
            //}
            //Console.ReadKey();


            //p.20 ch5-4 將15個數字3×5的二維陣列A中，求每一行及每一列數字的和。
            int[,] arrayA = new int[3, 5];
            Console.WriteLine($"請輸入A陣列的值");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"A陣列第{i},{j}個數值為");
                    arrayA[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            //每一行(Column)
            
            for (int i = 0; i < 3; i++)
            {
                int colsum = 0;
                for (int j = 0; j < 5; j++)
                {
                    colsum += arrayA[i, j];
                }
                Console.WriteLine($"第{i + 1}行的和為：{colsum}");
            }
            //每一列(Row)
            
            for (int j = 0; j < 5; j++)
            {
                int rowsum = 0;
                for (int i = 0; i < 3; i++)
                {
                    rowsum += arrayA[i, j];
                }
                Console.WriteLine($"第{j + 1}列的和為：{rowsum}");
            }
            Console.ReadKey();

            //p.29 ch5-5 將15個數字3×5的二維陣列A中，求每一行及每一列數字的最小值
            //int[,] arrayA = new int[3, 5];

            //Console.WriteLine($"請輸入A陣列的值");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"A陣列第{i},{j}個數值為");
            //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //int[] min = new int [3];
            //for (int i = 0; i < 3; i++)
            //{
            //    int colmin = int.MaxValue;
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (arrayA[i, j] < colmin)
            //        {
            //            colmin = arrayA[i, j];
            //        }
            //    }
            //    min[i] = colmin;
            //    Console.WriteLine($"第{i + 1}列的最小值為: {colmin}");
            //}
            //int[] rmin = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    int rowmin = int.MaxValue;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (arrayA[j, i] < rowmin)
            //        {
            //            rowmin = arrayA[j, i];
            //        }
            //    }
            //    rmin[i] = rowmin;
            //    Console.WriteLine($"第{i + 1}行的最小值為: {rowmin}");
            //}
            //Console.ReadKey();

            //p.29 ch5-6 兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai+bi，i=1到i=5
            //int[] arrayA = new int[5];
            //int[] arrayB = new int[5];
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    Console.Write($"第a{i + 1}個數值為");
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < arrayB.Length; i++)
            //{
            //    Console.Write($"第b{i + 1}個數值為");
            //    arrayB[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    int result = arrayA[i] + arrayB[i];
            //    Console.WriteLine($"a{i + 1} + b{i + 1} = {result}");
            //}
            //Console.ReadKey();

            //p.29 ch5-7 兩組數字：a1,a2,…,a5和b1,b2,…,b5。令x為a中的最大值，令y為b中的最大值，求x與y中較小者
            //int[] arrayA = new int[5];
            //int[] arrayB = new int[5];
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    Console.Write($"a{i + 1}個值為:");
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int x = int.MinValue;
            //foreach (int item in arrayA)
            //{
            //    if (item > x)
            //    {
            //        x = item;
            //    }
            //}
            //Console.WriteLine($"arrayA最大值為{x}");
            //for (int i = 0; i < arrayB.Length; i++)
            //{
            //    Console.Write($"b{i + 1}個值為:");
            //    arrayB[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int y = int.MinValue;
            //foreach (int item in arrayB)
            //{
            //    if (item > y)
            //    {
            //        y = item;
            //    }
            //}
            //Console.WriteLine($"arrayB最大值為{y}");
            //if (x < y)
            //{
            //    Console.WriteLine($"最大值相比後的最小值為{x}");
            //}
            //else if (x == y)
            //{
            //    Console.WriteLine($"arrayA及arrayB兩者值一樣");
            //}
            //else
            //{
            //    Console.WriteLine($"arrayA及arrayB最大值相比後的最小值為{y}");
            //}
            //Console.ReadKey();
        }
    }
}
