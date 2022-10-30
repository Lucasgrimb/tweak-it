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
        OleDbCommand command = new OleDbCommand();
        public CrearEstudiante()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb;Persist Security Info=False";
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "APELLIDO")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(txtApellido.Text == "")
            {
                txtApellido.Text = "APELLIDO";
                txtApellido.ForeColor = Color.DimGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(txtEdad.Text == "EDAD")
            {
                txtEdad.Text = "";
                txtEdad.ForeColor = Color.DimGray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(txtEdad.Text == "")
            {
                txtEdad.Text = "EDAD";
                txtEdad.ForeColor = Color.DimGray;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "" || txtApellido.Text == "" || txtEdad.Text == "")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO info (Nombre, Apellido, Edad, Rol) VALUES ('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtEdad + "', '" + "Estudiante" + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("La cuenta del Alumno ha sido creada correctamente, ahora inicie sesión");
                LOGIN lg = new LOGIN();
                this.Hide();
                lg.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
