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
        
        public static void CreateStar()
        {
            Star = new Star();
            //Form1 frm = new Form1();
            //frm.DrawSun();
        }

        public static CelestialObject CreateStar(string name, double mass, string StellarClass)
        {
            Star Star = new Star(name, mass, StellarClass);
            return Star;
        }

    }
}
