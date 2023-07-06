using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class MathOperations
    {
        public int Operations(int num1, int num2 = 0)
        {
            int result = (num1 / 2) + (num2 * 2);
            return result;
        }

    }
}
