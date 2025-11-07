using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        // Remove the key if it exists
        myDict.Remove(key);
        return myDict;
    }
}
