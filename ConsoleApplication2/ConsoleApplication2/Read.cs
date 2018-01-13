using System;

namespace ConsoleApplication2
{
    public class Read
    {
        //metoda ktora wczytuje stringa
        public string ReadInput()
        {
            var input = Console.ReadLine();
            return input;
        }


        //metoda która zwraca naszą wczytaną liczbę jeśli jest poprawna lub null jeśli jest błędna
        public int? ReadNumber()
        {
            int number;
            var input = ReadInput();
            if (int.TryParse(input, out number))
            {
                return number;
            }
            return null;
        }


    }
}
