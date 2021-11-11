using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            try
            {
                Console.WriteLine("Конус чи зрізаний конус?");
                Console.WriteLine("1 — Конус");
                Console.WriteLine("2 — Зрізаний конус");

                Console.WriteLine();
                Console.WriteLine("Ваш вибір: ");
                int figureAnswer = int.Parse(Console.ReadLine());

                Cone cone;
                switch (figureAnswer)
                {
                    case (1):
                        cone = new Cone();
                        break;
                    case (2):
                        cone = new Frustum();
                        break;
                    default:
                        throw new Exception("Неправильний вибір");
                }

                cone.ReadParams();
                cone.WriteParams();
                cone.ShowResults();
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Помилка: {exception}");
            }

            Console.ReadKey();
        }
    }
}
