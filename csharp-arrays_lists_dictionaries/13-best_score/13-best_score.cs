using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if(myList.Count == 0)
        {
            return "None";
        }
        string winner = "";
        int bscore = 0;
        foreach (KeyValuePair<string, int> Entry in myList)
        {
            if (bscore < Entry.Value)
            {
                winner = Entry.Key;
                bscore = Entry.Value;
            }
        }
        return winner;
    }
}