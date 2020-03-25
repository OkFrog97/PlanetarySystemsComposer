using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetarySystemsComposer.Forms
{
    public partial class PlanetSettingForm : Form
    {
        public PlanetSettingForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBank.PlanetName = richTextBox1.Text;

            try
            {
                DataBank.PlanetMass = double.Parse(richTextBox2.Text);
            }
            catch
            {
                DataBank.PlanetMass = 0.0;
            }

            try
            {
                DataBank.PlanetStarDistance = int.Parse(richTextBox3.Text);
            }
            catch
            {
                DataBank.PlanetStarDistance = 147000000;
            }


        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
