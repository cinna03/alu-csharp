using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5];

        // Set index [2,2] to 1
        array[2, 2] = 1;

        // Print the 2D array
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j]);
                if (j < 4)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
