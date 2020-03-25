using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetarySystemsComposer
{
    public partial class Form1 : Form
    {

        static CelestialObject Sun;


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

            string info = $"Star name: {Controller.Star.Name};\n" +
                $"Star color: {Controller.Star.StarColor};\n"+
                $"Planets: {0};\n";
            
            richTextBox1.Text = info;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //test
            Forms.PlanetSettingForm s2 = new Forms.PlanetSettingForm();
            s2.ShowDialog();
            //drawplanet
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

    }
}
