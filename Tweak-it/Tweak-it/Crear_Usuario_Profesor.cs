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
    public partial class Crear_Usuario_Profesor : Form
    {
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();

        public Crear_Usuario_Profesor()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
        }

        private void Crear_Usuario_Profesor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Completa los campos");
            }
            else
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO info (Nombre, Apellido, Rol) VALUES ('" + txtname.Text + "', '" + txtPass.Text + "', '" + "Admin" + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Su cuenta a sido guardada correctamente");
                Progreso lg = new Progreso();
                this.Hide();
                lg.Show();
                connection.Close();
            }
        }
    }
}
