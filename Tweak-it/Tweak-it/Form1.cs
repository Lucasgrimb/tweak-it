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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            juego1 j1 = new juego1();
            j1.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            juego2 j2 = new juego2();
            j2.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            juego3 j3 = new juego3();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
