using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите количество строк n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов m: ");
            int m = int.Parse(Console.ReadLine());
            if (m > 1 && n > 1)
            {
                int[,] A = new int[n, m];
                Random R = new Random();
                Console.WriteLine("Таблица:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        A[i, j] = R.Next(-15, 16);
                        Console.Write("{0}\t", A[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.Write("Введите Q: ");
                int Q = int.Parse(Console.ReadLine());
                int sum = 0;
                int c = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (A[i, j] > Q)
                        {
                            sum += A[i, j];
                            c++;
                        }
                    }
                }
                if (c == 0)
                {
                    Console.WriteLine("Нет элементов больше {0}", Q);
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Среднее арифметическое чисел больше {0} = {1}", Q, sum / c);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Массив не имеет смысла");
                Console.ReadKey();
                return;
            }
        }
    }
}
