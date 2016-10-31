using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
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
                        A[i, j] = R.Next(0, 2);
                        Console.Write("{0}\t", A[i, j]);
                    }
                    Console.WriteLine();
                }
                bool b = false;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < m - 1; j++)
                        if (A[i, j] + A[i + 1, j + 1] + A[i + 1, j] + A[i, j + 1] == 0 || A[i, j] + A[i + 1, j + 1] + A[i + 1, j] + A[i, j + 1] == 4)
                        {
                            b = true;
                        }
                }
                if (b == true)
                {
                    Console.WriteLine("Данная таблица несимпатичная");
                }
                else
                {
                    Console.WriteLine("Данная таблица симпатичная");
                }
            }
            else
            {
                Console.WriteLine("Такая таблица не может пройти проверку");
            }
                Console.ReadKey();
            }
        }
    }

