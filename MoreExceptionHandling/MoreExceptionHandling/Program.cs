using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            try
            {
                Console.WriteLine("Please enter your age:");

                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    throw new ZeroException();
                }
                else if (x < 0)
                {
                    throw new NegativeException();
                }
                DateTime currentAge = current.AddYears(-x);

                int age = currentAge.Year;

                Console.WriteLine("You were born in {0}.", age);
            }
            catch (ZeroException)
            {
                Console.WriteLine("You may not enter 0.");
                Console.ReadLine();
                return;
            }
            catch (NegativeException)
            {
                Console.WriteLine("You may not enter a negative number.");
                Console.ReadLine();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
