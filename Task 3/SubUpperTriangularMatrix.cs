using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class SubUpperTriangularMatrix : UpperTriangularMatrix
    {
        public override double Determinant(double[,] input)
        {
            double result = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                result =+ matrix[i, i];
            }

            return result;
        }
    }
}
