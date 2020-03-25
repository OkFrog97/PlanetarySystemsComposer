using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetarySystemsComposer
{
    class Controller
    {
        public CelestialObject CreateStar()
        {
            Star Star = new Star();
            return Star;
        }

        public CelestialObject CreateStar(string name, double mass, string StellarClass)
        {
            Star Star = new Star(name, mass, StellarClass);
            return Star;
        }

    }
}
