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

            //declaring 2d array
            string[,] matrix;

            //declaring 3d array
            int[,,] three3;

            int[,] array2D = new int[,]
            {
                {1,2,3 },
                {4,5,6},
                {7,8,9 }
            };
            //accessing 5
            Console.WriteLine("central value is {0}", array2D[2, 2]);
            Console.ReadKey();

            //changing the value
            string[,] array2DString = new string[3, 2]
            {
                {"one","two" },
                {"three" ,"four"},
                {"five","six" }
            };
            Console.WriteLine(array2DString[1, 1]);

            array2DString[1, 1] = "chicken";
            Console.WriteLine(array2DString[1, 1]);

            Console.ReadKey();

            //checking the number of dimentions

            int dimentions = array2DString.Rank;
            Console.WriteLine(dimentions);
            Console.ReadKey();

        }
    }
}
