using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace OptimizacionVientos
{
    public partial class FormHistoricosVientos : Form
    {
        public FormHistoricosVientos()
        {
            InitializeComponent();
        }

        private void FormHistoricosVientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vientosDataSet.Historicos_clima' Puede moverla o quitarla según sea necesario.
            this.historicos_climaTableAdapter.Fill(this.vientosDataSet.Historicos_clima);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaIngresada = Calendar1.SelectionRange.Start;
            string fecha = fechaIngresada.ToString("dd/MM/yyyy");

            int versihay = Convert.ToInt16(this.historicos_climaTableAdapter.VerSiHayVientos(fecha));

            if (versihay != 0)
            {
                this.historicos_climaTableAdapter.FillBy(vientosDataSet.Historicos_clima, fecha);
            }
            else {
                MessageBox.Show("No hay datos para el día seleccionado","Sin Datos Viento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Exportar a Excel el DataGridView de los Historicos de los Vientos.
        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int ColumnIndex = 0;
            foreach (DataGridViewColumn col in dataGridViewHistoricosVientos.Columns)
            {
                ColumnIndex++;
                excel.Cells[1, ColumnIndex] = col.Name;
            }
            int rowIndex = 0;
            foreach (DataGridViewRow row in dataGridViewHistoricosVientos.Rows)
            {
                rowIndex++;
                ColumnIndex = 0;
                foreach (DataGridViewColumn col in dataGridViewHistoricosVientos.Columns)
                {
                    ColumnIndex++;
                   excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;

                }

            }
            excel.Visible = true;
            Worksheet worksheet = (Worksheet)excel.ActiveSheet;
            worksheet.Activate();
        }


        private void MostrarTodoHistorico_Click(object sender, EventArgs e)
        {
            this.historicos_climaTableAdapter.Fill(this.vientosDataSet.Historicos_clima);
        }
    }
}
