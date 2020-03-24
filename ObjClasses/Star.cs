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

        String StarColor { get; set; }

        readonly Dictionary<string, string> Colors = new Dictionary<string, string>
        {
            ["O"]="blue",
            ["B"]="white-blue",
            ["A"] ="white",
            ["F"] ="white",
            ["F"] ="yellow",
            ["G"] ="yellow-orange",
            ["K"] ="orange-red"
        };
        
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
            StarColor = GetColor(StellarClass);

        }

        public Star(String name, double mass, String stellarClass)
        {
            X = 50;
            Y = 50;
            Img = new Bitmap("C:\\Users\\User\\Desktop\\projects\\imgs\\sun.png");
            ImgSize = 100;
            Name = name;
            Mass = mass; //Вопрос: У массы планет и солнца разные множители. Как вычислять их G?
            SunDistance = 0;
            StellarClass = stellarClass;
            StarColor = GetColor(StellarClass);
        }

        string GetColor (string stellarClass)
        {
            //в будущем нужно будет добавить проверки/верификации
            return Colors[stellarClass];
        }
    }
}
