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
    public partial class j2N2 : Form
    {
        PictureBox[] pBpictos = new PictureBox[5];
        PictureBox[] pBdibujos = new PictureBox[5];
        PictureBox[] pBfotos = new PictureBox[5];
        List<Image> pictos = new List<Image>();
        List<Image> dibujos = new List<Image>();
        List<Image> fotos = new List<Image>();
        List<Image> ndibujos = new List<Image>();
        List<Image> nfotos = new List<Image>();

        Random rand = new Random();
        public j2N2()
        {
            InitializeComponent();
        }
        private void j2N2_Load(object sender, EventArgs e)
        {
            //agrego Pb al arrray
            pBpictos[0] = pb1p;
            pBpictos[1] = pb2p;
            pBpictos[2] = pb3p;
            pBpictos[3] = pb4p;
            pBpictos[4] = pb5p;

            pBdibujos[0] = pb1d;
            pBdibujos[1] = pb2d;
            pBdibujos[2] = pb3d;
            pBdibujos[3] = pb4d;
            pBdibujos[4] = pb5d;

            pBfotos[0] = pb1f;
            pBfotos[1] = pb2f;
            pBfotos[2] = pb3f;
            pBfotos[3] = pb4f;
            pBfotos[4] = pb5f;

            // pongo las imagenes en un formato especial para que se vean centradas
            for (int x = 0; x < pBpictos.Length; x++)
            {
                pBpictos[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            for (int x = 0; x < pBdibujos.Length; x++)
            {
                pBdibujos[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            for (int x = 0; x < pBfotos.Length; x++)
            {
                pBfotos[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pb2p_Click(object sender, EventArgs e)
        {

        }

        private void pb3p_Click(object sender, EventArgs e)
        {

        }

        private void pb4p_Click(object sender, EventArgs e)
        {

        }

        private void pb5p_Click(object sender, EventArgs e)
        {

        }

        private void pb1d_Click(object sender, EventArgs e)
        {

        }

        private void pb2d_Click(object sender, EventArgs e)
        {

        }

        private void pb3d_Click(object sender, EventArgs e)
        {

        }

        private void pb4d_Click(object sender, EventArgs e)
        {

        }

        private void pb5b_Click(object sender, EventArgs e)
        {

        }

        private void pb1f_Click(object sender, EventArgs e)
        {

        }

        private void pb2f_Click(object sender, EventArgs e)
        {

        }

        private void pb3f_Click(object sender, EventArgs e)
        {

        }

        private void pb4f_Click(object sender, EventArgs e)
        {

        }

        private void pb5f_Click(object sender, EventArgs e)
        {

        }
    }
}
