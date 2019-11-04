using System;

namespace Open_Lab_03._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[,] { { "one", "two", "three" }, { "melon", "apple", "strawberry" } };
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{array[row, col]}");
                    Console.WriteLine(" ");
                }

                Console.WriteLine(" ");
            }


        }
    }
}