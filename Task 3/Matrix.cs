using System;

namespace Task_3
{
    class Matrix
    {
        public int matrixSize;
        public double[,] matrix;
        public double[,] temp;

        public void Info()
        {
            Console.WriteLine();

            Console.WriteLine("Приклад вводу матриці:");
            Console.WriteLine("1 2 3");
            Console.WriteLine("3 4 5");
            Console.WriteLine("6 7 8");

            Console.WriteLine();
        }

        public virtual void ReadMatrix()
        {
            Console.WriteLine("Введіть розмір матриці n*n: ");
            Console.Write("n = ");
            matrixSize = int.Parse(Console.ReadLine());
            matrix = new double[matrixSize, matrixSize];

            Console.WriteLine("Почніть вводити матрицю: ");
            for (int i = 0; i < matrixSize; i++)
            {
                string enterString = Console.ReadLine();
                enterString = enterString.Trim(' ');
                string[] massiveString = enterString.Split(new Char[] { ' ' });
                for (int j = 0; j < massiveString.Length; j++)
                {
                    matrix[i, j] = double.Parse(massiveString[j]);
                }
            }
            Console.WriteLine();
        }

        public void WriteMatrix()
        {
            Console.WriteLine("Ви ввели матрицю: ");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        //меняет знак елемента
        // + - + -
        // - + - +
        // + - + -
        // - + - +
        public int Sign(int i, int j)
        {
            if ((i + j) % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        // вычеркивает строку и столбец и создает новую матрицу
        public double[,] CreateSmallerMatrix(double[,] input, int i, int j)
        {
            int order = int.Parse(Math.Sqrt(input.Length).ToString());
            double[,] output = new double[order - 1, order - 1];
            int x = 0, y = 0;
            for (int m = 0; m < order; m++, x++)
            {
                if (m != i)
                {
                    y = 0;
                    for (int n = 0; n < order; n++)
                    {
                        if (n != j)
                        {
                            output[x, y] = input[m, n];
                            y++;
                        }
                    }
                }
                else
                {
                    x--;
                }
            }
            return output;
        }

        public virtual double Determinant(double[,] input)
        {
            int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
            if (order > 2)
            {
                double value = 0;
                for (int j = 0; j < order; j++)
                {
                    double[,] Temp = CreateSmallerMatrix(input, 0, j);
                    value = value + input[0, j] * (Sign(0, j) * Determinant(Temp));
                }
                return value;
            }
            else if (order == 2)
            {
                return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
            }
            else
            {
                return (input[0, 0]);
            }
        }
    }
}
