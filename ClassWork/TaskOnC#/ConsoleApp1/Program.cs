using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int n = 17;
            int i = 2;
            int count = 0;
            while (i <= n)
            {
                if (i == n)
                {
                    count++;
                    break;

                }
                else
                {
                    i *= 2 ;
                }
            }
            if (i > n)
            {
                Console.WriteLine("quvvet deyil");
            }
            Console.WriteLine(count);*/
            //TASK1
            /* int eded = 4;
             int ededUstu = 3;
             int x = eded;
             int i = 2;
             int sum = 0;
             while (i <= ededUstu) 
             {
                 eded = eded * x;
                 i++;
             }
             if (i > ededUstu) 
             {
                 Console.WriteLine(eded);
             }
             */
            //TASK2
            /* int[] array = { 12, 7, 8, 9, 10,11,12 };
             int count = 0;
             int i;
                  for (i = 0; i < array.Length; i++)
                  {
                      if (i % 2 == 0) 
                      {
                          count++;

                      }
                  }
             Console.WriteLine(count);*/
            //TASK3
            /*int[] array = { 0, 1, 2, 3, 4, 5, 6 };
            int number = 9;
            int i;
                for (i = 0; i < array.Length; i++) 
                {
                    if (array[i] > number) 
                    {
                    Console.WriteLine(array[i]>number);
                    break;
                    
                    }
                else Console.WriteLine("Yoxdu");
                break;
            }*/
            //TASK4

            /* int[] array = { 1, 5, 6, 8, 4, 6, 12 };
             int i;
             int sum = 0;
                 for (i = 1; i < array.Length; i += 2)  
                 {
                 sum = sum + array[i];

                 }
             Console.WriteLine(sum);*/
            //TASK5
        }
    }
}
