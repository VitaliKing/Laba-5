using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] A = new int[n, m];
            Random R = new Random();
            int sum = 0;
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = R.Next(-4, 5);
                    Console.Write("{0}\t", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Введите номер строки: ");
            int Q = int.Parse(Console.ReadLine());
            Q--;
            for (int j = 0; j < m; j++)
            {
                sum += A[Q, j];
            }
            Console.WriteLine("Сумма в строке: {0}", sum++);
            Console.ReadKey();
        }
    }
}
