using System;

class Program
{
    static void Main()
    {
        int[] list1 = {10, 0, 4};
        int[] list2 = {2, 4, 0};

        for (int i = 0; i < Math.Max(list1.Length, list2.Length); i++)
        {
            try
            {
                int result = list1[i] / list2[i];
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
    }
}
