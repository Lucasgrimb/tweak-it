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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CrearProfesor cp = new CrearProfesor();
            this.Hide();
            cp.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CrearAlumno ca = new CrearAlumno();
            this.Hide();
            ca.Show();
        }
    }
}
