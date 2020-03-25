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

        readonly Dictionary<int, string> imgs = new Dictionary<int, string>
        {
            [1] = "D:\\Fp\\PlanetarySystemsComposer\\PlanetarySystemsComposer\\img\\planets\\p1.png",
            [2] = "D:\\Fp\\PlanetarySystemsComposer\\PlanetarySystemsComposer\\img\\planets\\p2.png",
            [3] = "D:\\Fp\\PlanetarySystemsComposer\\PlanetarySystemsComposer\\img\\planets\\p3.png",
            [4] = "D:\\Fp\\PlanetarySystemsComposer\\PlanetarySystemsComposer\\img\\planets\\p4.png",
            [5] = "D:\\Fp\\PlanetarySystemsComposer\\PlanetarySystemsComposer\\img\\planets\\p5.png",
            [6] = "D:\\Fp\\PlanetarySystemsComposer\\PlanetarySystemsComposer\\img\\planets\\p6.png",
        };

        public Planet()
        {
            X = 105;
            Y = 100;
            Img = new Bitmap(getPlanetImage()); //выбор рисунка
            ImgSize = 30;
            Name = "Earth";
            Mass = 5.9724; //Вопрос: У массы планет и солнца разные множители. Как вычислять их G?
            SunDistance = 1;

        }

        public Planet(String name, double mass, int sunDistance)
        {
            X = 105;
            Y = 100;
            Img = new Bitmap(getPlanetImage());
            ImgSize = 30;
            Name = name;
            Mass = mass; //Вопрос: У массы планет и солнца разные множители. Как вычислять их G?
            SunDistance = sunDistance;
        }

        string getPlanetImage()
        {
            Random rnd = new Random();
            return imgs[rnd.Next(1,7)];
        }
    }
}
