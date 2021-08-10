using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayTable = new int[3,35];
            int[] table = new int[106];  

            var random = new Random();
            var k = 0;

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 35; j++)
                {
                    arrayTable[i, j] = random.Next(10, 100);
                    Console.Write(arrayTable[i, j]);
                    table[k++] = arrayTable[i, j];
                }

                Console.WriteLine();
            }

            for (var i = 0; i < table.Length; i++)
            {
                for (var j = i + 1; j < table.Length; j++)
                {
                    if (table[j] > table[i])
                    {
                        var a = table[i];
                        table[i] = table[j];
                        table[j] = a;
                    }
                }
            }

            Console.WriteLine($"Result: {string.Join(", ", table)}");
        }
    }
}