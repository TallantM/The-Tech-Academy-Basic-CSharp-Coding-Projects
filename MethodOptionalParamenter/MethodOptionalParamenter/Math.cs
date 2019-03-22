using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalParamenter
{
    class Math
    {
        public int Opperation(int firstNumber, int secondNumber = 1)
        {
            int number = firstNumber * 10;
            int result = number * secondNumber;

            return result;
        }
    }
}
