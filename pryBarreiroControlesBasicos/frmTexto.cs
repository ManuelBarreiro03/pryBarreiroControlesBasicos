using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarreiroControlesBasicos
{
    public partial class frmTexto : Form
    {
        public frmTexto()
        {
            InitializeComponent();
            
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            lblCopia.Text = txtTexto.Text;
        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            if (optRojo.Checked == true) 
            {
                lblCopia.ForeColor = Color.Red;
                txtTexto.ForeColor = Color.Red;
            }
            if (optAzul.Checked == true)
            {
                lblCopia.ForeColor = Color.Blue;
                txtTexto.ForeColor = Color.Blue;
            }
            
        }

        private void cmdAsignarAdicional_Click(object sender, EventArgs e)
        {
            String Texto = "";
            if (chkPicante.Checked == true)
            {
                lblAdons.Text = Texto;
                Texto = Texto + "Picante ";
            }
            if (chkMayonesa.Checked == true)
            {
                lblAdons.Text = Texto;
                Texto = Texto + "mayonesa ";
            }
            if (chkKetchup.Checked == true)
            {
                lblAdons.Text = Texto;
                Texto = Texto + "Ketchup ";
            }
            lblAdons.Text = Texto;
            cboAdcional.Items.Add(Texto);
        }
    }
}
