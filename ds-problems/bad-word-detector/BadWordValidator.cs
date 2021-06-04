using System.IO;
using System;

namespace ds_problems.badworddetector
{
    public class BadWordValidator
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
            var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            return File.ReadAllLines(path + "/bad-word-detector/badwords.txt");
        }
    }
}