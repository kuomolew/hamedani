using System;
using System.Collections.Generic;
using System.Text;

namespace SummarisingText
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            string summarySentence = text;

            if (text.Length > maxLength)
            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                    {
                        break;
                    }
                    summaryWords.Add(word);
                }

                summarySentence = String.Join(" ", summaryWords) + "...";
            }
            return summarySentence;
        }
    }
}
