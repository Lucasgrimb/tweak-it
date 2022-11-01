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
    public partial class MenuJuego3 : Form
    {
        public MenuJuego3()
        {
            InitializeComponent();
        }

        private void pictogramas_Click(object sender, EventArgs e)
        {
            juego3n1 j31 = new juego3n1();
            this.Hide();
            j31.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
