using System;

namespace ConsoleApplication2
{
    public class Error
    {
        public static void ErrorData()
        {
            Console.WriteLine("Nie udało się wykonać obliczeń");
            Console.WriteLine("Błędne dane");
        }
        public static void ErrorResult()
        {
            Console.WriteLine("Nie udało się wykonać obliczeń");
            Console.WriteLine("Nie dzielimy przez zero lub nie rozpoznano znaku działania wpisz +,-,* lub /.");
        }
    }
}
