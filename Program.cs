using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[10, 10];
            Random R = new Random();
            int mini = 0;
            int minj = 0;
            Console.WriteLine("Массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    A[i, j] = R.Next(-20, 20);
                    Console.Write("{0}\t", A[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (A[mini, minj] > A[i, j])
                    {
                        mini = i;
                        minj = j;
                    }
                }
            }
            minj++;
            mini++;
            Console.WriteLine("Номер строки: {0}, номер столбца {1}", mini, minj);
            Console.ReadKey();
        }
    }
}
