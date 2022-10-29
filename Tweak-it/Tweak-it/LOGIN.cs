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

        string A = "Alegre";
        string T = "Triste";
        string E = "Enojado";

        public static int ID;
        public static DateTime TiempoInicio = DateTime.Now;
        public static String nombre;
        public static String apellido;

        public LOGIN()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.DimGray ;
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
            if (txtApellido.Text == "APELLIDO")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.DimGray;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "APELLIDO";
                txtApellido.ForeColor = Color.DimGray;
            }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAlegre_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = ("SELECT Nombre, Apellido, Id FROM info WHERE Nombre= '" + txtNombre.Text + "' AND Apellido= '" + txtApellido.Text + "'");
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataAdapter Adapter = new OleDbDataAdapter();
            Adapter.SelectCommand = command;
            OleDbDataReader Reader = command.ExecuteReader();

            int i = 0;

            while (Reader.Read())
            {
                MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                ID = Reader.GetInt32(2);
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                i++;
            }

            DateTime dt = DateTime.Now;
            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connection;
            command2.CommandText = "INSERT INTO ConsultaEmociones (Emocion, Fecha, id_user) VALUES ('" + A + "', '" + dt.ToShortDateString() + "', " + ID + ")";
            command2.ExecuteNonQuery();
            connection.Close();

            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void LOGIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN_PROFESOR lp = new LOGIN_PROFESOR();
            this.Hide();
            lp.Show();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            //connection.Open();
            //string query = ("SELECT Nombre, Apellido, Id FROM info WHERE Nombre= '" + txtNombre.Text + "' AND Apellido= '" + txtApellido.Text + "'");
            //OleDbCommand command = new OleDbCommand(query, connection);
            //OleDbDataAdapter Adapter = new OleDbDataAdapter();
            //Adapter.SelectCommand = command;
            //OleDbDataReader Reader = command.ExecuteReader();

            //int i = 0;

            //while (Reader.Read())
            //{
            //    MessageBox.Show("Bienvenido, " + Reader.GetString(0));
            //    i++;

            //    Form1 f1 = new Form1();
            //    this.Hide();
            //    f1.Show();
            //}
        }

        private void btnTriste_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = ("SELECT Nombre, Apellido, Id FROM info WHERE Nombre= '" + txtNombre.Text + "' AND Apellido= '" + txtApellido.Text + "'");
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataAdapter Adapter = new OleDbDataAdapter();
            Adapter.SelectCommand = command;
            OleDbDataReader Reader = command.ExecuteReader();

            int i = 0;

            while (Reader.Read())
            {
                MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                ID = Reader.GetInt32(2);
                i++;
            }

            DateTime dt = DateTime.Now;
            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connection;
            command2.CommandText = "INSERT INTO ConsultaEmociones (Emocion, Fecha, id_user) VALUES ('" + T + "', '" + dt.ToShortDateString() + "', " + ID + ")";
            command2.ExecuteNonQuery();
            connection.Close();

            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void btnEnojado_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = ("SELECT Nombre, Apellido, Id FROM info WHERE Nombre= '" + txtNombre.Text + "' AND Apellido= '" + txtApellido.Text + "'");
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataAdapter Adapter = new OleDbDataAdapter();
            Adapter.SelectCommand = command;
            OleDbDataReader Reader = command.ExecuteReader();

            int i = 0;

            while (Reader.Read())
            {
                MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                ID = Reader.GetInt32(2);
                i++;
            }

            DateTime dt = DateTime.Now;
            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connection;
            command2.CommandText = "INSERT INTO ConsultaEmociones (Emocion, Fecha, id_user) VALUES ('" + E + "', '" + dt.ToShortDateString() + "', " + ID + ")";
            command2.ExecuteNonQuery();
            connection.Close();

            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
