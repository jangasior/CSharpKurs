

using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();
            {

            }

            for (;;)
            {
                Greeting();

                Age();

                Settings();

            }


        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        private static void Settings()
        {
            Console.ReadKey(); //czeka na naciśnięcie klawisza aby zatrzymać program
            Console.Clear(); //resetuje konsolę, czyli znika na niej tekst
            Console.ResetColor(); //wraca do początkowego koloru
        }

        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);
            /*to co użytkownik wprowadził, próbujemy parsować na int.
            Jeżeli się powiedzie, to przypisujemy tą liczbę(int) do zmiennej "age" i wychodzi true
            Jeżeli się nie powiedzie, przypisuje do "age" 0 a w "result" mamy wtedy false
            Jeżeli uda się sparsować, ale mniejsze od 18 to wykonuje ostatnią linijkę czyli oferujemy mleko

    */
            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Brawo. Jesteś pełnoletni, możesz wypić piwo!");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś niepoprawny wiek :/");
            }
            else
            {
                Console.WriteLine("Możemy ci zaoferować mleko ;) ");
            }
        }

        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }
    }
}
