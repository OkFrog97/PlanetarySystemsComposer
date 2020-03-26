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

        private double StarLumen { get; set; }


        readonly Dictionary<string, string> Colors = new Dictionary<string, string>
        {
            ["O"]="blue",
            ["B"]="white-blue",
            ["A"] ="white",
            ["F"] ="white",
            ["G"] ="yellow",
            ["M"] ="yellow-orange",
            ["K"] ="orange-red"
        };


        readonly Dictionary<string, double> Lumen = new Dictionary<string, double>
        {
            ["O"] = 20000,
            ["B"] = 80,
            ["A"] = 1400000,
            ["F"] = 6,
            ["G"] = 1.2,
            ["M"] = 0.04,
            ["K"] = 0.4
        };


        public Star()
        {
            X = 10;
            Y = 15;
            Img = new Bitmap("C:\\Users\\User\\Desktop\\projects\\imgs\\sun.png");
            ImgSize = 100;
            Name = "Sun";
            Mass = 1.9885; //Вопрос: У массы планет и солнца разные множители. Как вычислять их G?
            SunDistance = 0;
            StellarClass = "G";
            StarColor = GetColor(StellarClass);
            StarLumen = GetLum(StellarClass);

        }

        public Star(string name, double mass, string stellarClass)
        {
            X = 10;
            Y = 15;
            Img = new Bitmap("C:\\Users\\User\\Desktop\\projects\\imgs\\sun.png");
            ImgSize = 100;
            Name = name;
            Mass = mass; //Вопрос: У массы планет и солнца разные множители. Как вычислять их G?
            SunDistance = 0;
            StellarClass = stellarClass;
            StarColor = GetColor(StellarClass);
            StarLumen = GetLum(StellarClass);
        }

        string GetColor (string stellarClass)
        {
            //в будущем нужно будет добавить проверки/верификации
            return Colors[stellarClass];
        }

        double GetLum (string stellarClass)
        {
            return Lumen[stellarClass];
        }

        public double GetHabitableZone ()
        {
            return Convert.ToInt64(Math.Sqrt(StarLumen / 1.2)) * 140000000;
        }
    }
}
