using System;

namespace arrays_and_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = { "john", "ana", "bill", "rory", "stephen", "ed", };

            foreach (string friend in friends)
            {
                Console.WriteLine("name: {0}", friend);

            }
            Console.ReadKey();

            string text = "Whatever 5";

            foreach (char letter in text)
            {
                Console.WriteLine(letter);
                Console.WriteLine(char.IsLetter(letter));

            }
            Console.ReadKey();

        }
    }
}
