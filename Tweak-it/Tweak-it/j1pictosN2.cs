﻿using System;
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
    public partial class j1pictosN2 : Form
    {
        // creo las listas y arrays
        PictureBox[] pictureBoxesArray = new PictureBox[6];
        List<Image> posiblesEmociones = new List<Image>();
        Random raux = new Random();
        int nivel = 0;

        public j1pictosN2()
        {
            InitializeComponent();
        }

        private void j1dibujos_Load(object sender, EventArgs e)
        {
            //agrego pBoxes al array 
            pictureBoxesArray[0] = pB2;
            pictureBoxesArray[1] = pB3;
            pictureBoxesArray[2] = pB4;
            pictureBoxesArray[3] = pB5;
            pictureBoxesArray[4] = pB6;
            pictureBoxesArray[5] = pB7;

            // pongo las imagenes en un formato especial para que se vean centradas
            for (int x = 0; x < pictureBoxesArray.Length; x++)
            {
                pictureBoxesArray[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            pB1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Agrego las imagenes de resources a la lista con las emociones que se usarán en el nivel
            posiblesEmociones.Add(Tweak_it.Properties.Resources.contento);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.triste);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.enfadado);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.asustado);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.sorprendido);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.cansado);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.hambriento);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.sediento);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.enfermo);


            // Con esta funcion asigno seis emociones de la lista a los pBoxes
            randomizarImages();
        }
        private void checkResult(PictureBox pB)
        {
            if (pB.Image == pB1.Image)
            {
                randomizarImages();
                nivel++;
            }
            else
            {
                MessageBox.Show("emocion incorrecta, volve a intentarlo");
            }
        }
        private void randomizarImages()
        {
            //Asigno una emocion a cada pBox aleatoriamente
            int contador = 0;
            while (posiblesEmociones.Count > 3)
            {
                int i = raux.Next(0, posiblesEmociones.Count);
                pictureBoxesArray[contador].Image = posiblesEmociones[i];
                posiblesEmociones.RemoveAt(i);
                contador++;
            }
            // Vuelvo a agregar las emociones que salieron a la lista para que puedan volver a salir cuando quiero juegar de nuevo y se uso la funcion randomizarImagenes.
            for (int j = 0; j < 6; j++)
            {
                posiblesEmociones.Add(pictureBoxesArray[j].Image);
            }

            //Asigno emocion a Pb1
            pB1.Image = pictureBoxesArray[raux.Next(0, pictureBoxesArray.Length)].Image;
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            checkResult(pB2);          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            checkResult(pB3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            checkResult(pB4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            checkResult(pB5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            checkResult(pB6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            checkResult(pB7);
        }
    }
}
