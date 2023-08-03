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
    public partial class MenuPROFE : Form
    {
        public MenuPROFE()
        {
            InitializeComponent();
        }

# private void pictureBox1_Click(object sender, EventArgs e)
#       {
# Progreso prg = new Progreso();
# this.Hide();
# prg.Show();
# }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuCrearUsuarios mcu = new MenuCrearUsuarios();
            this.Hide();
            mcu.Show();
        }
    }
}
