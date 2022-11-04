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
    public partial class LOGIN : Form
    {
        OleDbConnection connection;
        OleDbCommand command;

        public static String name;
        public static String lastname;

        public static int ID;

        public static DateTime TiempoInicio = DateTime.Now;

        string C = "CONTENTO";
        string T = "TRISTE";
        string E = "ENOJADO";
        public LOGIN()
        {
            InitializeComponent();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text == "NOMBRE DEL ALUMNO")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE DEL ALUMNO";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtApellido.Text == "APELLIDO DEL ALUMNO")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if(txtApellido.Text == "")
            {
                txtApellido.Text = "APELLIDO DEL ALUMNO";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN_PROFESOR lp = new LOGIN_PROFESOR();
            this.Hide();
            lp.Show();
        }

        private void btnContento_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                OleDbCommand query = new OleDbCommand("SELECT Nombre, Apellido, ID FROM info WHERE Nombre='" + txtNombre.Text + "' AND Apellido= '" + txtApellido.Text + "'", connection);
                string dato = Convert.ToString(query);

                OleDbDataReader Reader = query.ExecuteReader();

                int i = 0;

                while (Reader.Read())
                {
                    MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                    ID = Reader.GetInt32(2);
                    name = txtNombre.Text;
                    lastname = txtApellido.Text;
                    i++;

                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.Show();
                }

                if (i == 0)
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectas");
                }
            }

            DateTime dt = DateTime.Now;
            command = new OleDbCommand("INSERT INTO ConsultaEmociones (Emocion, Fecha, id_user) VALUES ('"+C+"', '"+dt.ToShortDateString()+"', "+ID+")", connection);
            command.ExecuteNonQuery();
            connection.Close();

            
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\47700176\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb;Persist Security Info=False";
        }

        private void btnTriste_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                OleDbCommand query = new OleDbCommand("SELECT Nombre, Apellido, ID FROM info WHERE Nombre='" + txtNombre.Text + "' AND Apellido= '" + txtApellido.Text + "'", connection);
                string dato = Convert.ToString(query);

                OleDbDataReader Reader = query.ExecuteReader();

                int i = 0;

                while (Reader.Read())
                {
                    MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                    ID = Reader.GetInt32(2);
                    i++;

                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.Show();
                }

                if (i == 0)
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectas");
                }
            }

            DateTime dt = DateTime.Now;
            command = new OleDbCommand("INSERT INTO ConsultaEmociones (Emocion, Fecha, id_user) VALUES ('" + T + "', '" + dt.ToShortDateString() + "', " + ID + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void btnEnojado_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                OleDbCommand query = new OleDbCommand("SELECT Nombre, Apellido, ID FROM info WHERE Nombre='" + txtNombre.Text + "' AND Apellido= '" + txtApellido.Text + "'", connection);
                string dato = Convert.ToString(query);

                OleDbDataReader Reader = query.ExecuteReader();

                int i = 0;

                while (Reader.Read())
                {
                    MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                    ID = Reader.GetInt32(2);
                    i++;

                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.Show();
                }

                if (i == 0)
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectas");
                }
            }

            DateTime dt = DateTime.Now;
            command = new OleDbCommand("INSERT INTO ConsultaEmociones (Emocion, Fecha, id_user) VALUES ('" + E + "', '" + dt.ToShortDateString() + "', " + ID + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
