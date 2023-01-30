using System;
using System.Collections.Generic;

namespace Summarize_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This experiment is about a frog. This frog is red.";
            var summary = String_Utility.SummarizeText(sentence, 30);
            Console.WriteLine(summary);
        }
        
    }
}
