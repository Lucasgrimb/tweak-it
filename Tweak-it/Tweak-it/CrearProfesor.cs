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
        OleDbConnection connection;
        public CrearProfesor()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
            }
        }

        private void CrearProfesor_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\48045008\Documents\GitHub\tweak-it\Tweak-it\Tweak-it\bin\Debug\BDD Tweak-It.accdb;Persist Security Info=False";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO" || txtContraseña.Text == "CONTRASEÑA")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO info (Nombre, Apellido, Rol) VALUES ('" + txtUsuario.Text + "', '" + txtContraseña.Text + "', '" + "Admin" + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Su usuario ha sido creado correctamente");
                connection.Close();

                Menu_Profesor mp = new Menu_Profesor();
                this.Hide();
                mp.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuCrearUsuarios mcu = new MenuCrearUsuarios();
            this.Hide();
            mcu.Show();
        }
    }
}
