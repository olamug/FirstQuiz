using System;

namespace LearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w ekstra quizie! Odpowiedz na 5 pytań i zostań mistrzem quizów.");
            Console.WriteLine("Więcej niż jedno zwierze to: owca, lama, stado");
            var users_answer1 = Console.ReadLine();

            var score = 0;

            var right_answer1 = ("stado");

            var result1 = users_answer1 == right_answer1;

            if (result1)
            {
                Console.WriteLine("Bardzo dobrze, trzy z dwoma. Następne pytanie!");
                score = score + 1;
                //Console.WriteLine(score);
            }

            if (users_answer1 != right_answer1)
            {
                Console.WriteLine("Ktoś tu chyba oszalał. Następne pytanie.");
            }

            Console.WriteLine("Ile cali ma jelito cienkie?");
            var users_answer2 = Console.ReadLine();
            int answer2_int = Convert.ToInt32(users_answer2);
            int right_answer2 = 12;
            var result2 = answer2_int == right_answer2;

            if (result2)
            {
                Console.WriteLine("Super ekstra! Następne pytanie!");
                score = score + 1;
                //Console.WriteLine(score);
            }

            if (answer2_int != right_answer2)
            {
                Console.WriteLine("Nope. Zła odpowiedź!");
            }

            Console.WriteLine("Zamek w Malborku jest największym zachowanym zamkiem na świecie. Prawda czy fałsz?");
            var users_answer3 = Console.ReadLine();
            bool usersAnswer3Bool = false;

            if (users_answer3 == "prawda" || users_answer3 == "Prawda")
            {
                usersAnswer3Bool = true;
            }
            else if(users_answer3 == "fałsz" || users_answer3 == "falsz" || users_answer3 == "Fałsz")
            {
                usersAnswer3Bool = false;
            }
            else
            {
                Console.WriteLine("Nieprawidłowy format odpowiedzi, napisz pełne słowo 'Fałsz'");
            }

            if (usersAnswer3Bool = true)
            {
                Console.WriteLine("Zgadza się! Następne pytanie.");
                score = score + 1;
            }

            Console.WriteLine("W roku 1940 odnotowano w Siedlcach rekordowo niską temperaturę. Ile wynosiła? Można się pomylić o 3 stopni.");
            var users_answer4 = Console.ReadLine();
            int answer4_int = Convert.ToInt32(users_answer4);

            if (-44 > answer4_int && answer4_int > -50)
            {
                Console.WriteLine("Kolejny punkt na koncie! Prawidłowa odpowiedź to -47 stopni Celsjusza.");
                score = score + 1;
            }
            else
                Console.WriteLine("Niestety, prawdiłowa odpowiedź to -47 stopni Celsjusza.");

            Console.WriteLine("Piąte pytanie! W którym kraju zabronione jest żucie gumy? Zjednoczone Emiraty Arabskie, Singapur, Sudan, Lichtenstein");
            var users_answer5 = Console.ReadLine();
            var right_answer5 = "Singapur";

            if (users_answer5 == right_answer5)
            {
                Console.WriteLine("Dobra odpowiedź!");
                score = score + 1;
            }
            else
                Console.WriteLine("Przykro mi. ŹLE. Prawidłowa odpowiedź to Singapur.");

            Console.WriteLine("Koniec quizu! Ilość uzyskanych punktów:");
            Console.WriteLine(score);

        }
    }
}
