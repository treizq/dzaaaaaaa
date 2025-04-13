using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Ingredient
    {
        public string Name { get; set; } 
        public string Effect { get; set; } 
        public int Price { get; set; } 

        public static Ingredient operator +(Ingredient ingredient1, Ingredient ingredient2)
        {
            return new Ingredient
            {
                Name = "Зелье",
                Effect = $"{ingredient1.Effect} + {ingredient2.Effect}",
                Price = (ingredient1.Price + ingredient2.Price) * 3
            };
        }

        public static bool operator <(Ingredient ingredient1, Ingredient ingredient2)
        {
            return ingredient1.Price < ingredient2.Price;
        }

        public static bool operator >(Ingredient ingredient1, Ingredient ingredient2)
        {
            return ingredient1.Price > ingredient2.Price;
        }
    }
    public static class PriceChecker
    {
        public static int SmallPrice = 100; 
        public static int MediumPrice = 500; 
        public static int LargePrice = 1500;

        public static string CheckPrice(Ingredient ingredient)
        {
            if (ingredient.Price < SmallPrice)
                return "цена очень низкая";
            else if (ingredient.Price >= SmallPrice && ingredient.Price < MediumPrice)
                return "цена низкая";
            else if (ingredient.Price >= MediumPrice && ingredient.Price < LargePrice)
                return "цена завышена";
            else
                return "цена слишком высокая";
        }
    }
}
