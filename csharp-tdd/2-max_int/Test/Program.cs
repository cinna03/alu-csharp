using System;
using System.Collections.Generic;
using MyMath;

class Program
{
    static void Main(string[] args)
    {
        // Test cases for Max method
        if (args.Length == 0)
        {
            // Default test case
            var nums = new List<int> { 3, 7, 2, 9, 1 };
            int result = Operations.Max(nums);
            Console.WriteLine(result);
            return;
        }

        string testCase = args[0];
        
        switch (testCase)
        {
            case "1":
                // Empty list
                var empty = new List<int>();
                Console.WriteLine(Operations.Max(empty));
                break;
                
            case "2":
                // Single element
                var single = new List<int> { 42 };
                Console.WriteLine(Operations.Max(single));
                break;
                
            case "3":
                // Multiple elements
                var multiple = new List<int> { 3, 7, 2, 9, 1 };
                Console.WriteLine(Operations.Max(multiple));
                break;
                
            case "4":
                // Negative numbers
                var negative = new List<int> { -5, -2, -8, -1 };
                Console.WriteLine(Operations.Max(negative));
                break;
                
            case "5":
                // Mixed numbers
                var mixed = new List<int> { -3, 0, 5, -1, 2 };
                Console.WriteLine(Operations.Max(mixed));
                break;
        }
    }
}