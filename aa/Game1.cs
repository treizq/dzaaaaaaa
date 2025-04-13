using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Game1
    {
        public string Name { get; set; }
        public int AveragePlayers { get; set; }
        public int MaxPlayers { get; set; }
        public double Rating { get; set; }

        public static bool operator <(Game1 gamea, Game1 gamer)
        {
            int count1 = 0, count2 = 0;

            if (gamea.AveragePlayers < gamer.AveragePlayers) count2++;
            else if (gamea.AveragePlayers > gamer.AveragePlayers) count1++;

            if (gamea.MaxPlayers < gamer.MaxPlayers) count2++;
            else if (gamea.MaxPlayers > gamer.MaxPlayers) count1++;

            if (gamea.Rating < gamer.Rating) count2++;
            else if (gamea.Rating > gamer.Rating) count1++;

            return count1 < count2;
        }

        public static bool operator >(Game1 gamea, Game1 gamer)
        {
            int count1 = 0, count2 = 0;

            if (gamea.AveragePlayers > gamer.AveragePlayers) count1++;
            else if (gamea.AveragePlayers < gamer.AveragePlayers) count2++;

            if (gamea.MaxPlayers > gamer.MaxPlayers) count1++;
            else if (gamea.MaxPlayers < gamer.MaxPlayers) count2++;

            if (gamea.Rating > gamer.Rating) count1++;
            else if (gamea.Rating < gamer.Rating) count2++;

            return count1 > count2;
        }

        public static bool operator ==(Game1 gamea, Game1 gamer)
        {
            return gamea.AveragePlayers == gamer.AveragePlayers &&
                   gamea.MaxPlayers == gamer.MaxPlayers &&
                   gamea.Rating == gamer.Rating;
        }

        public static bool operator !=(Game1 gamea, Game1 gamer)
        {
            return !(gamea == gamer);
        }

        public override bool Equals(object obj)
        {
            if (obj is Game1 other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, AveragePlayers, MaxPlayers, Rating);
        }

        public static class PopularGame
        {
            public static double Rating = 8.5;
            public static int AveragePlayers = 1000;
            public static int MaxPlayers = 10000;

            public static bool IsPopular(Game gamea)
            {
                return gamea.Rating >= Rating &&
                       gamea.AveragePlayers >= AveragePlayers &&
                       gamea.MaxPlayers >= MaxPlayers;
            }
        }
    }
}
