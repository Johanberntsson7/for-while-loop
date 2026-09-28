using System.Xml.Serialization;

namespace for_while_loop;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guess = 0;
        int attempts = 0;
        

        Console.WriteLine("Gissa ett nummer mellan 1 - 100!");

        while (guess != secretNumber)
        {
            Console.Write("Your guess: ");

            if (!int.TryParse(Console.ReadLine(), out guess))
            {
                
                Console.WriteLine("Ge mig ett giltigt nummer.");
                continue;
            }

            attempts++;

            if (guess < secretNumber)
            {
                Console.WriteLine("För lågt!");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("För högt!");
            }
            else
            {
                Console.WriteLine("Grattis! Du gissade siffran!");
                Console.WriteLine ($"Grattis! du gissade rätt på {secretNumber} på {attempts} försök");
            }
        }
    }
}
