using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PlanetarySystemsComposer
{
    class Star:CelestialObject
    {
        public Star()
        {
            X = 50;
            Y = 50;
            Img = new Bitmap("C:\\Users\\User\\Desktop\\projects\\imgs\\sun.png");
            ImgSize = 100;
            Name = "Sun";
            Mass =  1.9885; //Вопрос: У массы планет и солнца разные множители. Как вычислять их G?
            SunDistance = 0;

        }
        
        public Star(String name, int mass)
        {

        }
        
        
        
        
        
        


        /*
        String Name;
        public int x;
        public int y;
        public Image SunImg;
        public int Size;
        

        public Star ()
        {
            
            Name = "Sun";
            SunImg = new Bitmap("C:\\Users\\User\\Desktop\\projects\\imgs\\sun.png");
            x = 50;
            y = 50;
            Size = 100;
            
        }

        public Star (String name)
        {
            
            Name = name;
            
        }
        */
    }
}
