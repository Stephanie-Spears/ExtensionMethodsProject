using System;
using Treehouse.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treehouse.ExtensionMethodsProject
{
    internal class Program
    {
        private static void Main(string[] args)
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