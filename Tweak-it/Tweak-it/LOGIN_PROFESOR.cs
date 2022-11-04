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
        OleDbConnection connection;

        string Rol;
        public LOGIN_PROFESOR()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
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

        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            this.Hide();
            lg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                OleDbCommand query = new OleDbCommand("SELECT Nombre, Apellido, Rol FROM info WHERE Nombre='" + txtUsuario.Text + "' AND Apellido='" + txtContraseña.Text + "'", connection);
                string dato = Convert.ToString(query);

                OleDbDataReader Reader = query.ExecuteReader();

                int i = 0;

                while (Reader.Read())
                {
                    Rol = Reader.GetString(2);
                    i++;

                    if(Rol == "Admin")
                    {
                        MessageBox.Show("Has ingresado correctamente, " + Reader.GetString(0));
                        Menu_Profesor mp = new Menu_Profesor();
                        this.Hide();
                        mp.Show();
                    }
                    else if(Rol == "Estudiante")
                    {
                        MessageBox.Show("Este usuario no tiene acceso a la seccion de Profesores");
                    }
                }

                if (i == 0)
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectas");
                    txtUsuario.Text = "USUARIO";
                    txtContraseña.Text = "CONTRASEÑA";
                }

                connection.Close();
            }
        }

        private void LOGIN_PROFESOR_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\47700176\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb;Persist Security Info=False";
        }
    }
}
