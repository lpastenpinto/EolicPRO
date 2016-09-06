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
    public partial class FormHistoricosAerogeneradores : Form
    {
        public FormHistoricosAerogeneradores()
        {
            InitializeComponent();
            agregarTodo();
        }

        private void agregarTodo()
        {
            for (int i = 1; i <= 44; i++) { 
               

                double energia = Convert.ToDouble(this.historicosTableAdapter.ContarEnergiaProducida(i));
                int horastrabajadas = Convert.ToInt16(this.historicosTableAdapter.ContarHorasTrabajadas(i));
                dataGridViewHistoricosAeros.Rows.Add("Aerogenerador "+i, Math.Round(energia,2), horastrabajadas*3);
       
            
            }

            
        }

        private void FormHistoricosAerogeneradores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vientosDataSet.Historicos' Puede moverla o quitarla según sea necesario.
            this.historicosTableAdapter.Fill(this.vientosDataSet.Historicos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int ColumnIndex = 0;
            foreach (DataGridViewColumn col in dataGridViewHistoricosAeros.Columns)
            {
                ColumnIndex++;
                excel.Cells[1, ColumnIndex] = col.Name;
            }
            int rowIndex = 0;
            foreach (DataGridViewRow row in dataGridViewHistoricosAeros.Rows)
            {
                rowIndex++;
                ColumnIndex = 0;
                foreach (DataGridViewColumn col in dataGridViewHistoricosAeros.Columns)
                {
                    ColumnIndex++;
                    excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;

                }

            }
            excel.Visible = true;
            Worksheet worksheet = (Worksheet)excel.ActiveSheet;
            worksheet.Activate();
        }
    }
}
