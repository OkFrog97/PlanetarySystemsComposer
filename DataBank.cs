using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetarySystemsComposer
{
    static class DataBank
    {
        //star settings
        public static string StarName { get; set; }
        public static double StarMass { get; set; }
        public static string StarStellarClass { get; set; }

        //planet setting
        public static string PlanetName { get; set; }
        public static double PlanetMass { get; set; }
        public static int PlanetStarDistance { get; set; } //if Distance == 0 or somthing? Bug.

    }
}
