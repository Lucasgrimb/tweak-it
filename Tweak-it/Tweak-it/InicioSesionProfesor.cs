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
    public partial class InicioSesionProfesor : Form
    {

        OleDbConnection connection = new OleDbConnection();
        string Rol2;

        public InicioSesionProfesor()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
        }

        private void InicioSesionProfesor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                OleDbCommand query = new OleDbCommand("SELECT Nombre, Apellido, Id, Rol FROM info WHERE Nombre= '" + txtUser.Text + "' AND Apellido= '" + txtPassword.Text + "'", connection);
                string dato = Convert.ToString(query);

                OleDbDataReader Reader = query.ExecuteReader();

                int i = 0;


                while (Reader.Read())
                {
                    Rol2 = Reader.GetString(3);
                    i++;
                    if (Rol2 == "Estudiante")
                    {
                        MessageBox.Show("Este usuario no tiene el permiso para ingresar");
                    }
                    else if (Rol2 == "Admin")
                    {
                        MessageBox.Show("Has ingresado correctamente");
                        MenuTutor mn = new MenuTutor();
                        this.Hide();
                        mn.Show();
                    }
                }
                connection.Close();
            }
        }
    }
}
