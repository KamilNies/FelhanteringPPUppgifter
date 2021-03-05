using System;
using System.IO;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv ett program som läser in en sökväg med filnamn
            (t.ex. C:\Windows\Win.ini), läser dess innehåll och
            skriver ut det på konsolen. Läs på i Microsofts
            dokumentation om hur man använder
            System.IO.File.ReadAllText(…). Se till att
            fånga upp alla möjliga fel och skriv ut användarvänliga
            felmeddelanden. */
            try
            {
                string path = @"..\..\..\TextFile1.txt";
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (PathTooLongException ptle)
            {
                Console.WriteLine(ptle.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine(dnfe.Message);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine(fnf.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
