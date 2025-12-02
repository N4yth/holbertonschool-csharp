using System;

class Character
{
    public static bool IsLower(char c)
    {
        if ((int)c >= 97 && (int)c <= 122)
        {
            return true;
        }
        return false;
    }
}