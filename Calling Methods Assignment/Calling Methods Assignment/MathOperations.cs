using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class MathOperations
    {
        //Add 42
        public static int Add42(int number)
        {
            int result = number + 42;
            return result;
        }

        //Multiply by 3
        public static int Multiply3(int number)
        {
            int result = number * 3;
            return result;
        }

        //Modulus 2
        public static int Modulus2(int number)
        {
            int result = number % 2;
            return result;
        }



    }
}
