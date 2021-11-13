using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Rotate : Move
    {
        private float degrees;

        public override void Info()
        {
            Console.WriteLine("Щоб повернути квадрат ліворуч, натисніть стрілку ліворуч");
            Console.WriteLine("Щоб повернути квадрат праворуч, натисніть стрілку праворуч");
            Console.WriteLine("Щоб вийти, натисніть \"Esc\"");
        }

        public override void MoveStep()
        {
            Console.Write(" Градус повороту: ");
            degrees = float.Parse(Console.ReadLine());
        }

        public void SqRotate(double degree)
        {
            double radians = degree / 180d * Math.PI;

            for (int i = 0; i < points.Length; i++)
            {
                double x = points[i].X;
                double y = points[i].Y;

                double x1 = x * Math.Cos(radians) - y * Math.Sin(radians);
                double y1 = x * Math.Sin(radians) + y * Math.Cos(radians);

                points[i].X = Convert.ToSingle(x1);
                points[i].Y = Convert.ToSingle(y1);
            }
        }


        public override void MoveLeft() { SqRotate(-degrees); }

        public override void MoveRight() { SqRotate(degrees); }
    }
}
