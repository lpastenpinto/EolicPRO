using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OptimizacionVientos
{
    public partial class FormHistoricos : Form
    {
        public FormHistoricos()
        {
            InitializeComponent();
            
            
            webBrowserHistoricos.Navigate("localhost/Aeros/mapa.php");


        }


        private void comboBoxTramoHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime manana = DateTime.Today.AddDays(1);
            string fechamañana = manana.ToString("dd-MM-yyyy");
            DateTime fechaHoy = DateTime.Now.Date;
            DateTime fechaIngresada = dateTimePickerHistoricos.Value.Date;
            string tramo = comboBoxTramoHorario.SelectedItem.ToString();
            string fecha = fechaIngresada.ToString("dd/MM/yyyy");
            labelFecha.Text = "";
            int verPanificacion = Convert.ToInt16(this.historicosTableAdapter.Versihayplanificacion(fecha));
                          
            if (verPanificacion != 0)
            {
                labelFecha.Text = fecha;
                labelTramo.Text = tramo;
                this.historicosTableAdapter.FillBy(vientosDataSet.Historicos, fecha, tramo);
                double energiaTotal = Convert.ToDouble(this.historicosTableAdapter.EnergiaTotal(fecha, tramo));
                if (energiaTotal == 0) { MessageBox.Show("No hay planificación para ese tramo en particular","Sin planificación",MessageBoxButtons.OK,MessageBoxIcon.Information); }
                labelEnergiaTotal.Text = ""+energiaTotal+"[MW]";
                double energiaTotalDia = Convert.ToDouble(this.historicosTableAdapter.EnergiaTotalDia(fecha));
                labelEnergiaTotalDia.Text = ""+energiaTotalDia+"[MW]";
                string ruta = GenerarRuta();
                //MessageBox.Show(""+ruta);
                webBrowserHistoricos.Navigate(ruta);
         
            }

            else
            {

                MessageBox.Show("No existe planificación de ese día", "Sin Planificación", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private string GenerarRuta()
        {
            string ruta = "localhost/Aeros/mapaHistorico.php?";
            for (int fila = 0; fila < dataGridViewHistorico.RowCount; fila++)
            {
                    string aero = dataGridViewHistorico.Rows[fila].Cells[0].Value.ToString();
                    ruta = ruta+aero+"&";
            }
            return ruta;
        }

        
        
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRosaVientos rosa = new FormRosaVientos();
            rosa.Show();
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHistoricosVientos historicos = new FormHistoricosVientos();
            historicos.ShowDialog();

        }

      

      
    }
}
