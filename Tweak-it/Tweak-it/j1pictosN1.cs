using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tweak_it
{
    public partial class j1pictosN1 : Form
    {
        OleDbConnection connection = new OleDbConnection();

        PictureBox[] pictureBoxesArray = new PictureBox[3];
        List<Image> posiblesEmociones = new List<Image>();
        Random raux = new Random();
        
        int nivel = 0;
        public static int puntos = puntos +=1;

        public j1pictosN1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
        }

        private void j1pictos_Load(object sender, EventArgs e)
        {
        
            //agrego los pBox que cree por pantalla al array pictureBoxesArray

            pictureBoxesArray[0] = pB2;
            pictureBoxesArray[1] = pB3;
            pictureBoxesArray[2] = pB4;

            //Esto es una funcion para que las imagenes se vean centradas en el pBox
            for (int x = 0; x < pictureBoxesArray.Length; x++)
            {
                pictureBoxesArray[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            pB1.SizeMode = PictureBoxSizeMode.StretchImage;

            //Cargo la imagen de la compu y las meto en el array      
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Contento);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Triste);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Enojado);


            randomizarImages();

        }
        private void randomizarImages()
        {
            //Asigno una emocion a cada pBox aleatoriamente
            int contador = 0;
            while (posiblesEmociones.Count > 0)
            {
                int i = raux.Next(0, posiblesEmociones.Count);
                pictureBoxesArray[contador].Image = posiblesEmociones[i];
                posiblesEmociones.RemoveAt(i);
                contador++;
            }
          for (int j = 0; j < 3; j++)
            {
               posiblesEmociones.Add(pictureBoxesArray[j].Image);
           }

            //Asigno emocion a Pb1
            pB1.Image = pictureBoxesArray[raux.Next(0, pictureBoxesArray.Length)].Image;
        }
        private void checkResult(PictureBox pB)
        {
            if (pB.Image == pB1.Image)
            {
                randomizarImages();
                nivel++;
                variablescomp.puntos++;
            }
            else
            {
                MessageBox.Show("emocion incorrecta, volve a intentarlo");
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pB2_Click(object sender, EventArgs e)
        {
            checkResult(pB2);
           if (nivel == 10)
            {
                j1pictosN2 j1d = new j1pictosN2();
                j1d.Show();
                this.Hide();    
            }
        }

        private void pB3_Click(object sender, EventArgs e)
        {
            checkResult(pB3);
            if (nivel == 10)
            {

                j1pictosN2 j1d = new j1pictosN2();
                j1d.Show();
                this.Hide();
            }
        }

        private void pB4_Click(object sender, EventArgs e)
        {
            checkResult(pB4);
            if (nivel == 10)
            {
                j1pictosN2 j1d = new j1pictosN2();
                j1d.Show();
                this.Hide();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            juego1 j1 = new juego1();
            j1.Show();
            this.Hide();
        }
    }
}

