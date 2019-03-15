using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");

        Console.WriteLine("Person 1");
        Console.WriteLine("Please enter the hourly rate:");
        decimal firstRate = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Please enter the hours worked per week:");
        decimal firstHours = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Person 2");
        Console.WriteLine("Please enter the hourly rate:");
        decimal secondRate = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Please enter the hours worked per week:");
        decimal secondHours = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Annual salary of Person 1:");
        decimal salaryFirst = firstRate * firstHours * 52;
        Console.WriteLine(salaryFirst);

        Console.WriteLine("Annual salary of Person 1:");
        decimal salarySecond = secondRate * secondHours * 52;
        Console.WriteLine(salarySecond);

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        bool greaterSalary = salaryFirst > salarySecond;
        Console.WriteLine(greaterSalary);

        Console.Read();
    }
}