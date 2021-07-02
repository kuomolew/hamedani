using System;
using System.Collections.Generic;

namespace SummarisingText
{
    class Program
    {
        static void Main()
        {
            var sentence = "This is going to be a very very very very very vere really very very long text.";
            string summary = StringUtility.SummarizeText(sentence, 20);

            Console.WriteLine(summary);
            Console.WriteLine(summary.Length);
        }
    }
}
