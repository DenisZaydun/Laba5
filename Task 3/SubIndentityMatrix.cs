using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class SubIndentityMatrix : IdentityMatrix
    {
        public override double Determinant(double[,] input)
        {
            return 1;
        }
    }
}
