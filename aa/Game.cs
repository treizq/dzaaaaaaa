using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Game
    {
        public string Name { get; set; }
        public int AveragePlayers { get; set; }
        public int MaxPlayers { get; set; }
        public double Rating { get; set; }

        public static Game operator ++(Game gamee)
        {
            gamee.Rating = Math.Min(gamee.Rating + 0.1, 10);
            return gamee;
        }

        public static Game operator --(Game gamee)
        {
            gamee.Rating = Math.Max(gamee.Rating - 0.1, 0);
            return gamee;
        }
    }
    public static class PopularGame
    {
        public static double Rating = 8.5;
        public static int AveragePlayers = 1000;
        public static int MaxPlayers = 10000;

        public static bool IsPopular(Game gamee)
        {
            return gamee.Rating >= Rating &&
                   gamee.AveragePlayers >= AveragePlayers &&
                   gamee.MaxPlayers >= MaxPlayers;
        }
    }
}
