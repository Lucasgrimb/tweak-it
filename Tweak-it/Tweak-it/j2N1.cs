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
    public partial class j2N1 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();

        int puntos;

        PictureBox[] pBpictos = new PictureBox[5];
        PictureBox[] pBdibujos = new PictureBox[5];
        List<Image> pictos = new List<Image>();
        List<Image> dibujos = new List<Image>();
        List<Image> ndibujos = new List<Image>();
        Random rand = new Random();
        String aux;       
        int nivel = 0;
        bool pb1 = false;
        bool pb2 = false;
        bool pb3 = false;
        bool pb4 = false;
        bool pb5 = false;


        public j2N1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\47700176\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
        }

        private void j2N1_Load(object sender, EventArgs e)
        {
            //agrego Pb al arrray
            pBpictos[0] = pB1p;
            pBpictos[1] = pB2p;
            pBpictos[2] = pB3p;
            pBpictos[3] = pB4p;
            pBpictos[4] = pB5p;

            pBdibujos[0] = pB1d;
            pBdibujos[1] = pB2d;
            pBdibujos[2] = pB3d;
            pBdibujos[3] = pB4d;
            pBdibujos[4] = pB5d;


            // pongo las imagenes en un formato especial para que se vean centradas
            for (int x = 0; x < pBpictos.Length; x++)
            {
                pBpictos[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            for (int x = 0; x < pBdibujos.Length; x++)
            {
                pBdibujos[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            // Agrego imagenes a las listas
            pictos.Add(Tweak_it.Properties.Resources.Contento);
            pictos.Add(Tweak_it.Properties.Resources.Triste);
            pictos.Add(Tweak_it.Properties.Resources.Enojado);
            pictos.Add(Tweak_it.Properties.Resources.Asustado);
            pictos.Add(Tweak_it.Properties.Resources.Sorprendido);
            pictos.Add(Tweak_it.Properties.Resources.Cansado);
            pictos.Add(Tweak_it.Properties.Resources.Hambriento);
            pictos.Add(Tweak_it.Properties.Resources.Sediento);
            pictos.Add(Tweak_it.Properties.Resources.Enfermo);
            pictos.Add(Tweak_it.Properties.Resources.Aburrido);
            pictos.Add(Tweak_it.Properties.Resources.Preocupado);

            dibujos.Add(Tweak_it.Properties.Resources.ContentoD);
            dibujos.Add(Tweak_it.Properties.Resources.TristeD);
            dibujos.Add(Tweak_it.Properties.Resources.EnojadoD);
            dibujos.Add(Tweak_it.Properties.Resources.AsustadoD);
            dibujos.Add(Tweak_it.Properties.Resources.SorprendidoD);
            dibujos.Add(Tweak_it.Properties.Resources.CansadoD);
            dibujos.Add(Tweak_it.Properties.Resources.HambrientoD);
            dibujos.Add(Tweak_it.Properties.Resources.SedientoD);
            dibujos.Add(Tweak_it.Properties.Resources.EnfermoD);
            dibujos.Add(Tweak_it.Properties.Resources.AburridoD);
            dibujos.Add(Tweak_it.Properties.Resources.PreocupadoD);
            


            //Asigno tag para cada emocion
            pictos[0].Tag = "nivelento";
            pictos[1].Tag = "triste";
            pictos[2].Tag = "enfadado";
            pictos[3].Tag = "asustado";
            pictos[4].Tag = "sorprendido";
            pictos[5].Tag = "cansado";
            pictos[6].Tag = "hambriento";
            pictos[7].Tag = "sediento";
            pictos[8].Tag = "enfermo";
            pictos[9].Tag = "aburrido";
            pictos[10].Tag = "preocupado";


            dibujos[0].Tag = "nivelento";
            dibujos[1].Tag = "triste";
            dibujos[2].Tag = "enfadado";
            dibujos[3].Tag = "asustado";
            dibujos[4].Tag = "sorprendido";
            dibujos[5].Tag = "cansado";
            dibujos[6].Tag = "hambriento";
            dibujos[7].Tag = "sediento";
            dibujos[8].Tag = "enfermo";
            dibujos[9].Tag = "aburrido";
            dibujos[10].Tag = "preocupado";

            randomizarImagenes();

        }

        private void randomizarImagenes()
       {



            //asigno emociones a pBpictos

            for (int i = 0; i < 5; i++)
            {
                int x = rand.Next(0, pictos.Count);

                pBpictos[i].Image = pictos[x];
                pBpictos[i].Tag = i.ToString();
                ndibujos.Add(dibujos[x]);
                pictos.RemoveAt(x);
                dibujos.RemoveAt(x);
            }
            for (int j = 0; j < 5; j++)
            {
                int f = rand.Next(0, ndibujos.Count);
                pBdibujos[j].Image = ndibujos[f];
                ndibujos.RemoveAt(f);
            }

        }

        private void pB1p_Click(object sender, EventArgs e)
        {                             
                aux = pB1p.Image.Tag.ToString();            
        }

        private void pB2p_Click(object sender, EventArgs e)
           
        {
            aux = pB2p.Image.Tag.ToString();
        }

        private void pB3p_Click(object sender, EventArgs e)
        {
            aux = pB3p.Image.Tag.ToString();
        }

        private void pB4p_Click(object sender, EventArgs e)
        {
            aux = pB4p.Image.Tag.ToString();
        }

        private void pB5p_Click(object sender, EventArgs e)
        {
            aux = pB5p.Image.Tag.ToString();
        }

        private void pB1d_Click(object sender, EventArgs e)
        {
            if (pb1 == false)
            {
                if (pB1d.Image.Tag.ToString() == aux)
                {
                    MessageBox.Show("Correcto");
                    nivel++;
                    variablescomp.puntos++;
                    aux = "x";
                    pb1 = true;
                    if (nivel == 5 && pictos.Count() > 1)
                    {
                        randomizarImagenes();
                        nivel = 0;
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }
                    else if (nivel == 5 && pictos.Count() == 1)
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

                        j2N2 j2 = new j2N2();
                        j2.Show();
                        this.Hide();
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }

                }
                else
                {
                    MessageBox.Show("incorrecto, volve a intentarlo");
                }
            }
            else
            {
                MessageBox.Show("Ya matcheaste esta emocion");
            }

        }

        private void pB2d_Click(object sender, EventArgs e)
        {
            if (pb2 == false)
            {
                if (pB2d.Image.Tag.ToString() == aux)
                {
                    MessageBox.Show("Correcto");
                    nivel++;
                    aux = "x";
                    pb2 = true;
                    variablescomp.puntos++;
                    if (nivel == 5 && pictos.Count() > 1)
                    {
                        randomizarImagenes();
                        nivel = 0;
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;

                    }
                    else if (nivel == 5 && pictos.Count() == 1)
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

                        j2N2 j2 = new j2N2();
                        j2.Show();
                        this.Hide();
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }

                }
                else
                {
                    MessageBox.Show("incorrecto, volve a intentarlo");
                }
            }
            else
            {
                MessageBox.Show("Ya matcheaste esta emocion");
            }

        }

        private void pB3d_Click(object sender, EventArgs e)
        {
            if (pb3 == false)
            {
                if (pB3d.Image.Tag.ToString() == aux)
                {
                    MessageBox.Show("Correcto");
                    nivel++;
                    variablescomp.puntos++;
                    aux = "x";
                    pb3 = true;
                    if (nivel == 5 && pictos.Count() > 1)
                    {
                        randomizarImagenes();
                        nivel = 0;
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }
                    else if (nivel == 5 && pictos.Count() == 1)
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

                        j2N2 j2 = new j2N2();
                        j2.Show();
                        this.Hide();
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }

                }
                else
                {
                    MessageBox.Show("incorrecto, volve a intentarlo");
                }
            }
            else
            {
                MessageBox.Show("Ya matcheaste esta emocion");
            }

        }

        private void pB4d_Click(object sender, EventArgs e)
        {
            if (pb4 == false)
            {
                if (pB4d.Image.Tag.ToString() == aux)
                {
                    MessageBox.Show("Correcto");
                    nivel ++;
                    variablescomp.puntos++;
                    aux = "x";
                    pb4 = true;
                    if (nivel == 5 && pictos.Count() > 1)
                    {
                        randomizarImagenes();
                        nivel = 0;
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }
                    else if (nivel == 5 && pictos.Count() == 1)
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
                        j2N2 j2 = new j2N2();
                        j2.Show();
                        this.Hide();
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }

                }
                else
                {
                    MessageBox.Show("incorrecto, volve a intentarlo");
                }
            }
            else
            {
                MessageBox.Show("Ya matcheaste esta emocion");
            }

        }

        private void pB5d_Click(object sender, EventArgs e)
        {
            if (pb5 == false)
            {
                if (pB5d.Image.Tag.ToString() == aux)
                {
                    MessageBox.Show("Correcto");
                    nivel++;
                    variablescomp.puntos++;
                    aux = "x";
                    pb5 = true;
                    if (nivel == 5 && pictos.Count() > 1)
                    {
                        randomizarImagenes();
                        nivel = 0;
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }
                    else if (nivel == 5 && pictos.Count() == 1)
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

                        j2N2 j2 = new j2N2();
                        j2.Show();
                        this.Hide();
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }

                }
                else
                {
                    MessageBox.Show("incorrecto, volve a intentarlo");
                }
            }
            else
            {
                MessageBox.Show("Ya matcheaste esta emocion");
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuJuego2 m2 = new MenuJuego2();
            this.Hide();
            m2.Show();
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
