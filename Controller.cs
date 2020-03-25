using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetarySystemsComposer
{
    static class Controller
    {
        public static Star Star;
        public static Planet[] Planets = new Planet[6];
        
        public static void CreateStar(string name, double mass, string StellarClass)
        {
            if (String.IsNullOrEmpty(name))
            {
                Star = new Star();
            }
            else
            {
                Star = new Star(name, mass, StellarClass);
            }
        }

        

    }
}
