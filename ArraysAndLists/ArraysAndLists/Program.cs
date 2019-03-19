using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        string[] stringArray = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        Console.WriteLine("Please select a number between 0 and 9");
        int stringIndex = Convert.ToInt32(Console.ReadLine());
        if (stringIndex <= 9)
        {
            Console.WriteLine(stringArray[stringIndex]);
        }
        else
        {
            Console.WriteLine("You must select a number between 0 and 9");
        }

        int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Please select a number between 0 and 9");
        int intIndex = Convert.ToInt32(Console.ReadLine());
        if (intIndex <= 9)
        {
            Console.WriteLine(intArray[intIndex]);
        }
        else
        {
            Console.WriteLine("You must select a number between 0 and 9");
        }

        List<string> stringList = new List<string>();
        stringList.Add("K");
        stringList.Add("L");
        stringList.Add("M");
        stringList.Add("N");
        stringList.Add("O");
        stringList.Add("P");
        stringList.Add("Q");
        stringList.Add("R");
        stringList.Add("S");
        stringList.Add("T");
        Console.WriteLine("Please select a number between 0 and 9");
        int listIndex = Convert.ToInt32(Console.ReadLine());
        if (listIndex <= 9)
        {
            Console.WriteLine(stringList[listIndex]);
        }
        else
        {
            Console.WriteLine("You must select a number between 0 and 9");
        }

        Console.ReadLine();
    }
}
