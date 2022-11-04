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
    public partial class j1dibujosN3 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();

        int puntos;

        // creo las listas y arrays
        PictureBox[] pictureBoxesArray = new PictureBox[10];
        List<Image> posiblesEmociones = new List<Image>();
        Random raux = new Random();
        int nivel = 0;
        public j1dibujosN3()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\47700176\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb;Persist Security Info=False";
        }

        private void j1dibujosN3_Load(object sender, EventArgs e)
        {
            j1fotosN2 j1p2 = new j1fotosN2();
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
            posiblesEmociones.Add(Tweak_it.Properties.Resources.ContentoD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.TristeD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.EnojadoD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.AsustadoD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.SorprendidoD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.CansadoD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.HambrientoD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.SedientoD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.EnfermoD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.AburridoD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.VerguenzaD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.NerviosoD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.ConfundidoD);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.PreocupadoD);


            // Con esta funcion asigno seis emociones de la lista a los pBoxes
            randomizarImages();
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
            // Vuelvo a agregar las emociones que salieron a la lista.
            for (int j = 0; j < 10; j++)
            {
                posiblesEmociones.Add(pictureBoxesArray[j].Image);
            }

            //Asigno emocion a Pb1
            pB1.Image = pictureBoxesArray[raux.Next(0, pictureBoxesArray.Length)].Image;
        }

        public void click (object sender, EventArgs e)
        {
            var x = sender as PictureBox;
            checkResult(x);
            if (nivel == 5)
            {
                connection.Open();
                nivel = nivel + puntos;
                command.Connection = connection;
                command.CommandText = "INSERT INTO puntos (Puntos, id_usuario) VALUES (" + nivel + ", " + LOGIN.ID + ")";
                command.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                DateTime TiempoFinal = DateTime.Now;
                var Tiempo = (TiempoFinal - LOGIN.TiempoInicio).TotalMinutes;
                int TF = Convert.ToInt32(Tiempo);
                command.Connection = connection;
                command.CommandText = "INSERT INTO tiempo (TiempoEnPantalla, id_usuario) VALUES (" + TF + ", " + LOGIN.ID + ")";
                command.ExecuteNonQuery();

                MessageBox.Show("ya pasaste todos los niveles, felicitaciones");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            eleccionNivelPictos s = new eleccionNivelPictos();
            this.Hide();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            nivel = nivel + puntos;
            command.Connection = connection;
            command.CommandText = "INSERT INTO puntos (Puntos, id_usuario) VALUES (" + nivel + ", " + LOGIN.ID + ")";
            command.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            DateTime TiempoFinal = DateTime.Now;
            var Tiempo = (TiempoFinal - LOGIN.TiempoInicio).TotalMinutes;
            int TF = Convert.ToInt32(Tiempo);
            command.Connection = connection;
            command.CommandText = "INSERT INTO tiempo (TiempoEnPantalla, id_usuario) VALUES (" + TF + ", " + LOGIN.ID + ")";
            command.ExecuteNonQuery();
            Application.Exit();
        }
    }
}
