using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PlanetarySystemsComposer
{
    class Star : CelestialObject
    {

        public String StellarClass { get; set; }
        public String StarColor { get; set; }

        
        public Star()
        {
            X = 50;
            Y = 50;
            Img = new Bitmap("C:\\Users\\User\\Desktop\\projects\\imgs\\sun.png");
            ImgSize = 100;
            Name = "Sun";
            Mass = 1.9885; //Вопрос: У массы планет и солнца разные множители. Как вычислять их G?
            SunDistance = 0;
            StellarClass = "G";
            StarColor = "white";

        }

        public Star(String name, double mass, String stellarClass, String starColor)
        {
            X = 50;
            Y = 50;
            Img = new Bitmap("C:\\Users\\User\\Desktop\\projects\\imgs\\sun.png");
            ImgSize = 100;
            Name = name;
            Mass = mass; //Вопрос: У массы планет и солнца разные множители. Как вычислять их G?
            SunDistance = 0;
            StellarClass = stellarClass;
            StarColor = starColor;
        }
    }
}
