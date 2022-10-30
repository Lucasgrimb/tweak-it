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
    public partial class LOGIN_PROFESOR : Form
    {
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;

        public static String ROL;
        public LOGIN_PROFESOR()
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
            if (txtPass.Text == "CONTRASEÑA")
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

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_PROFESOR_Load(object sender, EventArgs e)
        {

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
                command = new OleDbCommand("SELECT Nombre, Apellido, Rol FROM info WHERE Nombre='" + txtUser.Text + "' AND Apellido='" + txtPass.Text + "'", connection);
                OleDbDataReader Reader = command.ExecuteReader();

                int i = 0;

                while (Reader.Read())
                {
                    ROL = Reader.GetString(2);
                    MessageBox.Show("Bienvenido, " + Reader.GetString(0));
                    i++;
                    
                    if (ROL == "Admin")
                    {
                        MessageBox.Show("Has ingresado correctamente " + Reader.GetString(0));
                    }
                    else if (ROL == "Estudiante")
                    {
                        MessageBox.Show("Este usuario no tiene acceso a la seccion Profesor");
                    }
                    else if (i == 0)
                    {
                        MessageBox.Show("Usuario incorrecto o contraseña incorrecta");
                    }
                }
                connection.Close();

            }
                    
        }
    }
}
