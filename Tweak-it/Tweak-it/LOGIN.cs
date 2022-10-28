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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtname.Text == "NOMBRE")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.DimGray;
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = "NOMBRE";
                txtname.ForeColor = Color.DimGray;
            }
        }

        private void txtapellido_Enter(object sender, EventArgs e)
        {
            if(txtapellido.Text == "APELLIDO")
            {
                txtapellido.Text = "";
                txtapellido.ForeColor = Color.DimGray;
            }
        }

        private void txtapellido_Leave(object sender, EventArgs e)
        {
            if (txtapellido.Text == "")
            {
                txtapellido.Text = "APELLIDO";
                txtapellido.ForeColor = Color.DimGray;
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
