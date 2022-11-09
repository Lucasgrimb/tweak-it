using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tweak_it
{
    public partial class MenuCrearUsuarios : Form
    {
        public MenuCrearUsuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_Profesor mp = new Menu_Profesor();
            this.Hide();
            mp.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuCrearUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CrearEstudiante cr = new CrearEstudiante();
            this.Hide();
            cr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CrearProfesor cr = new CrearProfesor();
            this.Hide();
            cr.Show();
        }
    }
}
