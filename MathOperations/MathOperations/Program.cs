using System;



class Program
{
    static void Main()
    {
        Console.WriteLine("Please input a number.");
        int productNum1 = Convert.ToInt32(Console.ReadLine());
        int productNum2 = 50;
        int product = productNum1 * productNum2;
        Console.WriteLine(product);

        Console.WriteLine("Please input a number.");
        int sumNum1 = Convert.ToInt32(Console.ReadLine());
        int sumNum2 = 25;
        int sum = sumNum1 + sumNum2;
        Console.WriteLine(sum);

        Console.WriteLine("Please input a number.");
        double quotientNum1 = Convert.ToDouble(Console.ReadLine());
        double quotientNum2 = 12.5;
        double quotient = quotientNum1 / quotientNum2;
        Console.WriteLine(quotient);

        Console.WriteLine("Please input a number.");
        int greaterNum1 = Convert.ToInt32(Console.ReadLine());
        int greaterNum2 = 50;
        bool greater = greaterNum1 > greaterNum2;
        Console.WriteLine(greater);

        Console.WriteLine("Please input a number.");
        int remainderNum1 = Convert.ToInt32(Console.ReadLine());
        int remainderNum2 = 7;
        int remainder = remainderNum1 % remainderNum2;
        Console.WriteLine(remainder);

        Console.Read();
    }
}

