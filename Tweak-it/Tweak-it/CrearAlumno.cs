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
    public partial class CrearAlumno : Form
    {
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();

        string E = "Estudiante";
        public CrearAlumno()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
        }

        private void txtUsuarioCrearAlumno_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioCrearAlumno.Text == "NOMBRE")
            {
                txtUsuarioCrearAlumno.Text = "";
                txtUsuarioCrearAlumno.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuarioCrearAlumno_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioCrearAlumno.Text == "")
            {
                txtUsuarioCrearAlumno.Text = "NOMBRE";
                txtUsuarioCrearAlumno.ForeColor = Color.DimGray;
            }
        }

        private void txtPassCrearAlumno_Enter(object sender, EventArgs e)
        {
            if (txtPassCrearAlumno.Text == "APELLIDO")
            {
                txtUsuarioCrearAlumno.Text = "";
                txtUsuarioCrearAlumno.ForeColor = Color.DimGray;
            }
        }

        private void txtPassCrearAlumno_Leave(object sender, EventArgs e)
        {
            if (txtPassCrearAlumno.Text == "")
            {
                txtUsuarioCrearAlumno.Text = "APELLIDO";
                txtUsuarioCrearAlumno.ForeColor = Color.DimGray;
            }
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            if(txtEdad.Text == "EDAD")
            {
                txtEdad.Text = "";
                txtEdad.ForeColor = Color.DimGray;
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if(txtEdad.Text == "")
            {
                txtEdad.Text = "EDAD";
                txtEdad.ForeColor = Color.DimGray;
            }
        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "INSERT INTO info (Nombre, Apellido, Edad, Rol) VALUES ('" + txtUsuarioCrearAlumno.Text + "', '" + txtPassCrearAlumno.Text + "', '" + txtEdad.Text + "', '"+E+"')";
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("El usuario del alumno a sido creado correctamente, ahora inicie sesión");

            LOGIN lg = new LOGIN();
            this.Hide();
            lg.Show();
        }
    }
}
