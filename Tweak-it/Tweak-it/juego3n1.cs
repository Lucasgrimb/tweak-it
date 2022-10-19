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
        Image[,] situaciones = new Image[2, 8];
        String [] sits = new String [2];
        Random rand = new Random();
        int x;
        bool correcto = false;
        bool correcto2 = false;
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
        

            situaciones[0, 0] = Tweak_it.Properties.Resources.Situación1;
            situaciones[0, 1] = Tweak_it.Properties.Resources.Consigna1;
            situaciones[0, 2] = Tweak_it.Properties.Resources.contento;
            situaciones[0, 3] = Tweak_it.Properties.Resources.enfadado;
            situaciones[0, 4] = Tweak_it.Properties.Resources.asustado;
            situaciones[0, 5] = Tweak_it.Properties.Resources.Chicojarron;
            situaciones[0, 6] = Tweak_it.Properties.Resources.Jarrón;
            situaciones[0, 7] = Tweak_it.Properties.Resources.Chicoromp;

            situaciones[1, 0] = Tweak_it.Properties.Resources.Situacion2;
            situaciones[1, 1] = Tweak_it.Properties.Resources.Consigna2;
            situaciones[1, 2] = Tweak_it.Properties.Resources.triste;
            situaciones[1, 3] = Tweak_it.Properties.Resources.aburrido;
            situaciones[1, 4] = Tweak_it.Properties.Resources.contento;
            situaciones[1, 5] = Tweak_it.Properties.Resources.Razon2;
            situaciones[1, 6] = Tweak_it.Properties.Resources.Razón1;
            situaciones[1, 7] = Tweak_it.Properties.Resources.RazónC;

            pB1.SizeMode = PictureBoxSizeMode.StretchImage;
            pB2.SizeMode = PictureBoxSizeMode.StretchImage;
            pB3.SizeMode = PictureBoxSizeMode.StretchImage;
            pB4.SizeMode = PictureBoxSizeMode.StretchImage;
            pB5.SizeMode = PictureBoxSizeMode.StretchImage;
            pB6.SizeMode = PictureBoxSizeMode.StretchImage;
            pB7.SizeMode = PictureBoxSizeMode.StretchImage;
            pB8.SizeMode = PictureBoxSizeMode.StretchImage;

            sits[0] = "sit1";
            sits[1] = "sit2";
            int x = rand.Next(0, sits.Length);
            randsit();
       

           
        }



        private void pB3_Click(object sender, EventArgs e)
        {
            if(x == 0)
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }
        }

        private void pB4_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                MessageBox.Show("emocion correcta");
                correcto = true;
            }
        }

        private void pB5_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }
        }

        private void pB6_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                MessageBox.Show("causa incorrecta, volve a intentar");
            }
        }

        private void pB7_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                MessageBox.Show("causa incorrecta volve a intentar");
            }
        }

        private void pB8_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                if (correcto == true)
                {
                    MessageBox.Show("Muy bien, pasaste de nivel");               
                }
                else
                {
                    MessageBox.Show("debes elegir la emocion correcta");
                }
            }
        }

        private void sit1()
        {
            pB1.Image = situaciones[0, 0];
            pB2.Image = situaciones[0, 1];
            pB3.Image = situaciones[0, 2];
            pB4.Image = situaciones[0, 3];
            pB5.Image = situaciones[0, 4];
            pB6.Image = situaciones[0, 5];
            pB7.Image = situaciones[0, 6];
            pB8.Image = situaciones[0, 7];
        }

        private void sit2()
        {
            pB1.Image = situaciones[1, 0];
            pB2.Image = situaciones[1, 1];
            pB3.Image = situaciones[1, 2];
            pB4.Image = situaciones[1, 3];
            pB5.Image = situaciones[1, 4];
            pB6.Image = situaciones[1, 5];
            pB7.Image = situaciones[1, 6];
            pB8.Image = situaciones[1, 7];
        }

        private void randsit()
        {
        
            if (x == 0)
            {
                sit1();
            }
            else if (x == 1)
            {
                sit2();
            }
        }

        }
    }

