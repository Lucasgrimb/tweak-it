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
   
    public partial class juego3n1 : Form
    {
        Image[,] situaciones = new Image[6, 8];
        int x;
        bool correcto = false;
        bool correcto2 = false;
        int a = 0;

        int nivel = 0;
        int puntos;

        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();
        public juego3n1()

        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\47700176\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void juego3n1_Load(object sender, EventArgs e)
        {


            //agrego fotos al array
        

            situaciones[0, 0] = Tweak_it.Properties.Resources.Situación1;
            situaciones[0, 1] = Tweak_it.Properties.Resources.Consigna1;
            situaciones[0, 2] = Tweak_it.Properties.Resources.ContentoD;
            situaciones[0, 3] = Tweak_it.Properties.Resources.EnojadoD;
            situaciones[0, 4] = Tweak_it.Properties.Resources.AsustadoD;
            situaciones[0, 5] = Tweak_it.Properties.Resources.Chicojarron;
            situaciones[0, 6] = Tweak_it.Properties.Resources.Jarrón;
            situaciones[0, 7] = Tweak_it.Properties.Resources.Chicoromp;

            situaciones[1, 0] = Tweak_it.Properties.Resources.Situacion2;
            situaciones[1, 1] = Tweak_it.Properties.Resources.Consigna2;
            situaciones[1, 2] = Tweak_it.Properties.Resources.TristeD;
            situaciones[1, 3] = Tweak_it.Properties.Resources.AburridoD;
            situaciones[1, 4] = Tweak_it.Properties.Resources.ContentoD;
            situaciones[1, 5] = Tweak_it.Properties.Resources.Razon2;
            situaciones[1, 6] = Tweak_it.Properties.Resources.Razón1;
            situaciones[1, 7] = Tweak_it.Properties.Resources.RazónC;

            situaciones[2, 0] = Tweak_it.Properties.Resources.sit3;
            situaciones[2, 1] = Tweak_it.Properties.Resources.elnesta;
            situaciones[2, 2] = Tweak_it.Properties.Resources.TristeD;
            situaciones[2, 3] = Tweak_it.Properties.Resources.EnojadoD;
            situaciones[2, 4] = Tweak_it.Properties.Resources.NerviosoD;
            situaciones[2, 5] = Tweak_it.Properties.Resources.niños;
            situaciones[2, 6] = Tweak_it.Properties.Resources.ndejan;
            situaciones[2, 7] = Tweak_it.Properties.Resources.jugfut;

            situaciones[3, 0] = Tweak_it.Properties.Resources.sit4;
            situaciones[3, 1] = Tweak_it.Properties.Resources.papaest;
            situaciones[3, 2] = Tweak_it.Properties.Resources.AburridoD;
            situaciones[3, 3] = Tweak_it.Properties.Resources.PreocupadoD;
            situaciones[3, 4] = Tweak_it.Properties.Resources.EnfermoD;
            situaciones[3, 5] = Tweak_it.Properties.Resources.mama;
            situaciones[3, 6] = Tweak_it.Properties.Resources.niños;
            situaciones[3, 7] = Tweak_it.Properties.Resources.estenferma;

            situaciones[4, 0] = Tweak_it.Properties.Resources.sit5;
            situaciones[4, 1] = Tweak_it.Properties.Resources.elnesta;
            situaciones[4, 2] = Tweak_it.Properties.Resources.TristeD;
            situaciones[4, 3] = Tweak_it.Properties.Resources.EnojadoD;
            situaciones[4, 4] = Tweak_it.Properties.Resources.VerguenzaD;
            situaciones[4, 5] = Tweak_it.Properties.Resources.secayo;
            situaciones[4, 6] = Tweak_it.Properties.Resources.yogurt;
            situaciones[4, 7] = Tweak_it.Properties.Resources.suelo;

            situaciones[5, 0] = Tweak_it.Properties.Resources.sit6;
            situaciones[5, 1] = Tweak_it.Properties.Resources.elnesta;
            situaciones[5, 2] = Tweak_it.Properties.Resources.AsustadoD;
            situaciones[5, 3] = Tweak_it.Properties.Resources.EnfermoD;
            situaciones[5, 4] = Tweak_it.Properties.Resources.SorprendidoD;
            situaciones[5, 5] = Tweak_it.Properties.Resources.duele;
            situaciones[5, 6] = Tweak_it.Properties.Resources.garganta;
            situaciones[5, 7] = Tweak_it.Properties.Resources.oidos;




            pB1.SizeMode = PictureBoxSizeMode.StretchImage;
            pB2.SizeMode = PictureBoxSizeMode.StretchImage;
            pB3.SizeMode = PictureBoxSizeMode.StretchImage;
            pB4.SizeMode = PictureBoxSizeMode.StretchImage;
            pB5.SizeMode = PictureBoxSizeMode.StretchImage;
            pB6.SizeMode = PictureBoxSizeMode.StretchImage;
            pB7.SizeMode = PictureBoxSizeMode.StretchImage;
            pB8.SizeMode = PictureBoxSizeMode.StretchImage;

            sit1();
          
       

           
        }



        private void pB3_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }
            else if (a == 1)
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }
            else if (a == 2)
            {
                MessageBox.Show("emocion correcta");
                correcto = true;
                nivel++;
                variablescomp.puntos++;
            }
            else if (a == 3)
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }
            else if (a == 4)
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }
            else  
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }



        }

        private void pB4_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                MessageBox.Show("emocion correcta");
                correcto = true;
                nivel++;
                variablescomp.puntos++;
            }
            else if (a == 1)
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }          
            else if (a == 2)
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }
            else if (a == 3)
            {
                MessageBox.Show("emocion correcta");
                correcto = true;
                nivel++;
                variablescomp.puntos++;
            }
            else if (a == 4)
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }
            else
            {
                MessageBox.Show("emocion correcta");
                correcto = true;
                nivel++;
                variablescomp.puntos++;
            }

        }

        private void pB5_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }
            else if (a == 1)
            {
                MessageBox.Show("emocion correcta");
                correcto = true;
                nivel++;
                variablescomp.puntos++;
            }
            else if (a == 2)
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }
            else if (a == 3)
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }
            else if (a == 4)
            {
                MessageBox.Show("emocion correcta");
                correcto = true;
                nivel++;
                variablescomp.puntos++;
            }
            else 
            {
                MessageBox.Show("emocion incorrecta, volve a intentar");
            }
        }

        private void pB6_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                MessageBox.Show("causa incorrecta, volve a intentar");
            }
            else if (a == 1)
            {
                MessageBox.Show("causa incorrecta, volve a intentar");
            }
            else if (a == 2)
            {
                MessageBox.Show("causa incorrecta, volve a intentar");
            }
            else if (a == 3)
            {
                MessageBox.Show("causa incorrecta, volve a intentar");
            }
            else if (a == 4)
            {
                if (correcto == true)
                {
                    MessageBox.Show("Muy bien, pasaste de nivel");
                    correcto = false;
                    sit6();
                    a++;
                    nivel++;
                    variablescomp.puntos++;
                }
                else
                {
                    MessageBox.Show("debes elegir la emocion correcta");
                }
            }
            else if (a == 5)
            {
                if (correcto == true)
                {
                    MessageBox.Show("Muy bien, completaste el juego");
                    correcto = false;
                    j1pictosN1.puntos++;
                    nivel++;
                    MenuJuego3 f1 = new MenuJuego3();
                    f1.Show();
                    this.Hide();
                    variablescomp.puntos++;

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
                }
                else
                {
                    MessageBox.Show("debes elegir la emocion correcta");
                }
            }

        }

        private void pB7_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                MessageBox.Show("causa incorrecta volve a intentar");
            }
            else if (a == 1)
            {
                MessageBox.Show("causa incorrecta, volve a intentar");
            }
            else if (a == 2)
            {
                if (correcto == true)
                {
                    MessageBox.Show("Muy bien, pasaste de nivel");
                    correcto = false;
                    sit4();
                    a++;
                    nivel++;
                    j1pictosN1.puntos++;
                    variablescomp.puntos++;
                }
                else
                {
                    MessageBox.Show("debes elegir la emocion correcta");
                }
            }
            else if (a == 3)
            {
                MessageBox.Show("causa incorrecta, volve a intentar");
            }
            else if(a==4)
            {
                MessageBox.Show("causa incorrecta, volve a intentar");
            }
            else 
            {
                MessageBox.Show("causa incorrecta volve a intentar");
            }
        }

        private void pB8_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (correcto == true)
                {
                    MessageBox.Show("Muy bien, pasaste de nivel");
                    correcto = false;
                    sit2();
                    nivel++;
                    a++;
                    variablescomp.puntos++;
                }
                else
                {
                    MessageBox.Show("debes elegir la emocion correcta");
                }
            }
            else if (a == 1)
            {
                if (correcto == true)
                {
                    MessageBox.Show("Muy bien, pasaste de nivel");
                    correcto = false;
                    a++;
                    sit3();
                    nivel++;
                    variablescomp.puntos++;
                }
                else
                {
                    MessageBox.Show("debes elegir la emocion correcta");
                }
            }
            else if (a == 2)
            {
                MessageBox.Show("causa incorrecta, volve a intentar");
            }
            else if (a == 3)
            {
                if (correcto == true)
                {
                    MessageBox.Show("Muy bien, pasaste de nivel");
                    correcto = false;
                    sit5();
                    a++;
                    nivel++;
                    variablescomp.puntos++;
                }
                else
                {
                    MessageBox.Show("debes elegir la emocion correcta");
                }
            }
            else if (a == 4)
            {
                MessageBox.Show("causa incorrecta, volve a intentar");
            }
            else 
            {
                MessageBox.Show("causa incorrecta volve a intentar");
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

        private void sit3()
        {
            pB1.Image = situaciones[2, 0];
            pB2.Image = situaciones[2, 1];
            pB3.Image = situaciones[2, 2];
            pB4.Image = situaciones[2, 3];
            pB5.Image = situaciones[2, 4];
            pB6.Image = situaciones[2, 5];
            pB7.Image = situaciones[2, 6];
            pB8.Image = situaciones[2, 7];
        }

        private void sit4()
        {
            pB1.Image = situaciones[3, 0];
            pB2.Image = situaciones[3, 1];
            pB3.Image = situaciones[3, 2];
            pB4.Image = situaciones[3, 3];
            pB5.Image = situaciones[3, 4];
            pB6.Image = situaciones[3, 5];
            pB7.Image = situaciones[3, 6];
            pB8.Image = situaciones[3, 7];
        }

        private void sit5()
        {
            pB1.Image = situaciones[4, 0];
            pB2.Image = situaciones[4, 1];
            pB3.Image = situaciones[4, 2];
            pB4.Image = situaciones[4, 3];
            pB5.Image = situaciones[4, 4];
            pB6.Image = situaciones[4, 5];
            pB7.Image = situaciones[4, 6];
            pB8.Image = situaciones[4, 7];
        }

        private void sit6()
        {
            pB1.Image = situaciones[5, 0];
            pB2.Image = situaciones[5, 1];
            pB3.Image = situaciones[5, 2];
            pB4.Image = situaciones[5, 3];
            pB5.Image = situaciones[5, 4];
            pB6.Image = situaciones[5, 5];
            pB7.Image = situaciones[5, 6];
            pB8.Image = situaciones[5, 7];
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuJuego3 mj3 = new MenuJuego3();
            this.Hide();
            mj3.Show();
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

