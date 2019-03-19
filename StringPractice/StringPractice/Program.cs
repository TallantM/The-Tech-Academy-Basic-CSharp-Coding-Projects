using System;
using System.Text;


class Program
{
    static void Main()
    {
        string fName = "Michael";
        string lName = "Tallant";
        string statement = "Hello, my name is ";
        string sentence = statement + fName + " " + lName + "!";
        Console.WriteLine(sentence);

        sentence = sentence.ToUpper();
        Console.WriteLine(sentence);

        StringBuilder paragraph = new StringBuilder();
        paragraph.Append("Hello, my name is Michael.");
        paragraph.Append(" I enjoy coding using C#.");
        paragraph.Append(" It has been a very fun language to learn.");
        paragraph.Append(" I think that it is my favorite of the Bootcamp!");
        Console.WriteLine(paragraph);


        Console.ReadLine();
    }
}
