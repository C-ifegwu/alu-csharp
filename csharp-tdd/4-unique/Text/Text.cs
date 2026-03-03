using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character of a string.
        /// </summary>
        /// <param name="s">The string</param>
        /// <returns>Index of first non-repeating character or -1</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCounts[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
