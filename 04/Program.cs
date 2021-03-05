using System;
using System.Net;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv ett program som laddar ner en fil från internet
            (t.ex. http://www.devbg.org/img/Logo-BASD.jpg) och
            sparar den i aktuell katalog. Googla på hur man laddar
            ner filer i C#. Se till att fånga upp alla fel och frigör alla
            resurser i ett finally-block. */
            try
            {
                using var client = new WebClient();
                client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../Logo-BASD.jpg");
                Console.WriteLine("Download successful");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); ;
            }
            
            Console.ReadKey();
        }
    }
}
