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
        public int X { get; set; } //X-Axis
        public int Y { get; set; } //Y-Axis
        public Image Img { get; set; }
        public int ImgSize { get; set; }

        //Celestial Objects haracteristics
        public String Name { get; set; }
        public double Mass { get; set; }
        public int SunDistance { get; set; }
    }
}
