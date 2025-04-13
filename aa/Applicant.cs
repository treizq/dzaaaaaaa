using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Applicant
    {
        public string FullName { get; set; }
        public double AverageScore { get; set; }
        public int AchievementsScore { get; set; }
        public DateTime ApplicationDate { get; set; }

        public static bool operator <(Applicant a, Applicant b)
        {
            if (a.AverageScore == b.AverageScore)
                return a.AchievementsScore < b.AchievementsScore;
            return a.AverageScore < b.AverageScore;
        }

        public static bool operator >(Applicant a, Applicant b)
        {
            if (a.AverageScore == b.AverageScore)
                return a.AchievementsScore > b.AchievementsScore;
            return a.AverageScore > b.AverageScore;
        }
    }

    public static class Admission
    {
        public static double PassingScore = 4.5;

        //соответствие проходному баллу
        public static bool CheckPassingScore(Applicant applicant)
        {
            return applicant.AverageScore >= PassingScore;
        }
    }
}
