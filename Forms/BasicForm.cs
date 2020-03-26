using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PlanetarySystemsComposer
{
    public partial class Form1 : Form
    {

        public String SomeVal { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controller.DeliteSystem();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            Forms.StarSettingForm S = new Forms.StarSettingForm();
            S.ShowDialog(); //тормазит выполнение формы
            DrawSun();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Controller.Star == null)
            {
                MessageBox.Show("Star isn't exist.");
                return;
            }

            string info = $"Star name: {Controller.Star.Name};\n" +
                $"Star color: {Controller.Star.StarColor};\n"+
                $"Planets: {Controller.Planets.Count};\n";

            foreach (Planet pl in Controller.Planets)
            {
                info += pl.Name+"\n";
            }
            
            richTextBox1.Text = info;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //обитаемая зона

            string info = "";
            
            
            //проверка на существование - добавить везде;
            if (Controller.Star == null || Controller.Planets.Count == 0)
            {
                MessageBox.Show("Star or Planets isn't exist.");
                return;
            }

            //
            foreach (Planet pl in Controller.Planets)
            {
                if (Controller.Star.GetHabitableZone() * 0.8 < pl.SunDistance &&
                    Controller.Star.GetHabitableZone() * 1.1 > pl.SunDistance)
                {
                    info += pl.Name + ";\n";
                }
            }
            
            if (info == "")
            {
                info += "No one planet is not in Habitable zone";
            }

            richTextBox1.Text = info;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //дистанция до солнца
            if (Controller.Star == null || Controller.Planets.Count == 0)
            {
                MessageBox.Show("Star or Planets isn't exist.");
                return;
            }

            string info = "";
            List<Planet> localPlanets = new List<Planet>();

            localPlanets = Controller.Planets.GetRange(0, Controller.Planets.Count);
            localPlanets.Sort();

            foreach (Planet pl in localPlanets)
            {
                info += $"{pl.Name} ({pl.SunDistance});\n";
            }


            if (info == "")
            {
                info += "System haven't planets;";
            }

            richTextBox1.Text = info;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Forms.PlanetSettingForm s2 = new Forms.PlanetSettingForm();
            s2.ShowDialog();
            DrawPlanet();    
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void DrawSun()
        {
            if (Controller.Star != null) //is star object exist
            {
                using (Graphics g = panel1.CreateGraphics())
                {
                    g.DrawImage(Controller.Star.Img, Controller.Star.X, Controller.Star.Y, Controller.Star.ImgSize, Controller.Star.ImgSize);
                }
            }
        }


        public void DrawPlanet()
        {
            if (Controller.Planets.Count() != 0)
            {
                using (Graphics g = panel1.CreateGraphics())
                {
                    Planet p = Controller.Planets[Controller.Planets.Count()-1];
                    
                    int kx = (Controller.Planets.Count()-1)*p.X;
                    int ky = (Controller.Planets.Count() - 1) * p.Y;
                    int j = 1;
                    if (Controller.Planets.Count() > 1)
                    {
                        j = (Controller.Planets.Count());
                    }

                    g.DrawImage(p.Img, p.X+kx, p.Y+ky, p.ImgSize*j, p.ImgSize*j);
                }
            }
        }

    }
}
