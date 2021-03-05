using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv ett program som läser ett heltal och beräknar och
            skriver ut dess kdaratrot. Om talet är ogiltigt eller
            negativt, skriv ut "Ogiltigt tal". I samtliga fall skall det
            avslutningsvis skriva ut "Tack och adjö". Använd trycatch-finally. */
            try
            {
                Console.Write("Input number: ");
                double num = int.Parse(Console.ReadLine());
                double result = Math.Sqrt(num);
                Console.WriteLine("The sqaure root of {0} is {1:0.00}", num, result);
            }
            catch (ArgumentNullException ae)
            {
                PrintError(ae);
            }
            catch (FormatException fe)
            {
                PrintError(fe);
            }
            catch (OverflowException oe)
            {
                PrintError(oe);
            }
            finally
            {
                Console.WriteLine("Bye, have a beautiful time!");
            }
            Console.ReadKey();
        }
        public static void PrintError(Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }
}
