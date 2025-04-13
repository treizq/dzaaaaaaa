using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Person
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string EyeColor { get; set; }

        public static string operator +(Person a, Person b)
        {
            if (a.EyeColor == "Карие" && b.EyeColor == "Карие") return "Карие";
            if (a.EyeColor == "Зеленые" && b.EyeColor == "Карие") return "Карие";
            if (a.EyeColor == "Голубые" && b.EyeColor == "Карие") return "Карие";
            if (a.EyeColor == "Зеленые" && b.EyeColor == "Зеленые") return "Зеленые";
            if (a.EyeColor == "Зеленые" && b.EyeColor == "Голубые") return "Голубые";
            if (a.EyeColor == "Голубые" && b.EyeColor == "Голубые") return "Голубые";

            return "Неизвестный цвет";
        }
    }
    public static class WorkAbility
    {
        public static int MinAge = 18;
        public static int MaxAge = 70;

        public static bool IsEligible(Person person)
        {
            return person.Age > MinAge && person.Age < MaxAge;
        }
    }
}
