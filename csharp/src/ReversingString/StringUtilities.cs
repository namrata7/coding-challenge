using System;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        public static string Reverse(string s)
        {
            var strings = s.Split(" ");
            string[] retVal = new string[strings.Length];
            int j = 0;
            for (int i = strings.Length - 1; i >= 0; --i)
            {
                char[] charArray = strings[i].ToCharArray();
                Array.Reverse(charArray);
                retVal[j++] = new string(charArray);
            }

            return string.Join(" ", retVal); ;
        }
    }
}
