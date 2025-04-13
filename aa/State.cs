using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class State
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public double Area { get; set; }

        public static State operator +(State state1, State state2)
        {
            return new State
            {
                Name = $"{state1.Name} + {state2.Name}",
                Population = state1.Population + state2.Population,
                Area = state1.Area + state2.Area
            };
        }

        public static bool operator <(State state1, State state2)
        {
            if (state1.Population < state2.Population)
                return true;
            else if (state1.Population == state2.Population && state1.Area < state2.Area)
                return true;
            return false;
        }

        public static bool operator >(State state1, State state2)
        {
            if (state1.Population > state2.Population)
                return true;
            else if (state1.Population == state2.Population && state1.Area > state2.Area)
                return true;
            return false;
        }
        public static class Empire
        {
            public static int Population = 300000; 
            public static double Area = 900000;

            public static string IsEmpire(State state)
            {
                if (state.Population >= Population && state.Area >= Area)
                    return "это государство – империя";
                else
                    return "это государство не является империей";
            }
        }
    }
}
