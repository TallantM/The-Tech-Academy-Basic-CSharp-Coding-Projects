using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodOverloadOutput
{
    class Math
    {
        public void Divide(int firstNumber,out int test)
        {
            int resultOne = firstNumber / 2;
            test = 100;
            Console.WriteLine("Your result is: " + resultOne);
        }

        public static int Opperation(int userChoiceSecond)
        {
            return userChoiceSecond * 2;
        }

        public static double Opperation(double userChoiceThird)
        {
            return userChoiceThird * 3.14;
        }
    }
}
