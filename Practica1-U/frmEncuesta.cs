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
    public partial class frmEncuesta : Form
    {
        public frmEncuesta()
        {
            InitializeComponent();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            string resultado = "";

            if (chk_perro.Checked == true)
                resultado += chk_perro.Text + Environment.NewLine;
            if (chk_canguro.Checked == true)
                resultado += chk_canguro.Text + Environment.NewLine;
            if (chk_pez.Checked == true)
                resultado += chk_pez.Text + Environment.NewLine;
            if (chk_paloma.Checked == true)
                resultado += chk_paloma.Text + Environment.NewLine;

            txb_mostrar.Text = resultado;
        }
    }
}
