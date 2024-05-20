using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static int RowCount;
        static int ColumnCount;
        static int[,] MatrixA;
        static int[,] MatrixB;
        static int[,] MatrixC;
        static void Main(string[] args)
        {
            Console.WriteLine("Случайная матрица");
            Task1();
            Console.WriteLine("Сложение матриц");
            Task2();
            Console.ReadKey();
        }
        static void Task1()
        {
            Console.WriteLine("Введите количество строк в матрице");
            RowCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в матрице");
            ColumnCount = int.Parse(Console.ReadLine());
            MatrixA = new int[RowCount, ColumnCount];
            Random rnd = new Random();
            long summ = 0;
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    MatrixA[i, j] = rnd.Next(int.MinValue, int.MaxValue);
                    summ += MatrixA[i, j];
                }
            }
            ShowMatrix(MatrixA);
            Console.WriteLine($"Сумма элементов матрицы {summ}");
        }

        static void Task2()
        {
            Random rnd = new Random();
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    MatrixB[i, j] = rnd.Next(int.MinValue, int.MaxValue);
                    MatrixC[i, j] = MatrixA[i, j]+ MatrixB[i, j];
                }
            }
            Console.WriteLine($"Матрица A");
            ShowMatrix(MatrixA);
            Console.WriteLine($"Матрица B");
            ShowMatrix(MatrixB);
            Console.WriteLine($"Матрица C");
            ShowMatrix(MatrixC);
        }



        static void ShowMatrix(int[,] m)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    Console.Write($"{m[i, j]}, ");
                }
                Console.Write("\n");
            }
        }
    }
}
