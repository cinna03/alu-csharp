using System;
using MyMath;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            // Default: Test case 1
            int[,] matrix = { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
            int[,] result = Matrix.Divide(matrix, 2);
            PrintMatrix(result);
            return;
        }

        string testCase = args[0];
        
        switch (testCase)
        {
            case "1":
                int[,] matrix1 = { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
                int[,] result1 = Matrix.Divide(matrix1, 2);
                PrintMatrix(result1);
                break;
                
            case "2":
                int[,] matrix2 = { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
                int[,] result2 = Matrix.Divide(matrix2, -7);
                PrintMatrix(result2);
                break;
                
            case "3":
                int[,] matrix3 = { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
                Matrix.Divide(matrix3, 0);
                break;
                
            case "4":
                int[,] matrix4 = new int[6, 6];
                int[,] result4 = Matrix.Divide(matrix4, 4);
                PrintMatrix(result4);
                break;
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        if (matrix == null)
            return;
            
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}