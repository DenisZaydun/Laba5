using System;

namespace Task_2
{
    class Cone
    {
        public double BaseRadius { get; set; }
        public double Height { get; set; }

        public virtual void ReadParams()
        {
            Console.WriteLine("\n--Введіть параметри--");

            Console.Write("Радіус основи конуса: ");
            BaseRadius = double.Parse(Console.ReadLine());

            Console.Write("Висота конуса: ");
            Height = double.Parse(Console.ReadLine());
        }

        public virtual void WriteParams()
        {
            Console.WriteLine();
            Console.WriteLine($"Радіус основи конуса: {BaseRadius}");
            Console.WriteLine($"Висота конуса: {Height}");
        }

        public double CalcBaseArea()
        {
            return Math.PI * Math.Pow(BaseRadius, 2);
        }

        public virtual double CalcVolume()
        {
            return (double)1 / 3 * CalcBaseArea() * Height;
            
        }
        public void ShowResults()
        {
            Console.WriteLine();
            Console.WriteLine($"Площа основи: {CalcBaseArea()}");
            Console.WriteLine($"Об'єм: {CalcVolume()}");
        }
    }
}
