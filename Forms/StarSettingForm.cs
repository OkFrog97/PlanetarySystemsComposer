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
  
    public partial class StarSettingForm : Form
    {
        string selectedElementListBox1; //Спектральынй класс предполагает определенный цвет, характеристика цвета звещды лишняя

        public StarSettingForm()
        {
            
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /*
            Form1 f = new Form1();
            f.SomeVal = this.richTextBox1.Text;
            */
            DataBank.StarName = this.richTextBox1.Text;

            try
            {
                DataBank.StarMass = double.Parse(this.richTextBox2.Text); //валидация
            }
            catch (System.FormatException) {
                
            }
            DataBank.StarStellarClass = selectedElementListBox1;
            DataBank.isCreateStar = true;
            Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StarSettingForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedElementListBox1 = listBox1.SelectedItem.ToString();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
