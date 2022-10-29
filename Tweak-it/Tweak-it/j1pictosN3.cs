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
    public partial class j1pictosN3 : Form
    {
        DateTime TiempoFinal = DateTime.Now;
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();

        // creo las listas y arrays
        PictureBox[] pictureBoxesArray = new PictureBox[10];
        List<Image> posiblesEmociones = new List<Image>();
        Random raux = new Random();
        int nivel = 0;

        public j1pictosN3()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
        }

        private void j1pictosN3_Load(object sender, EventArgs e)
        {
            j1pictosN2 j1p2 = new j1pictosN2();
            j1p2.Show();
            //agrego pBoxes al array 
            pictureBoxesArray[0] = pB2;
            pictureBoxesArray[1] = pB3;
            pictureBoxesArray[2] = pB4;
            pictureBoxesArray[3] = pB5;
            pictureBoxesArray[4] = pB6;
            pictureBoxesArray[5] = pB7;
            pictureBoxesArray[6] = pB8;
            pictureBoxesArray[7] = pB9;
            pictureBoxesArray[8] = pB10;
            pictureBoxesArray[9] = pB11;



            // pongo las imagenes en un formato especial para que se vean centradas
            for (int x = 0; x < pictureBoxesArray.Length; x++)
            {
                pictureBoxesArray[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            pB1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Agrego las imagenes de resources a la lista con las emociones que se usarán en el nivel
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Contento);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Triste);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Enojado);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Asustado);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Sorprendido);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Cansado);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Hambriento);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Sediento);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Enfermo);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Aburrido);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Verguenza);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Nervioso);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Confundido);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Preocupado);


            // Con esta funcion asigno seis emociones de la lista a los pBoxes
            randomizarImages();
        }
        private void checkResult(PictureBox pB)
        {
            if (pB.Image == pB1.Image)
            {
                randomizarImages();
                nivel++;
                j1pictosN1.puntos++;
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
            while (posiblesEmociones.Count > 4)
            {
                int i = raux.Next(0, posiblesEmociones.Count);
                pictureBoxesArray[contador].Image = posiblesEmociones[i];
                posiblesEmociones.RemoveAt(i);
                contador++;
            }
            // Vuelvo a agregar las emociones que salieron a la lista para que puedan volver a salir cuando quiero juegar de nuevo y se uso la funcion randomizarImagenes.
            for (int j = 0; j < 10; j++)
            {
                posiblesEmociones.Add(pictureBoxesArray[j].Image);
            }

            //Asigno emocion a Pb1
            pB1.Image = pictureBoxesArray[raux.Next(0, pictureBoxesArray.Length)].Image;
        }

        private void pB2_Click(object sender, EventArgs e)
        {
            checkResult(pB2);
            if (nivel == 10)
            {
                MessageBox.Show("ya pasaste todos los niveles, felicitaciones");
            }
        }

        private void pB3_Click(object sender, EventArgs e)
        {
            checkResult(pB3);
            if (nivel == 10)
            {
                MessageBox.Show("ya pasaste todos los niveles, felicitaciones");
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            checkResult(pB4);
            if (nivel == 10)
            {
                MessageBox.Show("ya pasaste todos los niveles, felicitaciones");
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            checkResult(pB5);
            if (nivel == 10)
            {
                MessageBox.Show("ya pasaste todos los niveles, felicitaciones");
            }
        }
        private void pB6_Click(object sender, EventArgs e)
        {
            checkResult(pB6);
            if (nivel == 10)
            {
                MessageBox.Show("ya pasaste todos los niveles, felicitaciones");
            }
        }

        private void pB7_Click(object sender, EventArgs e)
        {
            checkResult(pB7);
            if (nivel == 10)
            {
                MessageBox.Show("ya pasaste todos los niveles, felicitaciones");
            }
        }

        private void pB8_Click(object sender, EventArgs e)
        {
            checkResult(pB8);
            if (nivel == 10)
            {
                MessageBox.Show("ya pasaste todos los niveles, felicitaciones");
            }
        }

        private void pB9_Click(object sender, EventArgs e)
        {
            checkResult(pB9);
            if (nivel == 10)
            {
                MessageBox.Show("ya pasaste todos los niveles, felicitaciones");
            }
        }

        private void pB10_Click(object sender, EventArgs e)
        {
            checkResult(pB10);
            if (nivel == 10)
            {
                MessageBox.Show("ya pasaste todos los niveles, felicitaciones");
            }
        }

        private void pB11_Click(object sender, EventArgs e)
        {
            checkResult(pB11);
            if (nivel == 10)
            {
                MessageBox.Show("ya pasaste todos los niveles, felicitaciones");
            }
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            j1pictosN2 j2p = new j1pictosN2();
            j2p.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan ts = TiempoFinal - LOGIN.TiempoInicio;
            double tiempo = ts.TotalMinutes;
            int TiempoFinal2 = (int)tiempo;

            connection.Open();
            command.Connection = connection;
            command.CommandText = "UPDATE info SET TiempoEnPantalla=" + TiempoFinal2 + " WHERE Nombre='" + LOGIN.nombre + "' AND Apellido='" + LOGIN.apellido + "'";
            command.ExecuteNonQuery();
            connection.Close();

            Application.Exit();
            
        }
    }
}
