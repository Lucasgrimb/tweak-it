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
    public partial class MenuJuego2 : Form
    {
        public MenuJuego2()
        {
            InitializeComponent();
        }

        private void pictogramas_Click(object sender, EventArgs e)
        {
            j2N1 j21 = new j2N1();
            this.Hide();
            j21.Show();
        }

        private void fotos_Click(object sender, EventArgs e)
        {
            j2N2 j22 = new j2N2();
            this.Hide();
            j22.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuJuego2_Load(object sender, EventArgs e)
        {

        }
    }
}
