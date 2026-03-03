using System;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns True if a string is a palindrome or False if it’s not.
        /// </summary>
        /// <param name="s">The string</param>
        /// <returns>True if a palindrome, False otherwise</returns>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                char lChar = s[left];
                char rChar = s[right];

                if (!char.IsLetterOrDigit(lChar))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(rChar))
                {
                    right--;
                }
                else
                {
                    if (char.ToLower(lChar) != char.ToLower(rChar))
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
            }

            return true;
        }
    }
}
