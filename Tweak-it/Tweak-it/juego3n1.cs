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
   
    public partial class juego3n1 : Form
    {
        PictureBox[,] situaciones = new PictureBox[2, 8];
        Random rand = new Random();
        public juego3n1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void juego3n1_Load(object sender, EventArgs e)
        {
            //agrego fotos al array
            situaciones[0, 0].Image = Tweak_it.Properties.Resources.Situación1;
            situaciones[0, 1].Image = Tweak_it.Properties.Resources.Consigna1;
            situaciones[0, 2].Image = Tweak_it.Properties.Resources.contento;
            situaciones[0, 3].Image = Tweak_it.Properties.Resources.enfadado;
            situaciones[0, 4].Image = Tweak_it.Properties.Resources.asustado;
            situaciones[0, 5].Image = Tweak_it.Properties.Resources.Chicojarron;
            situaciones[0, 6].Image = Tweak_it.Properties.Resources.Jarrón;
            situaciones[0, 7].Image = Tweak_it.Properties.Resources.Chicoromp;

            situaciones[1, 0].Image = Tweak_it.Properties.Resources.Situacion2;
            situaciones[1, 1].Image = Tweak_it.Properties.Resources.Consigna2;
            situaciones[1, 2].Image = Tweak_it.Properties.Resources.triste;
            situaciones[1, 3].Image = Tweak_it.Properties.Resources.aburrido;
            situaciones[1, 4].Image = Tweak_it.Properties.Resources.contento;
            situaciones[1, 5].Image = Tweak_it.Properties.Resources.Razon2;
            situaciones[1, 6].Image = Tweak_it.Properties.Resources.Razón1;
            situaciones[1, 7].Image = Tweak_it.Properties.Resources.RazónC;

            randSituacion();
        }
        private void randSituacion()
        {
            int x = rand.Next(situaciones.GetLength(0));
            if (x == 0)
            {
                pB1 = situaciones[0, 0];
                pB2 = situaciones[0, 1];
                pB3 = situaciones[0, 2];
                pB4 = situaciones[0, 3];
                pB5 = situaciones[0, 4];
                pB6 = situaciones[0, 5];
                pB7 = situaciones[0, 6];
                pB8 = situaciones[0, 7];
            }
            else
            {
                pB1 = situaciones[1, 0];
                pB2 = situaciones[1, 1];
                pB3 = situaciones[1, 2];
                pB4 = situaciones[1, 3];
                pB5 = situaciones[1, 4];
                pB6 = situaciones[1, 5];
                pB7 = situaciones[1, 6];
                pB8 = situaciones[1, 7];
            }
        }

    }
}
