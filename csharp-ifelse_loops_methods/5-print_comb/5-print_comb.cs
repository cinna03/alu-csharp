using System;

class Program
{
    static void Main(string[] args)
    {
        string result = "";
        for (int i = 0; i <= 99; i++)
            result += i.ToString("D2") + (i < 99 ? ", " : "\n");
        Console.Write(result);
    }
}
