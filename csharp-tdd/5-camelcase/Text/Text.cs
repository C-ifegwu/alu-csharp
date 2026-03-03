using System;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines how many words are in a string based on camelCase.
        /// </summary>
        /// <param name="s">The camelCase string</param>
        /// <returns>Number of words in s</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int count = 1;

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
