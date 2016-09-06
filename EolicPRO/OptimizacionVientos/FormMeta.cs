using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OptimizacionVientos
{
    public partial class FormMeta : Form
    {

        double metaantigua = 0;
        public FormMeta()
        {
            InitializeComponent();
            double meta_anual = Convert.ToInt16(this.meta_AnualTableAdapter.TraerMetaAnual());
            metaantigua = meta_anual;
            textBoxMeta.Text = Convert.ToString(meta_anual);
        }

        private void FormMeta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vientosDataSet.Meta_Anual' Puede moverla o quitarla según sea necesario.
            this.meta_AnualTableAdapter.Fill(this.vientosDataSet.Meta_Anual);

        }


        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Realmente desea modificar la Meta Anual", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {

                this.meta_AnualTableAdapter.ActualizarMeta(Convert.ToDouble(textBoxMeta.Text), metaantigua);
                MessageBox.Show("Se Actualizo la Meta");
                this.Close();
                
            }
            else
            {

                MessageBox.Show("NO se guardaron Cambios", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void textBoxMeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else { e.Handled = true; } 
        }
    }
}
