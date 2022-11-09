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
    public partial class CrearEstudiante : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public CrearEstudiante()
        {
            InitializeComponent();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if(txtApellido.Text == "APELLIDO")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if(txtApellido.Text == "")
            {
                txtApellido.Text = "APELLIDO";
            }
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            if(txtEdad.Text == "EDAD")
            {
                txtEdad.Text = "";
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if(txtEdad.Text == "")
            {
                txtEdad.Text = "EDAD";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Profesor mp = new Menu_Profesor();
            this.Hide();
            mp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "NOMBRE" || txtApellido.Text == "APELLIDO" || txtEdad.Text == "EDAD")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO info (Nombre, Apellido, Edad, Rol) VALUES ('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtEdad.Text + "', '" + "Estudiante" + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("El usuario del alumno ha sido creado correctamente, ahora inicie sesión para empezar a jugar");
                connection.Close();

                LOGIN lg = new LOGIN();
                this.Hide();
                lg.Show();
            }
        }

        private void CrearEstudiante_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\BDD Tweak-It.accdb;Persist Security Info=False";
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
