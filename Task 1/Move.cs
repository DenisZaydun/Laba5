using System;
using System.Drawing;

namespace Task_1
{
    class Move
    {
        protected PointF[] points;
        public float moveStep = 1f;

        public void ReadParams()
        {
            Console.WriteLine("Введіть параметри: ");

            Console.Write(" x верхнього лівого кута: ");
            float x = float.Parse(Console.ReadLine());

            Console.Write(" y: ");
            float y = float.Parse(Console.ReadLine());

            Console.Write(" Довжина сторони: ");
            float side = float.Parse(Console.ReadLine());

            points = new PointF[]
            {
                new PointF( x, y ),              //верхній лівий
                new PointF( x + side, y ),       //верхній правий
                new PointF( x, y - side ),       //нижній лівий
                new PointF( x + side, y - side ) //нижній правий
            };

        }

        public virtual void MoveStep()
        {
            Console.Write(" Крок перереміщення: ");
            moveStep = float.Parse(Console.ReadLine());
        }

        public void WriteParams()
        {
            Console.WriteLine("------------------------- Параметри квадрата -------------------------");
            Console.WriteLine();

            Console.Write($"Верхній лівий кут => x: {points[0].X}, y: {points[0].Y}\t\t");
            Console.WriteLine($"Верхній правий кут => x: {points[1].X}, y: {points[1].Y}\n");
            Console.Write($"Нижній лівий кут => x: {points[2].X}, y: {points[2].Y}\t\t");
            Console.WriteLine($"Нижній правий кут => x: {points[3].X}, y: {points[3].Y}");
        }

        public virtual void Info()
        {
            Console.WriteLine("Щоб здвинути квадрат ліворуч, натисніть стрілку ліворуч");
            Console.WriteLine("Щоб здвинути квадрат праворуч, натисніть стрілку праворуч");
            Console.WriteLine("Щоб вийти, натисніть \"Esc\"");
        }

        public virtual void MoveLeft()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X -= moveStep;
            }
        }

        public virtual void MoveRight()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += moveStep;
            }
        }
    }
}