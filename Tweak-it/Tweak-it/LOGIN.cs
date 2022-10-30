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
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;

        public static String name;
        public static String apellido;
        public static int ID;

        string c = "Contento";
        string T = "Triste";
        string E = "Enojado";
        public LOGIN()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb;Persist Security Info=False";
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text == "NOMBRE ")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray ;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "APELLIDO")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "APELLIDO";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void btnAlegre_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new OleDbCommand("SELECT Nombre, Apellido, Id FROM info WHERE Nombre='"+txtNombre.Text+"' AND Apellido='"+txtApellido.Text+"'",connection);
            OleDbDataReader Reader = command.ExecuteReader();

            int i = 0;

            while (Reader.Read())
            {
                name = txtNombre.Text;
                apellido = txtApellido.Text;
                ID = Reader.GetInt32(2);
                MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                i++;
            }

            DateTime dt = DateTime.Now;
            command.Connection = connection;
            command = new OleDbCommand("INSERT INTO ConsultaEmociones (Emocion, Fecha, id_user) VALUES ('" + c + "', '" + dt.ToShortDateString() + "', " + ID + ")");
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void btnTriste_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new OleDbCommand("SELECT Nombre, Apellido, Id FROM info WHERE Nombre='" + txtNombre.Text + "' AND Apellido='" + txtApellido.Text + "'", connection);
            OleDbDataReader Reader = command.ExecuteReader();

            int i = 0;

            while (Reader.Read())
            {
                name = txtNombre.Text;
                apellido = txtApellido.Text;
                ID = Reader.GetInt32(2);
                MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                i++;
            }

            DateTime dt = DateTime.Now;
            command.Connection = connection;
            command = new OleDbCommand("INSERT INTO ConsultaEmociones (Emocion, Fecha, id_user) VALUES ('" + T + "', '" + dt.ToShortDateString() + "', " + ID + ")");
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void btnEnojado_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new OleDbCommand("SELECT Nombre, Apellido, Id FROM info WHERE Nombre='" + txtNombre.Text + "' AND Apellido='" + txtApellido.Text + "'", connection);
            OleDbDataReader Reader = command.ExecuteReader();

            int i = 0;

            while (Reader.Read())
            {
                name = txtNombre.Text;
                apellido = txtApellido.Text;
                ID = Reader.GetInt32(2);
                MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                i++;
            }

            DateTime dt = DateTime.Now;
            command.Connection = connection;
            command = new OleDbCommand("INSERT INTO ConsultaEmociones (Emocion, Fecha, id_user) VALUES ('" + E + "', '" + dt.ToShortDateString() + "', " + ID + ")");
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LOGIN_PROFESOR lp = new LOGIN_PROFESOR();
            this.Hide();
            lp.Show();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
