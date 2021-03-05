using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv en metod ReadNumber(int start, int end) som
            läser in ett heltal i intervallet [start..end]. Om ett
            ogiltigt tal matas in skall programmet kasta ett fel.
            Använd metoden för att läsa in 10 heltal:
            a1, a2, … , a10, sådana att 1 < a1 < … <a10 < 100 */
            Console.WriteLine("Input 10 numbers: ");
            int start = 1, end = 100;
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Input number {0} in range of [{1}..{2}]", i, start, end);
                    start = ReadNumber(start, end);
                }
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
        public static int ReadNumber(int start, int end)
        {
            int input = int.Parse(Console.ReadLine());
            if (input <= start || input > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return input;
        }
    }
}
