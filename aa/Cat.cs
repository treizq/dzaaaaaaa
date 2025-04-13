using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Cat
    {
        public string Name { get; set; } 
        public string Breed { get; set; } 
        public DateTime BirthDate { get; set; }
        public double Weight { get; set; } 


        public static bool operator <(Cat a, Cat b)
        {
            return a.Weight < b.Weight;
        }

        public static bool operator >(Cat a, Cat b)
        {
            return a.Weight > b.Weight;
        }


        public static string operator *(Cat a, Cat b)
        {
            return a.Breed == b.Breed ? "Селекция возможна" : "Селекция невозможна";        }
    }
    public static class CatWeightChecker
    {
        public static double SmallWeight = 1; 
        public static double MediumWeight = 3; 
        public static double LargeWeight = 5; 

        //проверка веса котика
        public static string CheckWeight(Cat cat)
        {
            if (cat.Weight < SmallWeight)
                return "Котика очень худой";
            else if (cat.Weight >= SmallWeight && cat.Weight < MediumWeight)
                return "Котик худой";
            else if (cat.Weight >= MediumWeight && cat.Weight < LargeWeight)
                return "Котик полноват";
            else
                return "Котик полный";
        }
    }

}   

