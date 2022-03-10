using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "Elden Ring", "Ghost of Tsushima", "Monster Hunter", "Final Fantasy", "Destiny 2" };
            var gamesSorted = games.OrderBy(name => name.Length);
            foreach(var game in gamesSorted)
            {
                Console.WriteLine(game);
            }
        }
    }
}
