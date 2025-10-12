using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList == null || myList.Count == 0)
            return "None";
        
        string? bestKey = null;
        int maxValue = int.MinValue;
        
        foreach (var kvp in myList)
        {
            if (kvp.Value > maxValue)
            {
                maxValue = kvp.Value;
                bestKey = kvp.Key;
            }
        }
        
        return bestKey ?? "None";
    }
}