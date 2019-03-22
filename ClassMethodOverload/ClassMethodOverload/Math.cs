using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodOverload
{
    class Math
    {
        public int Opperation(int firstNumber)
        {
            return firstNumber / 2;
        }

        public double Opperation(double secondNumber)
        {
            return 2.0 * secondNumber;
        }

        public string Opperation(string thirdNumber)
        {
            int number = Convert.ToInt32(thirdNumber);
            int result = number + 10;
            return Convert.ToString(result);
        }
    }
}
