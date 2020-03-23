using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace PlanetarySystemsComposer
{
    class Planet:CelestialObject
    {
        public Planet()
        {
            X = 120;
            Y = 120;
            Img = new Bitmap("C:\\Users\\User\\Desktop\\projects\\imgs\\planet-generic01-000.export.png"); //выбор рисунка
            ImgSize = 30;
            Name = "Earth";
            Mass = 5.9724; //Вопрос: У массы планет и солнца разные множители. Как вычислять их G?
            SunDistance = 1;

        }

        public Planet(String name, double mass, int sunDistance)
        {
            X = 50;
            Y = 50;
            Img = new Bitmap("C:\\Users\\User\\Desktop\\projects\\imgs\\planet-generic01-000.export.png");
            ImgSize = 100;
            Name = name;
            Mass = mass; //Вопрос: У массы планет и солнца разные множители. Как вычислять их G?
            SunDistance = sunDistance;
        }
    }
}
