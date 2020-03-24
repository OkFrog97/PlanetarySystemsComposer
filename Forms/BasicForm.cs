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

        public String SomeVal { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }


        /*
        private void button2_Click(object sender, EventArgs e)
        {
            //Эта кнопка должна отрисовывать солнышко
            //код анона
            Star Sun = new Star();
            using (Graphics g = panel1.CreateGraphics())
            {
                g.DrawImage(Sun.Img, Sun.X, Sun.Y, Sun.ImgSize, Sun.ImgSize);
            }

            //test
            Planet Earth = new Planet ();
            using (Graphics g = panel1.CreateGraphics())
            {
                g.DrawImage(Earth.Img, Earth.X, Earth.Y, Earth.ImgSize, Earth.ImgSize);
            }



        }
        */


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
            MessageBox.Show(DataBank.StarName); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Forms.StarSettingForm S = new Forms.StarSettingForm();
            S.Show();
            /*
            if (DataBank.isCreateStar)
            {
                Star Sun = new Star();
                using (Graphics g = panel1.CreateGraphics()) //два раза один код? Фу. Переписать после теста
                    {
                        g.DrawImage(Sun.Img, Sun.X, Sun.Y, Sun.ImgSize, Sun.ImgSize);
                    }
            }
            */
            Star Sun = new Star();
            using (Graphics g = panel1.CreateGraphics()) //два раза один код? Фу. Переписать после теста
            {
                g.DrawImage(Sun.Img, Sun.X, Sun.Y, Sun.ImgSize, Sun.ImgSize);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {

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
            Planet Earth = new Planet();
            using (Graphics g = panel1.CreateGraphics())
            {
                g.DrawImage(Earth.Img, Earth.X, Earth.Y, Earth.ImgSize, Earth.ImgSize);
            }
        }

       public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
