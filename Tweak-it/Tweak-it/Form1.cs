using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tweak_it
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            eleccionNivelPictos j1 = new eleccionNivelPictos();
            j1.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            j2N1 j2 = new j2N1();
            j2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            juego3n1 j3 = new juego3n1();
            j3.Show();
            this.Hide();
        }
    }
}
