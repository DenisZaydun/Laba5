using System;

namespace Task_3
{
    class UpperTriangularMatrix : Matrix
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
                    if (j < diag)
                    {
                        matrix[i, j] = 0;
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        string enterString = Console.ReadLine();
                        enterString = enterString.Trim(' ');
                        string[] massiveString = enterString.Split(new Char[] { ' ' });
                        for (int z = 0; z < massiveString.Length; z++)
                        {
                            matrix[i, j] = double.Parse(massiveString[z]);
                            j++;
                        }
                    }
                }
                diag++;
            }
            Console.WriteLine();
        }
    }
}
