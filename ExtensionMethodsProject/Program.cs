using System;
using System.Collections.Generic;
using Treehouse.Collections.Generic;

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
            Console.WriteLine($"My kitty Little Kitty was the {synonymnsForBest.RandomItem()} cat.");
            Console.ReadLine();
        }
    }
}