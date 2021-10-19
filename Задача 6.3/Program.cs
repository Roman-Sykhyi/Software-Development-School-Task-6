using System;

namespace Задача_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix = new Matrix<int>(3, 3);

            for (int i = 0; i < matrix.value.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.value.GetLength(1); j++)
                {
                    matrix.value[i, j] = i + j;
                }
            }

            foreach (int n in matrix)
            {
                Console.Write(n + " ");
            }
        }
    }
}
