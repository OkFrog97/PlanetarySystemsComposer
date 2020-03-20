using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetarySystemsComposer
{
    class Star
    {
        String Name;

        public Star ()
        {
            Name = "Sun";
        }

        public Star (String name)
        {
            Name = name;
        }

        public String GetName ()
        {
            return Name;
        }


    }
}
