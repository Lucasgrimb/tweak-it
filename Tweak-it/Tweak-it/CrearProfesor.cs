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

        string A2 = "Admin";

        public CrearProfesor()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\user\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb; Persist Security Info = False";
        }

        private void txtUsuarioCrearPROF_Enter(object sender, EventArgs e)
        {
            if(txtUsuarioCrearPROF.Text == "USUARIO")
            {
                txtUsuarioCrearPROF.Text = "";
                txtUsuarioCrearPROF.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuarioCrearPROF_Leave(object sender, EventArgs e)
        {
            if(txtUsuarioCrearPROF.Text == "")
            {
                txtUsuarioCrearPROF.Text = "USUARIO";
                txtUsuarioCrearPROF.ForeColor = Color.DimGray;
            }
        }

        private void txtPassCrearPROF_Enter(object sender, EventArgs e)
        {
            if(txtPassCrearPROF.Text == "CONTRASEÑA")
            {
                txtPassCrearPROF.Text = "";
                txtPassCrearPROF.ForeColor = Color.DimGray;
            }
        }

        private void txtPassCrearPROF_Leave(object sender, EventArgs e)
        {
            if(txtPassCrearPROF.Text == "")
            {
                txtPassCrearPROF.Text = "CONTRASEÑA";
                txtPassCrearPROF.ForeColor = Color.DimGray;
            }
        }

        private void btnCrearProfesor_Click(object sender, EventArgs e)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "INSERT INTO info (Nombre, Apellido, Rol) VALUES ('"+txtUsuarioCrearPROF.Text+"', '"+txtPassCrearPROF.Text+"','"+A2+"')";
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Su cuenta a sido creada correctamente, ahora inicie sesión");

            LOGIN_PROFESOR lp = new LOGIN_PROFESOR();
            this.Hide();
            lp.Show();
        }
    }
}
