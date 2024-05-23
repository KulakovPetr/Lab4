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
        static long[,] MatrixC;
        static Random rnd = new Random();
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
            
            long summ = 0;
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
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
            MatrixB = new int[RowCount, ColumnCount]; 
            MatrixC = new long[RowCount, ColumnCount];
            
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    MatrixB[i, j] = rnd.Next(int.MinValue, int.MaxValue);
                    MatrixC[i, j] = (long)MatrixA[i, j]+ MatrixB[i, j];
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
                for (int j = 0; j < ColumnCount; j++)
                {
                    Console.Write($"{m[i, j]}, ");
                }
                Console.Write("\n");
            }
        }
        static void ShowMatrix(long[,] m)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    Console.Write($"{m[i, j]}, ");
                }
                Console.Write("\n");
            }
        }
    }
}
