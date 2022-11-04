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
    public partial class Informacion_Alumnos : Form
    {
        OleDbConnection connection = new OleDbConnection();
        int ID;
        public static int tiempo;
        public static int puntos;


        public Informacion_Alumnos()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\47700176\Documents\GitHub\tweak-it\Tweak-it\BDD Tweak-It.accdb;Persist Security Info=False";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_Profesor mp = new Menu_Profesor();
            this.Hide();
            mp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string[] EmocionesRecibidas = new string[4];
            string[] FechasRecbidas = new string[4];

            connection.Open();
            OleDbCommand query = new OleDbCommand("SELECT Id FROM info WHERE Nombre= '" + txtNombre.Text + "' AND Apellido='" + txtApellido.Text + "'", connection);
            string dato = Convert.ToString(query);
            OleDbDataReader Reader = query.ExecuteReader();

            int i = 0;

            while (Reader.Read())
            {
                ID = Reader.GetInt32(0);
                i++;
            }
            connection.Close();


            connection.Open();
            OleDbCommand Emocion_Fecha = new OleDbCommand("SELECT TOP 4 Emocion, Fecha FROM ConsultaEmociones WHERE id_user=" + ID + " ORDER BY Fecha DESC", connection);
            string dato2 = Convert.ToString(Emocion_Fecha);
            OleDbDataReader Reader2 = Emocion_Fecha.ExecuteReader();

            int i2 = 0;
            while (Reader2.Read())
            {
                EmocionesRecibidas[i2] = Reader2.GetString(0);
                FechasRecbidas[i2] = Reader2.GetString(1);
                i2++;
            }
            connection.Close();


            connection.Open();
            string Puntos = "SELECT SUM (Puntos) FROM puntos WHERE id_usuario= " + ID + "";
            OleDbCommand cmd = new OleDbCommand(Puntos, connection);
            puntos = Convert.ToInt32(cmd.ExecuteScalar());

            string Tiempo = "SELECT SUM (TiempoEnPantalla) FROM tiempo WHERE id_usuario= " + ID + "";
            OleDbCommand cmd2 = new OleDbCommand(Tiempo, connection);
            tiempo = Convert.ToInt32(cmd2.ExecuteScalar());

            lblPuntos.Text = puntos +" "+ "PUNTOS TOTALES";
            lblTmpEnPntlla.Text = tiempo +" "+ "MINUTOS JUGADOS";
            lblAlegre.Text = "ESTUVO " + EmocionesRecibidas[1] + " "+ "EL " + " " + FechasRecbidas[1];
            lbl2.Text = "ESTUVO " + EmocionesRecibidas[2] + " " + "EL " + " " + FechasRecbidas[2];
            label1.Text = "ESTUVO " + EmocionesRecibidas[3] + " " + "EL " + " " + FechasRecbidas[3];
            connection.Close();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if(txtApellido.Text == "APELLIDO")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if(txtApellido.Text == "")
            {
                txtApellido.Text = "APELLIDO";
            }
        }

        private void Informacion_Alumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
