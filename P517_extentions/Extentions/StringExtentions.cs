using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P517_extentions.Extentions
{
    public static class StringExtentions
    {
        //"one two three"
        public static string UpperFirstLetter(this string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                throw new ArgumentNullException("Sentence is empty");
            }
            sentence = sentence.Trim();
            StringBuilder sb = new StringBuilder(sentence);
            if (char.IsLower(sb[0]))
            {
                sb[0] = char.ToUpper(sb[0]);
            }
            for (int i = 1; i < sb.Length; i++)
            {
                if (sb[i-1] == ' ' && char.IsLower(sb[i]))
                {
                    sb[i] = char.ToUpper(sb[i]);
                }
            }
            return sb.ToString();
        }
    }
}
