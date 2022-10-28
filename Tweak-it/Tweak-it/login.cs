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
    public partial class login : Form
    {
        public static int ID;

        OleDbConnection connection;

        public static String name;
        public static String Password;
        public static String Rol;
        public static DateTime TiempoInicio = DateTime.Now;

        string A = "Alegre";
        string T = "Triste";
        string E = "Enojado";

        public login()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {
            j1fotosN1 jn1 = new j1fotosN1();
            jn1.Show();
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Crear_Usuario_Estudiante cr = new Crear_Usuario_Estudiante();
            this.Hide();
            cr.Show();
        }

        private void btnAlegre_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txtapellido.Text == "")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                OleDbCommand query = new OleDbCommand("SELECT Nombre, Apellido, Id, Rol FROM info WHERE Nombre='" + txtnombre.Text + "' AND Apellido='" + txtapellido.Text + "'", connection);
                string dato = Convert.ToString(query);

                OleDbDataReader Reader = query.ExecuteReader();

                int i = 0;

                while (Reader.Read())
                {
                    MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                    ID = Reader.GetInt32(2);
                    Rol = Reader.GetString(3);
                    i++;

                    if (Rol == "Estudiante")
                    {
                        Form1 f1 = new Form1();
                        this.Hide();
                        f1.Show();
                    }

                    Name = txtnombre.Text;
                    Password = txtapellido.Text;
                }
                connection.Close();
            }

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command = new OleDbCommand("INSERT INTO ConsultaEmociones (Emocion, Fecha, id_user) VALUES ('" + A + "', '" + TiempoInicio.ToShortDateString() + "', " + ID + ")",connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void btnTriste_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txtapellido.Text == "")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                OleDbCommand query = new OleDbCommand("SELECT Nombre, Apellido, Id, Rol FROM info WHERE Nombre='" + txtnombre.Text + "' AND Apellido= '" + txtapellido.Text + "'", connection);
                string dato = Convert.ToString(query);

                OleDbDataReader Reader = query.ExecuteReader();

                int i = 0;

                while (Reader.Read())
                {
                    MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                    ID = Reader.GetInt32(2);
                    Rol = Reader.GetString(3);
                    i++;

                    if (Rol == "Estudiante")
                    {
                        Form1 f1 = new Form1();
                        this.Hide();
                        f1.Show();
                    }

                    Name = txtnombre.Text;
                    Password = txtapellido.Text;
                }
                connection.Close();
            }

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command = new OleDbCommand("INSERT INTO ConsultaEmociones (Emocion, Fecha, id_user) VALUES ('" + T + "', '" + TiempoInicio.ToShortDateString() + "', " + ID + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void btnEnojado_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txtapellido.Text == "")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                OleDbCommand query = new OleDbCommand("SELECT Nombre, Apellido, Id, Rol FROM info WHERE Nombre='" + txtnombre.Text + "' AND Apellido='" + txtapellido.Text + "'", connection);
                string dato = Convert.ToString(query);

                OleDbDataReader Reader = query.ExecuteReader();

                int i = 0;

                while (Reader.Read())
                {
                    MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                    ID = Reader.GetInt32(2);
                    Rol = Reader.GetString(3);
                    i++;

                    if (Rol == "Estudiante")
                    {
                        Form1 f1 = new Form1();
                        this.Hide();
                        f1.Show();
                    }

                    Name = txtnombre.Text;
                    Password = txtapellido.Text;
                }
                connection.Close();
            }

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command = new OleDbCommand("INSERT INTO ConsultaEmociones (Emocion, Fecha, id_user) VALUES ('" + E + "', '" + TiempoInicio.ToShortDateString() + "', " + ID + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesionProfesor isp = new InicioSesionProfesor();
            this.Hide();
            isp.Show();
        }
    }
}
