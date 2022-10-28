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
    public partial class Crear_Usuario_Estudiante : Form
    {
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();
        public Crear_Usuario_Estudiante()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
        }

        private void Crear_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtapellido.Text == "" || txtedad.Text == "")
            {
                MessageBox.Show("Completa los campos");
            } 
            else
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO info (Nombre, Apellido, Edad, Rol) VALUES ('" + txtname.Text + "', '" + txtapellido.Text + "', '" + txtedad.Text + "', '" + "Estudiante" + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Su cuenta a sido guardada correctamente");
                juego1 lg = new juego1();
                this.Hide();
                lg.Show();
                connection.Close();
            }
            
        }
    }
}
