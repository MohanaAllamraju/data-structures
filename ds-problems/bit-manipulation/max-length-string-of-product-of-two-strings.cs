using System.Collections.Generic;
using System;

namespace ds_problems.bit_manipulation
{
    public class FindMaxLengthOfTwoStrings
    {
        public int FindMaxLengthOfTwoWordsWhichAreUnique(string[] input_array)
        {
            int max = 0;
            for (int i = 0; i < input_array.Length; i++)
            {
                for (int j = i + 1; j < input_array.Length; j++)
                {
                    if (AreUnique(input_array[i], input_array[j]))
                    {
                        max = Math.Max(max, input_array[i].Length * input_array[j].Length);
                    }
                }
            }

            return max;
        }

        private bool AreUnique(string firstWord, string secondWord)
        {
            bool areUnique = true;
            for (int i = 0; i < firstWord.Length; i++)
            {
                for (int j = 0; j < secondWord.Length; j++)
                {
                    if (firstWord[i] == secondWord[j])
                    {
                        areUnique = false;
                        break;
                    }
                }
            }

            return areUnique;
        }
    }

    public class FindMaxProduct
    {
        public int MaxProduct(string[] words)
        {
            if (words.Length == 0 || words == null)
                return 0;

            int[] arr = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    char c = words[i][j];
                    arr[i] |= (1 << (c - 'a'));
                }
            }

            int result = 0;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if ((arr[i] & arr[j]) == 0)
                    {
                        result = Math.Max(result, words[i].Length * words[j].Length);
                    }
                }
            }

            return result;
        }
    }
}