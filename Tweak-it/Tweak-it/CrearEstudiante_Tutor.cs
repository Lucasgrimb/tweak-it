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
    public partial class CrearEstudiante_Tutor : Form
    {
        public CrearEstudiante_Tutor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crear_Usuario_Estudiante cue = new Crear_Usuario_Estudiante();
            this.Hide();
            cue.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Crear_Usuario_Profesor cup = new Crear_Usuario_Profesor();
            this.Hide();
            cup.Show();
        }

        private void CrearEstudiante_Tutor_Load(object sender, EventArgs e)
        {

        }
    }
}
