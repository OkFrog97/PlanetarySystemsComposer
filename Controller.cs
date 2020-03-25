using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PlanetarySystemsComposer
{
    static class Controller
    {
        public static Star Star;
        public static List<Planet> Planets = new List<Planet>();
        

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


        public static void CreatePlanet(string name, double mass, int distance)
        {
            Planet p;
            if (String.IsNullOrEmpty(name))
            {
                p = new Planet();
            }
            else
            {
                p = new Planet(name, mass, distance);
            }
            Planets.Add(p);
        }

    }
}
