using System;
using System.Threading;

namespace Lecture_1_5_Medlev_Pavel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayTable = new int[3,50];
            int[] table = new int[100];  
            Random random = new Random();
            int k = 0;
            for (int i = 0; i<2; i++)
            {
                for (int j = 0; j < 50; j++)
                {

                    arrayTable[i, j] = random.Next(10,100);
                    Console.Write($"{arrayTable[i, j]} ");
                    table[k++] = arrayTable[i, j];

                }

                Console.WriteLine();
            }

            for (int i = 0; i<table.Length; i++)
            {
                for (int j = i+1; j<table.Length; j++)
                {
                    if (table[j] > table[i])
                    {
                        int a = table[i];
                        table[i] = table[j];
                        table[j] = a;

                    }
                }

            }

            Console.WriteLine("Result: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{table[i]} ");

            }


        }
    }
}