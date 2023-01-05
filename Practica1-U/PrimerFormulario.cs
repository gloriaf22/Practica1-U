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
        int estadoUpdate = 0;

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoUpdate = 1;
            lst_manager.Enabled = false;
            txb_codigo.Text = string.Empty;
            txb_descripcion.Text = string.Empty;

            //grb_manager.Visible = true;
            grb_manager.Enabled = true;
            txb_codigo.Enabled = true;

            txb_codigo.Select();

            grb_botonesPpales.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lst_manager.Enabled = true;
            //grb_manager.Visible = false;
            grb_manager.Enabled = false;
            grb_botonesPpales.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            string elemn;
            elemn = txb_codigo.Text + " || " + txb_descripcion.Text.Trim();

            if (estadoUpdate == 1)
            {
                if (elemn != " || ")
                {

                    lst_manager.Visible = true;
                    lst_manager.Items.Add(elemn);
                }
            }
            else
            {
                var posicion = lst_manager.SelectedIndex;
                lst_manager.Items.Remove(lst_manager.Items[posicion]);
                lst_manager.Items.Insert(posicion, elemn);
            }
            txb_codigo.Text = "";
            txb_descripcion.Text = "";
            txb_codigo.Select();

            grb_botonesPpales.Enabled = true;
            grb_manager.Enabled = false;
            lst_manager.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el elemento seleccionado?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lst_manager.Items.Remove(lst_manager.SelectedItem);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            estadoUpdate = 2;
            grb_manager.Enabled = true;
            txb_codigo.Enabled = false;

            grb_botonesPpales.Enabled = false;
        }

        private void lst_manager_Click(object sender, EventArgs e)
        {
            string infoManager = lst_manager.SelectedItem.ToString();
            txb_codigo.Text = infoManager.Substring(0, 5);
            txb_descripcion.Text = infoManager.Substring(9, infoManager.Length - 9);
        }

        //en list box parte 2 tenemos lo de regresar a los tx box las palabras que queramos
    }
}
