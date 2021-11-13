using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding =
                    Console.OutputEncoding =
                        System.Text.Encoding.Unicode;

            Move move;

            Console.WriteLine("Що робити з квадратом?");
            Console.WriteLine("1 - Переміщувати");
            Console.WriteLine("2 - Повертати");
            Console.Write("Відповідь: ");
            int ans = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (ans)
            {
                case 1:
                    move = new Move();
                    break;
                case 2:
                    move = new Rotate();
                    break;
                default:
                    throw new Exception("Неправильний вибір");
            }

            try
            {
                move.ReadParams();

                move.MoveStep();
                Console.WriteLine();

                move.WriteParams();

                while (true)
                {
                    var keyInfo = Console.ReadKey();

                    bool exit = false;

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            move.MoveLeft();
                            break;
                        case ConsoleKey.RightArrow:
                            move.MoveRight();
                            break;
                        case ConsoleKey.Escape:
                            exit = true;
                            break;
                    }

                    if (exit)
                        return;

                    Console.Clear();
                    move.Info();
                    Console.WriteLine();
                    move.WriteParams();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Помилка: {exception}");
            }
        }
    }
}
