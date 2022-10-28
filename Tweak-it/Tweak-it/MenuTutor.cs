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
    public partial class MenuTutor : Form
    {
        public MenuTutor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearEstudiante_Tutor cru = new CrearEstudiante_Tutor();
            this.Hide();
            cru.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Progreso prg = new Progreso();
            this.Hide();
            prg.Show();
        }
    }
}
