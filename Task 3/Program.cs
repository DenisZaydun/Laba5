using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            Matrix matrix1;

            Console.WriteLine($"Оберіть матрицю: ");
            Console.WriteLine("1 - звичайна матриця");
            Console.WriteLine("2 - одинична матриця");
            Console.WriteLine("3 - верхня трикутна матриця");
            Console.WriteLine();

            Console.Write("Ваш вибір: ");
            int ans = int.Parse(Console.ReadLine());

            switch (ans)
            {
                case 1:
                    matrix1 = new Matrix();
                    break;
                case 2:
                    matrix1 = new SubIndentityMatrix();
                    break;
                case 3:
                    matrix1 = new SubUpperTriangularMatrix();
                    break;
                default:
                    throw new Exception("Неправильний вибір");
            }

            matrix1.Info();
            matrix1.ReadMatrix();
            matrix1.WriteMatrix();

            Console.WriteLine();
            Console.WriteLine($"Детермінант матриці: " + matrix1.Determinant(matrix1.matrix));
        }
    }
}
