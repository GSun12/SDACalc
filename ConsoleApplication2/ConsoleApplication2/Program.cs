using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //tworzymy instancje klasy Read
            var read = new Read();
            //tworzymy instancje klasy Action
            var action = new Action();

            Console.WriteLine("Podaj pierwsza liczbe");
            //deklarujemy nasza zmienna do ktorej wczytujemy pierwszą liczbę z consoli
            int? number1 = read.ReadNumber();
            Console.WriteLine("Podaj druga liczbe");
            int? number2 = read.ReadNumber();
            Console.WriteLine("Podaj znak");
            //wczytujemy nasz znak działania
            var actionChar = read.ReadInput();
            if (number1 != null && number2 != null)
            {
                //dokunujemy obliczeń za pomocą klasy Action i metody Calculate
                var result = action.Calculate(number1.Value, number2.Value, actionChar);

                if (result != null)
                    Console.WriteLine($"Wynik to :  {result}");
                else
                    Error.ErrorResult();
            }
            else
            {

                Error.ErrorData();
            }



            Console.ReadKey();
        }
    }
}
