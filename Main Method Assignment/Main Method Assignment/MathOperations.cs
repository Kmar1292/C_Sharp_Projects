using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class MathOperations
    {
        public int Operation(int num)
        {
            int result = num + 12;
            return result;
        }

        public int Operation(float num)
        {
            float result = num / 3;
            return (int)result;
        }

        public int Operation(string stringInput)
        {
            int result = Convert.ToInt32(stringInput) * 4;
            return result;
        }

    }
}
