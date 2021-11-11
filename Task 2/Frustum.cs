using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Frustum : Cone
    {
        public double UpperBaseRadius { get; set; }

        public override void ReadParams()
        {
            base.ReadParams();

            Console.Write("Радіус верхньої основи конуса: ");
            UpperBaseRadius = double.Parse(Console.ReadLine());
        }

        public override void WriteParams()
        {
            base.WriteParams();

            Console.WriteLine($"Радіус верхньої основи конуса: {UpperBaseRadius}");
        }

        public override double CalcVolume()
        {
            return (double)1 / 3 * Math.PI * Height * (Math.Pow(BaseRadius, 2) + BaseRadius * UpperBaseRadius + Math.Pow(UpperBaseRadius, 2));
        }
    }
}
