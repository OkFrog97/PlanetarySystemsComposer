using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PlanetarySystemsComposer
{
    abstract class CelestialObject
    {
        //basic haracteristics
        int X { get; set; } //X-Axis
        int Y { get; set; } //Y-Axis
        Image Img { get; set; }
        int ImgSize { get; set; }

        //Celestial Objects haracteristics
        public String Name { get; set; }
        public int Mass { get; set; }
        public int SunDistance { get; set; }
    }
}
