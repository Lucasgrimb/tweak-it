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
    public partial class juego1 : Form
    {
        public juego1()
        {
            InitializeComponent();
        }

        private void pictogramas_Click(object sender, EventArgs e)
        {
            j1pictosN1 j1p = new j1pictosN1();
            j1p.Show();
            this.Hide();
        }

        private void juego1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void dibujos_Click(object sender, EventArgs e)
        {
            j1dibujosN1 j1d = new j1dibujosN1();
            j1d.Show();
            this.Hide();
        }
    }
}
