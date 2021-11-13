using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class AnotherMethodToCalcDet : UpperTriangularMatrix
    {
        public override double Determinant(double[,] input)
        {
            return base.Determinant(input); //base Matrix method
        }
    }
}
