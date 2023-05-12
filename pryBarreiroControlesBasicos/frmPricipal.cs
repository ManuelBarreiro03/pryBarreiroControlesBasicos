using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarreiroControlesBasicos
{
    public partial class frmPricipal : Form
    {
        public frmPricipal()
        {
            InitializeComponent();
        }

        private void frmPricipal_MouseMove(object sender, MouseEventArgs e)
        {
            lblEjeX.Text = e.X.ToString();
            lblEjeY.Text = e.Y.ToString();
        }

        private void frmPricipal_MouseClick(object sender, MouseEventArgs e)
        {
            lblBienvenida.Visible = true;  
        }
        

        private void lblBienvenida_MouseEnter(object sender, EventArgs e)
        {
            lblBienvenida.Location = new Point();
        }

        private void cmdTexto_Click(object sender, EventArgs e)
        {
            frmTexto VentanaTexto = new frmTexto();
            VentanaTexto.ShowDialog();
        }

        private void frmPricipal_Load(object sender, EventArgs e)
        {

        }
    }
}
