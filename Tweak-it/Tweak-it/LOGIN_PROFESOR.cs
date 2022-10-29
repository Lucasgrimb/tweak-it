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
        OleDbCommand command = new OleDbCommand();

        public static string ROL;
        public static String nombre;
        public LOGIN_PROFESOR()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
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

        private void btnLOGIN_PROF_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = ("SELECT Nombre, Apellido, Rol FROM info WHERE Nombre= '"+txtUser.Text + "' AND Apellido= '" + txtPass.Text + "'");
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataAdapter Adapter = new OleDbDataAdapter();
            Adapter.SelectCommand = command;
            OleDbDataReader Reader = command.ExecuteReader();

            int i = 0;

            while (Reader.Read())
            {
                ROL = Reader.GetString(2);
                nombre = Reader.GetString(0);
                i++;
            }
            if(ROL == "Admin")
            {
                MessageBox.Show("Has ingresado correctamente " + nombre);
                MenuPROFE pf = new MenuPROFE();
                this.Hide();
                pf.Show();
            }
            else if (ROL == "Estudiante")
            {
                MessageBox.Show("Este usuario no tiene acceso a la seccion de Profesores");
            }
        }
    }
}
