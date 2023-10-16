/*Дан двумерный массив.
732
496
185

Отсортировать данные в нем по возрастанию.
123
456
789*/

using System.Collections;

namespace MatrixSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //дана матрица
            int[,] matrix = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            

            Console.WriteLine("--Было--");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }


            // создаём одномерный массив
            int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)]; 
            int indexArr = 0;

            //записываем значения матрици в одномерный массив
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    array[indexArr] = matrix[i, j];
                    indexArr++;
                }
            }

            //сортируем одномерный массив
            Array.Sort(array);
            indexArr = 0;
            Console.WriteLine();
            Console.WriteLine("--Стало--");

            //Перезаписываем значения матрицы, значениями из отсортированного одномерного массива
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = array[indexArr];
                    Console.Write(matrix[i, j]);
                    indexArr++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
