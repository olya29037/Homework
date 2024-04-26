using System;
using System.Text;

namespace MidtermTest
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder ToUpperString(this StringBuilder sb)
        {
            string vowels = "aeiouAEIOU";

            for (int i = 0; i < sb.Length; i++)
            {
                if (vowels.Contains(sb[i].ToString()))
                {
                    sb[i] = char.ToUpper(sb[i]);
                }
            }

            return sb;
        }
    }
}

