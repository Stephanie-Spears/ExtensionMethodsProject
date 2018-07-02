using System;
using System.Collections.Generic;
using Treehouse.Collections.Generic;
using Treehouse.Common;

namespace Treehouse.ExtensionMethodsProject
{
    internal class Program
    {
        private static void Main()
        {
            var synonymnsForBest = new List<string>
            {
                "best",
                "finest",
                "greatest",
                "top",
                "foremost",
                "leading",
                "most excellent",
                "preeminent",
                "premier",
                "chief",
                "supreme",
                "unrivaled",
                "perfect",
                "incomparable",
                "ideal"
            };

            var best = synonymnsForBest.FirstOr(s => s.Length.IsEven(), synonymnsForBest.RandomItem);

            Console.WriteLine($"My kitty Little Kitty was the {best} cat.");
            Console.ReadLine();
        }
    }
}