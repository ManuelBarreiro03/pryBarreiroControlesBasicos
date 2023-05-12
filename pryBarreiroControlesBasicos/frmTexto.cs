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
            if (optHeladera.Checked)
            {
                lstLugar.Items.Add("Coca");
                lstLugar.Items.Add("Coca");
                lstLugar.Items.Add("Coca");
            }
            else
            {
                if (optFreezer.Checked)
                {
                    lstLugar.Items.Add("Hielo");
                    lstLugar.Items.Add("Hielo");
                    lstLugar.Items.Add("Hielo");
                }
                else 
                {
                    lstLugar.Items.Add("Fideos");
                    lstLugar.Items.Add("Fideos");
                    lstLugar.Items.Add("Fideos");
                }

            }
        }

       
    }
}
