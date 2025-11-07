using System;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        // If the key exists, its value is updated; if not, the key-value pair is added
        myDict[key] = value;
        return myDict;
    }
}
