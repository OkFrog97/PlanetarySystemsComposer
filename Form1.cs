﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HelloWorld");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Эта кнопка должна отрисовывать солнышко
            //код анона
            Star Sun = new Star();
            using (Graphics g = panel1.CreateGraphics())
            {
                g.DrawImage(Sun.SunImg, Sun.x, Sun.y, Sun.Size, Sun.Size);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
