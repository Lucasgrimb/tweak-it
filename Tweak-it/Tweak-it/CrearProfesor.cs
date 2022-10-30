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
    public partial class CrearProfesor : Form
    {
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();
        public CrearProfesor()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb;Persist Security Info=False";
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if(txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO info (Nombre, Apellido, Rol) VALUES ('" + txtUser.Text + "', '" + txtPass.Text + "', '" + "Admin" + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("La cuenta del Profesor ha sido creada correctamente, ahora inicie sesión");
                Menu_Profesor mp = new Menu_Profesor();
                this.Hide();
                mp.Show();
            }
        }
    }
}
