using System.IO;
using System;

public class Validator
{
    public bool DetectBadWord(string userName)
    {
        return CheckIfStringContainsBadWord(userName);
    }

    private bool CheckIfStringContainsBadWord(string userName)
    {
        foreach (var badWord in this.GetBadWords())
        {
            if (userName.Contains(badWord))
            {
                return true;
            }
        }

        return false;
    }

    private string[] GetBadWords()
    {
        return File.ReadAllLines("./badwords.txt");
    }
}