using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds_problems.filepath_validator
{
    public class FilePathValidator
    {
        private const int MAX_LENGTH = 20;

        static Random random = new Random();

        Dictionary<string, string> StuffedFilePaths;

        public FilePathValidator()
        {
            this.StuffedFilePaths = new Dictionary<string, string>();
        }

        public string GetValidFilePath(string input)
        {
            return this.GetMaxLengthString(input);
        }

        private string GetMaxLengthString(string input)
        {
            StringBuilder sb = new StringBuilder();
            if (input.Length > MAX_LENGTH)
            {
                sb.Append(input.Substring(0, MAX_LENGTH));
            }
            else
            {
                sb.Append(AddStuff(input));
            }

            return sb.ToString();
        }

        private string AddStuff(string input)
        {
            return input + RandomString(MAX_LENGTH - input.Length);
        }

        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}