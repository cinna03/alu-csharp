using System;

class Program
{
    static void Main(string[] args)
    {
        string result = "";
        for (int i = 0; i < 10; i++)
            for (int j = i + 1; j < 10; j++)
                result += $"{i}{j}" + (i == 8 && j == 9 ? "\n" : ", ");
        Console.Write(result);
    }
}
