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
            MenuJuego2 j2 = new MenuJuego2();
            j2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuJuego3 j3 = new MenuJuego3();
            j3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            this.Hide();
            lg.Show();
        }
    }
}
