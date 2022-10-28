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
    public partial class LOGIN_PROFESOR : Form
    {
        public LOGIN_PROFESOR()
        {
            InitializeComponent();
        }

        private void txtnombrePROF_Enter(object sender, EventArgs e)
        {
            if (txtnombrePROF.Text == "NOMBRE")
            {
                txtnombrePROF.Text = "";
                txtnombrePROF.ForeColor = Color.DimGray;
            }
        }

        private void txtnombrePROF_Leave(object sender, EventArgs e)
        {
            if (txtnombrePROF.Text == "")
            {
                txtnombrePROF.Text = "NOMBRE";
                txtnombrePROF.ForeColor = Color.DimGray;
            }
        }

        private void txtpassPROF_Enter(object sender, EventArgs e)
        {
            if (txtnombrePROF.Text == "CONTRASEÑA")
            {
                txtnombrePROF.Text = "";
                txtnombrePROF.ForeColor = Color.DimGray;
            }
        }

        private void txtpassPROF_Leave(object sender, EventArgs e)
        {
            if (txtnombrePROF.Text == "")
            {
                txtnombrePROF.Text = "CONTRASEÑA";
                txtnombrePROF.ForeColor = Color.DimGray;
            }
        }
    }
}
