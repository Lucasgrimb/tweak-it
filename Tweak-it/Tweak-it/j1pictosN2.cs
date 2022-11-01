﻿using System;
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
    public partial class j1pictosN2 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;

        public static int puntos = puntos += 1;
        // creo las listas y arrays
        PictureBox[] pictureBoxesArray = new PictureBox[6];
        List<Image> posiblesEmociones = new List<Image>();
        Random raux = new Random();
        int nivel = 0;
       

        public j1pictosN2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
        }

        private void j1dibujos_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(variablescomp.puntos));
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
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Contento);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Triste);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Enojado);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Asustado);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Sorprendido);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Cansado);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Hambriento);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Sediento);
            posiblesEmociones.Add(Tweak_it.Properties.Resources.Enfermo);


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
            if (nivel == 10)
            {
                connection.Open();
                DateTime TiempoFinal = DateTime.Now;
                var Tiempo = (TiempoFinal - LOGIN.TiempoInicio).TotalMinutes;
                int TF = Convert.ToInt32(Tiempo);
                nivel = nivel + puntos;

                command = new OleDbCommand("UPDATE info SET Puntos=" + nivel + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
                OleDbCommand command2 = new OleDbCommand("UPDATE info SET TiempoEnPantalla=" + TF + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                connection.Close();

                j1pictosN3 j1p3 = new j1pictosN3();
                j1p3.Show();
                this.Hide();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            checkResult(pB3);
            if (nivel == 10)
            {
                connection.Open();
                DateTime TiempoFinal = DateTime.Now;
                var Tiempo = (TiempoFinal - LOGIN.TiempoInicio).TotalMinutes;
                int TF = Convert.ToInt32(Tiempo);
                nivel = nivel + puntos;

                command = new OleDbCommand("UPDATE info SET Puntos=" + nivel + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
                OleDbCommand command2 = new OleDbCommand("UPDATE info SET TiempoEnPantalla=" + TF + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                connection.Close();

                j1pictosN3 j1p3 = new j1pictosN3();
                j1p3.Show();
                this.Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            checkResult(pB4);
            if (nivel == 10)
            {
                connection.Open();
                DateTime TiempoFinal = DateTime.Now;
                var Tiempo = (TiempoFinal - LOGIN.TiempoInicio).TotalMinutes; 
                int TF = Convert.ToInt32(Tiempo);
                nivel = nivel + puntos;

                command = new OleDbCommand("UPDATE info SET Puntos=" + nivel + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
                OleDbCommand command2 = new OleDbCommand("UPDATE info SET TiempoEnPantalla=" + TF + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                connection.Close();

                j1pictosN3 j1p3 = new j1pictosN3();
                j1p3.Show();
                this.Hide();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            checkResult(pB5);
            if (nivel == 10)
            {
                connection.Open();
                DateTime TiempoFinal = DateTime.Now;
                var Tiempo = (TiempoFinal - LOGIN.TiempoInicio).TotalMinutes;
                int TF = Convert.ToInt32(Tiempo);
                nivel = nivel + puntos;

                command = new OleDbCommand("UPDATE info SET Puntos=" + nivel + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
                OleDbCommand command2 = new OleDbCommand("UPDATE info SET TiempoEnPantalla=" + TF + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();

                j1pictosN3 j1p3 = new j1pictosN3();
                j1p3.Show();
                this.Hide();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            checkResult(pB6);
            if (nivel == 10)
            {
                connection.Open();
                DateTime TiempoFinal = DateTime.Now;
                var Tiempo = (TiempoFinal - LOGIN.TiempoInicio).TotalMinutes;
                int TF = Convert.ToInt32(Tiempo);
                nivel = nivel + puntos;

                command = new OleDbCommand("UPDATE info SET Puntos=" + nivel + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
                OleDbCommand command2 = new OleDbCommand("UPDATE info SET TiempoEnPantalla=" + TF + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                connection.Close();

                j1pictosN3 j1p3 = new j1pictosN3();
                j1p3.Show();
                this.Hide();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            checkResult(pB7);
            if (nivel == 10)
            {
                connection.Open();
                DateTime TiempoFinal = DateTime.Now;
                var Tiempo = (TiempoFinal - LOGIN.TiempoInicio).TotalMinutes;
                int TF = Convert.ToInt32(Tiempo);
                nivel = nivel + puntos;

                command = new OleDbCommand("UPDATE info SET Puntos=" + nivel + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
                OleDbCommand command2 = new OleDbCommand("UPDATE info SET TiempoEnPantalla=" + TF + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                connection.Close();

                j1pictosN3 j1p3 = new j1pictosN3();
                j1p3.Show();
                this.Hide();
            }
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            j1pictosN1 jn1 = new j1pictosN1();
            jn1.Show();
            this.Hide();
        }

        private void pB1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form1 jn1 = new Form1();
            jn1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            DateTime TiempoFinal = DateTime.Now;
            var Tiempo = (TiempoFinal - LOGIN.TiempoInicio).TotalMinutes;
            int TF = Convert.ToInt32(Tiempo);
            nivel = nivel + puntos;

            command = new OleDbCommand("UPDATE info SET Puntos=" + nivel + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
            OleDbCommand command2 = new OleDbCommand("UPDATE info SET TiempoEnPantalla=" + TF + " WHERE Nombre='" + LOGIN.name + "' AND Apellido='" + LOGIN.lastname + "'", connection);
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connection.Close();
            Application.Exit();

            Application.Exit();
        }
    }
}
