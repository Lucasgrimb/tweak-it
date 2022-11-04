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
    public partial class j2N2 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();

        int puntos;

        PictureBox[] pBpictos = new PictureBox[5];
        PictureBox[] pBdibujos = new PictureBox[5];
        PictureBox[] pBfotos = new PictureBox[5];
        List<Image> pictos = new List<Image>();
        List<Image> dibujos = new List<Image>();
        List<Image> fotos = new List<Image>();
        List<Image> ndibujos = new List<Image>();
        List<Image> nfotos = new List<Image>();
        string aux;
        string aux2;
        int nivel = 0;
        bool pb1 = false;
        bool pb2 = false;
        bool pb3 = false;
        bool pb4 = false;
        bool pb5 = false;

        Random rand = new Random();
        public j2N2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\BDD Tweak-It.accdb;Persist Security Info=False";
        }
        private void j2N2_Load(object sender, EventArgs e)
        {
            //agrego Pb al arrray
            pBpictos[0] = pb1p;
            pBpictos[1] = pb2p;
            pBpictos[2] = pictureBox1;
            pBpictos[3] = pb4p;
            pBpictos[4] = pb5p;

            pBdibujos[0] = pb1d;
            pBdibujos[1] = pb2d;
            pBdibujos[2] = pb3d;
            pBdibujos[3] = pb4d;
            pBdibujos[4] = pb5d;

            pBfotos[0] = pb1f;
            pBfotos[1] = pb2f;
            pBfotos[2] = pb3f;
            pBfotos[3] = pb4f;
            pBfotos[4] = pb5f;

            // pongo las imagenes en un formato especial para que se vean centradas
            for (int x = 0; x < pBpictos.Length; x++)
            {
                pBpictos[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            for (int x = 0; x < pBdibujos.Length; x++)
            {
                pBdibujos[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            for (int x = 0; x < pBfotos.Length; x++)
            {
                pBfotos[x].SizeMode = PictureBoxSizeMode.StretchImage;
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
            pictos.Add(Tweak_it.Properties.Resources.Verguenza);
            pictos.Add(Tweak_it.Properties.Resources.Nervioso);
            pictos.Add(Tweak_it.Properties.Resources.Confundido);

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
            dibujos.Add(Tweak_it.Properties.Resources.VerguenzaD);
            dibujos.Add(Tweak_it.Properties.Resources.NerviosoD);
            dibujos.Add(Tweak_it.Properties.Resources.ConfundidoD);

            fotos.Add(Tweak_it.Properties.Resources.ContentoF);
            fotos.Add(Tweak_it.Properties.Resources.TristeF);
            fotos.Add(Tweak_it.Properties.Resources.EnojadoF);
            fotos.Add(Tweak_it.Properties.Resources.AsustadoF);
            fotos.Add(Tweak_it.Properties.Resources.SorprendidoF);
            fotos.Add(Tweak_it.Properties.Resources.CansadoF);
            fotos.Add(Tweak_it.Properties.Resources.HambrientoF);
            fotos.Add(Tweak_it.Properties.Resources.SedientoF);
            fotos.Add(Tweak_it.Properties.Resources.EnfermoF);
            fotos.Add(Tweak_it.Properties.Resources.AburridoF);
            fotos.Add(Tweak_it.Properties.Resources.PreocupadoF);
            fotos.Add(Tweak_it.Properties.Resources.VerguenzaF);
            fotos.Add(Tweak_it.Properties.Resources.NerviosoF);
            fotos.Add(Tweak_it.Properties.Resources.ConfundidoF);


            //Asigno tag para cada emocion
            pictos[0].Tag = "contento";
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
            pictos[11].Tag = "verguenza";
            pictos[12].Tag = "nervioso";
            pictos[13].Tag = "confundido";

            dibujos[0].Tag = "contento";
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
            dibujos[11].Tag = "verguenza";
            dibujos[12].Tag = "nervioso";
            dibujos[13].Tag = "confundido";

            fotos[0].Tag = "contento";
            fotos[1].Tag = "triste";
            fotos[2].Tag = "enfadado";
            fotos[3].Tag = "asustado";
            fotos[4].Tag = "sorprendido";
            fotos[5].Tag = "cansado";
            fotos[6].Tag = "hambriento";
            fotos[7].Tag = "sediento";
            fotos[8].Tag = "enfermo";
            fotos[9].Tag = "aburrido";
            fotos[10].Tag = "preocupado";
            fotos[11].Tag = "verguenza";
            fotos[12].Tag = "nervioso";
            fotos[13].Tag = "confundido";

            randomizarImagenes();

        }

        private void randomizarImagenes()
        {
            //asigno emociones a pBpictos
            for (int i = 0; i < 5; i++)
            {
                int x = rand.Next(0, pictos.Count);

                pBpictos[i].Image = pictos[x];                
                ndibujos.Add(dibujos[x]);
                nfotos.Add(fotos[x]);
                pictos.RemoveAt(x);
                dibujos.RemoveAt(x);
                fotos.RemoveAt(x);
            }
            for (int j = 0; j < 5; j++)
            {
                int f = rand.Next(0, ndibujos.Count);
                pBdibujos[j].Image = ndibujos[f];
                ndibujos.RemoveAt(f);
            }
            for (int j = 0; j < 5; j++)
            {
                int f = rand.Next(0, nfotos.Count);
                pBfotos[j].Image = nfotos[f];
                nfotos.RemoveAt(f);
            }
        }

        private void click1 (object sender, EventArgs e)
        {
            var x = sender as PictureBox;
            aux = x.Image.Tag.ToString();
        }

        private void click2(object sender, EventArgs e)
        {
            var x = sender as PictureBox;
            aux2 = x.Image.Tag.ToString();
        }

       


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pb2p_Click(object sender, EventArgs e)
        {

        }

        private void pb3p_Click(object sender, EventArgs e)
        {

        }

        private void pb4p_Click(object sender, EventArgs e)
        {

        }

        private void pb5p_Click(object sender, EventArgs e)
        {

        }

        private void pb1d_Click(object sender, EventArgs e)
        {

        }

        private void pb2d_Click(object sender, EventArgs e)
        {

        }

        private void pb3d_Click(object sender, EventArgs e)
        {

        }

        private void pb4d_Click(object sender, EventArgs e)
        {

        }

        private void pb5b_Click(object sender, EventArgs e)
        {

        }

        private void pb1f_Click(object sender, EventArgs e)
        {
            if (pb1 == false){

                if (pb1f.Image.Tag.ToString() == aux && pb1f.Image.Tag.ToString() == aux2){
                    MessageBox.Show("Correcto");
                    nivel++;
                    variablescomp.puntos++;
                    aux = "x";
                    aux2 = "x";
                    pb1 = true;

                    if (nivel == 5 && pictos.Count() > 4){
                        randomizarImagenes();
                        nivel = 0;
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false; }

                    else if (nivel == 5 && pictos.Count() == 4){
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

                        MessageBox.Show("Felicitaciones completaste el juego");
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide(); }
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

        private void pb2f_Click(object sender, EventArgs e)
        {
            if (pb2 == false)
            {
                if (pb2f.Image.Tag.ToString() == aux && pb2f.Image.Tag.ToString() == aux2)
                {
                    MessageBox.Show("Correcto");
                    nivel++;
                    variablescomp.puntos++;
                    aux = "x";
                    aux2 = "x";
                    pb2 = true;
                    if (nivel == 5 && pictos.Count() > 4)
                    {
                        randomizarImagenes();
                        nivel = 0;
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }
                    else if (nivel == 5 && pictos.Count() == 4)
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

                        MessageBox.Show("Felicitaciones completaste el juego");
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();
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

        private void pb3f_Click(object sender, EventArgs e)
        {
            if (pb3 == false)
            {
                if (pb3f.Image.Tag.ToString() == aux && pb3f.Image.Tag.ToString() == aux2)
                {
                    MessageBox.Show("Correcto");
                    nivel++;
                    variablescomp.puntos++;
                    aux = "x";
                    aux2 = "x";
                    pb3 = true;
                    if (nivel == 5 && pictos.Count() > 4)
                    {
                        randomizarImagenes();
                        nivel = 0;
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }
                    else if (nivel == 5 && pictos.Count() == 4)
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

                        MessageBox.Show("Felicitaciones completaste el juego");
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();

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

        private void pb4f_Click(object sender, EventArgs e)
        {
            if (pb4 == false)
            {
                if (pb4f.Image.Tag.ToString() == aux && pb4f.Image.Tag.ToString() == aux2)
                {
                    MessageBox.Show("Correcto");
                    nivel++;
                    variablescomp.puntos++;
                    aux = "x";
                    aux2 = "x";
                    pb4 = true;
                    if (nivel == 5 && pictos.Count() > 4)
                    {
                        randomizarImagenes();
                        nivel = 0;
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }
                    else if (nivel == 5 && pictos.Count() == 4)
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

                        MessageBox.Show("Felicitaciones completaste el juego");
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();

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

        private void pb5f_Click(object sender, EventArgs e)
        {
            if (pb5 == false)
            {
                if (pb5f.Image.Tag.ToString() == aux && pb5f.Image.Tag.ToString() == aux2)
                {
                    MessageBox.Show("Correcto");
                    nivel++;
                    variablescomp.puntos++;
                    aux = "x";
                    aux2 = "x";
                    pb5 = true;
                    if (nivel == 5 && pictos.Count() > 4)
                    {
                        randomizarImagenes();
                        nivel = 0;
                        pb1 = false;
                        pb2 = false;
                        pb3 = false;
                        pb4 = false;
                        pb5 = false;
                    }
                    else if (nivel == 5 && pictos.Count() == 4)
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

                        MessageBox.Show("Felicitaciones completaste el juego");
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuJuego2 mj2 = new MenuJuego2();
            this.Hide();
            mj2.Show();
        }
    }
}
