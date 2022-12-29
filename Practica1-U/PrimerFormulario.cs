using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_U
{
    public partial class PrimerFormulario : Form
    {
        public PrimerFormulario()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txb_codigo.Text = string.Empty;
            txb_descripcion.Text = string.Empty;

            grb_manager.Visible = true;

            txb_codigo.Select();

            grb_botonesPpales.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            grb_manager.Visible = false;

            grb_botonesPpales.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string elemn;
            elemn = txb_codigo.Text + " || " + txb_descripcion.Text;

            if (elemn != " || ")
                lst_manager.Items.Add(elemn);

            txb_codigo.Text = "";
            txb_descripcion.Text = "";
            txb_codigo.Select();
        }
    }
}
