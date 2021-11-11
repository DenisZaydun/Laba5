using System;

namespace Task_3
{
    class IdentityMatrix : Matrix
    {
        public override void ReadMatrix()
        {
            int diag = 0;

            Console.WriteLine("Введіть розмір матриці n*n: ");
            Console.Write("n = ");
            matrixSize = int.Parse(Console.ReadLine());
            matrix = new double[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (j == diag)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
                diag++;
            }
        }
    }
}
