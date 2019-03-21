using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> numbers = new List<int>() { 10, 20, 40, 50, 100 };
            Console.WriteLine("Please choose a number:");
            int numberChoice = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {
                int result = numbers[i] / numberChoice;
                Console.WriteLine(numbers[i] + " divided by " + numberChoice + " equals " + result);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("You must choose a whole number.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You may not choose 0.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("\nThank you for using this application.");
            Console.ReadLine();
        }
        

        
    }
}
