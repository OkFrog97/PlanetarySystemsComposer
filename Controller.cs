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

        /*
        public static CelestialObject CreateStar(string name, double mass, string StellarClass)
        {
            Star Star = new Star(name, mass, StellarClass);
            return Star;
        }
        */

    }
}
