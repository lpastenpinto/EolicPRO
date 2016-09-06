using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace OptimizacionVientos
{
    public partial class FormConfigurarDisponibilidad : Form
    {
        public FormConfigurarDisponibilidad()
        {
            InitializeComponent();
            cargar();
        }

        private void cargar()
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Range range;
    
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open("C:/AppServ/www/Aeros/Aerogeneradores.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;


            if (Convert.ToString(range.Cells[1, 4].Value2) == "2") { checkBoxA1.Checked = false; }
            if (Convert.ToString(range.Cells[2, 4].Value2) == "2") { checkBoxA2.Checked = false; }
            if (Convert.ToString(range.Cells[3, 4].Value2) == "2") { checkBoxA3.Checked = false; }
            if (Convert.ToString(range.Cells[4, 4].Value2) == "2") { checkBoxA4.Checked = false; }
            if (Convert.ToString(range.Cells[5, 4].Value2) == "2") { checkBoxA5.Checked = false; }
            if (Convert.ToString(range.Cells[6, 4].Value2) == "2") { checkBoxA6.Checked = false; }
            if (Convert.ToString(range.Cells[7, 4].Value2) == "2") { checkBoxA7.Checked = false; }
            if (Convert.ToString(range.Cells[8, 4].Value2) == "2") { checkBoxA8.Checked = false; }
            if (Convert.ToString(range.Cells[9, 4].Value2) == "2") { checkBoxA9.Checked = false; }
            if (Convert.ToString(range.Cells[10, 4].Value2) == "2") { checkBoxA10.Checked = false; }
            if (Convert.ToString(range.Cells[11, 4].Value2) == "2") { checkBoxA11.Checked = false; }
            if (Convert.ToString(range.Cells[12, 4].Value2) == "2") { checkBoxA12.Checked = false; }
            if (Convert.ToString(range.Cells[13, 4].Value2) == "2") { checkBoxA13.Checked = false; }
            if (Convert.ToString(range.Cells[14, 4].Value2) == "2") { checkBoxA14.Checked = false; }
            if (Convert.ToString(range.Cells[15, 4].Value2) == "2") { checkBoxA15.Checked = false; }
            if (Convert.ToString(range.Cells[16, 4].Value2) == "2") { checkBoxA16.Checked = false; }
            if (Convert.ToString(range.Cells[17, 4].Value2) == "2") { checkBoxA17.Checked = false; }
            if (Convert.ToString(range.Cells[18, 4].Value2) == "2") { checkBoxA18.Checked = false; }
            if (Convert.ToString(range.Cells[19, 4].Value2) == "2") { checkBoxA19.Checked = false; }
            if (Convert.ToString(range.Cells[20, 4].Value2) == "2") { checkBoxA20.Checked = false; }
            if (Convert.ToString(range.Cells[21, 4].Value2) == "2") { checkBoxA21.Checked = false; }
            if (Convert.ToString(range.Cells[22, 4].Value2) == "2") { checkBoxA22.Checked = false; }
            if (Convert.ToString(range.Cells[23, 4].Value2) == "2") { checkBoxA23.Checked = false; }
            if (Convert.ToString(range.Cells[24, 4].Value2) == "2") { checkBoxA24.Checked = false; }
            if (Convert.ToString(range.Cells[25, 4].Value2) == "2") { checkBoxA25.Checked = false; }
            if (Convert.ToString(range.Cells[26, 4].Value2) == "2") { checkBoxA26.Checked = false; }
            if (Convert.ToString(range.Cells[27, 4].Value2) == "2") { checkBoxA27.Checked = false; }
            if (Convert.ToString(range.Cells[28, 4].Value2) == "2") { checkBoxA28.Checked = false; }
            if (Convert.ToString(range.Cells[29, 4].Value2) == "2") { checkBoxA29.Checked = false; }
            if (Convert.ToString(range.Cells[30, 4].Value2) == "2") { checkBoxA30.Checked = false; }
            if (Convert.ToString(range.Cells[31, 4].Value2) == "2") { checkBoxA31.Checked = false; }
            if (Convert.ToString(range.Cells[32, 4].Value2) == "2") { checkBoxA32.Checked = false; }
            if (Convert.ToString(range.Cells[33, 4].Value2) == "2") { checkBoxA33.Checked = false; }
            if (Convert.ToString(range.Cells[34, 4].Value2) == "2") { checkBoxA34.Checked = false; }
            if (Convert.ToString(range.Cells[35, 4].Value2) == "2") { checkBoxA35.Checked = false; }
            if (Convert.ToString(range.Cells[36, 4].Value2) == "2") { checkBoxA36.Checked = false; }
            if (Convert.ToString(range.Cells[37, 4].Value2) == "2") { checkBoxA37.Checked = false; }
            if (Convert.ToString(range.Cells[38, 4].Value2) == "2") { checkBoxA38.Checked = false; }
            if (Convert.ToString(range.Cells[39, 4].Value2) == "2") { checkBoxA39.Checked = false; }
            if (Convert.ToString(range.Cells[40, 4].Value2) == "2") { checkBoxA40.Checked = false; }
            if (Convert.ToString(range.Cells[41, 4].Value2) == "2") { checkBoxA41.Checked = false; }
            if (Convert.ToString(range.Cells[42, 4].Value2) == "2") { checkBoxA42.Checked = false; }
            if (Convert.ToString(range.Cells[43, 4].Value2) == "2") { checkBoxA43.Checked = false; }
            if (Convert.ToString(range.Cells[44, 4].Value2) == "2") { checkBoxA44.Checked = false; }
            
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
          
        }

        private void buttonGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea Guardar los cambios realizados", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                guardarEnExcel();
                guardarEnBD();
                MessageBox.Show("Se guardaron todos los cambios","Salir - Guardando",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
                //FormPrincipal principal = new FormPrincipal();
                //principal.Show();
            }
            else {

                MessageBox.Show("NO se guardaron Cambios", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                //FormPrincipal principal = new FormPrincipal();
                //principal.Show();
            }
            

  
        }

        //Procedimiento que Guarda el Cambio de los aerogeneradores en BD.
        private void guardarEnBD()
        {

            if (checkBoxA1.Checked == true){ this.disponibilidadTableAdapter.actualizar("1", 1);}
            else {this.disponibilidadTableAdapter.actualizar("2", 1);}
            if (checkBoxA2.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 2); }
            else { this.disponibilidadTableAdapter.actualizar("2", 2); }
            if (checkBoxA3.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 3); }
            else { this.disponibilidadTableAdapter.actualizar("2", 3); }
            if (checkBoxA4.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 4); }
            else { this.disponibilidadTableAdapter.actualizar("2", 4); }
            if (checkBoxA5.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 5); }
            else { this.disponibilidadTableAdapter.actualizar("2", 5); }
            if (checkBoxA6.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 6); }
            else { this.disponibilidadTableAdapter.actualizar("2", 6); }
            if (checkBoxA7.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 7); }
            else { this.disponibilidadTableAdapter.actualizar("2", 7); }
            if (checkBoxA8.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 8); }
            else { this.disponibilidadTableAdapter.actualizar("2", 8); }
            if (checkBoxA9.Checked == true){ this.disponibilidadTableAdapter.actualizar("1", 9);}
            else {this.disponibilidadTableAdapter.actualizar("2", 9);}
            if (checkBoxA10.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 10); }
            else { this.disponibilidadTableAdapter.actualizar("2", 10); }
            if (checkBoxA11.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 11); }
            else { this.disponibilidadTableAdapter.actualizar("2", 11); }
            if (checkBoxA12.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 12); }
            else { this.disponibilidadTableAdapter.actualizar("2", 12); }
            if (checkBoxA13.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 13); }
            else { this.disponibilidadTableAdapter.actualizar("2", 13); }
            if (checkBoxA14.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 14); }
            else { this.disponibilidadTableAdapter.actualizar("2", 14); }
            if (checkBoxA15.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 15); }
            else { this.disponibilidadTableAdapter.actualizar("2", 15); }
            if (checkBoxA16.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 16); }
            else { this.disponibilidadTableAdapter.actualizar("2", 16); }
            if (checkBoxA17.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 17); }
            else { this.disponibilidadTableAdapter.actualizar("2", 17); }
            if (checkBoxA18.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 18); }
            else { this.disponibilidadTableAdapter.actualizar("2", 18); }
            if (checkBoxA19.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 19); }
            else { this.disponibilidadTableAdapter.actualizar("2", 19); }
            if (checkBoxA20.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 20); }
            else { this.disponibilidadTableAdapter.actualizar("2", 20); }
            if (checkBoxA21.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 21); }
            else { this.disponibilidadTableAdapter.actualizar("2", 21); }
            if (checkBoxA22.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 22); }
            else { this.disponibilidadTableAdapter.actualizar("2", 22); }
            if (checkBoxA23.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 23); }
            else { this.disponibilidadTableAdapter.actualizar("2", 23); }
            if (checkBoxA24.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 24); }
            else { this.disponibilidadTableAdapter.actualizar("2", 24); }
            if (checkBoxA25.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 25); }
            else { this.disponibilidadTableAdapter.actualizar("2", 25); }
            if (checkBoxA26.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 26); }
            else { this.disponibilidadTableAdapter.actualizar("2", 26); }
            if (checkBoxA27.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 27); }
            else { this.disponibilidadTableAdapter.actualizar("2", 27); }
            if (checkBoxA28.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 28); }
            else { this.disponibilidadTableAdapter.actualizar("2", 28); }
            if (checkBoxA29.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 29); }
            else { this.disponibilidadTableAdapter.actualizar("2", 29); }
            if (checkBoxA30.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 30); }
            else { this.disponibilidadTableAdapter.actualizar("2", 30); }
            if (checkBoxA31.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 31); }
            else { this.disponibilidadTableAdapter.actualizar("2", 31); }
            if (checkBoxA32.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 32); }
            else { this.disponibilidadTableAdapter.actualizar("2", 32); }
            if (checkBoxA33.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 33); }
            else { this.disponibilidadTableAdapter.actualizar("2", 33); }
            if (checkBoxA34.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 34); }
            else { this.disponibilidadTableAdapter.actualizar("2", 34); }
            if (checkBoxA35.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 35); }
            else { this.disponibilidadTableAdapter.actualizar("2", 35); }
            if (checkBoxA36.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 36); }
            else { this.disponibilidadTableAdapter.actualizar("2", 36); }
            if (checkBoxA37.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 37); }
            else { this.disponibilidadTableAdapter.actualizar("2", 37); }
            if (checkBoxA38.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 38); }
            else { this.disponibilidadTableAdapter.actualizar("2", 38); }
            if (checkBoxA39.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 39); }
            else { this.disponibilidadTableAdapter.actualizar("2", 39); }
            if (checkBoxA40.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 40); }
            else { this.disponibilidadTableAdapter.actualizar("2", 40); }
            if (checkBoxA41.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 41); }
            else { this.disponibilidadTableAdapter.actualizar("2", 41); }
            if (checkBoxA42.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 42); }
            else { this.disponibilidadTableAdapter.actualizar("2", 42); }
            if (checkBoxA43.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 43); }
            else { this.disponibilidadTableAdapter.actualizar("2", 43); }
            if (checkBoxA44.Checked == true) { this.disponibilidadTableAdapter.actualizar("1", 44); }
            else { this.disponibilidadTableAdapter.actualizar("2", 44); }

        }

        private void guardarEnExcel()
        {
            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet excelWorkSheet;
            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = false;
            oWB = oXL.Workbooks.Open("C:\\AppServ/www/Aeros/Aerogeneradores.xls"); //ESTA LINEA MARCA ERROR 
            excelWorkSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;
            //Cambia los Valores
            if (checkBoxA1.Checked == true) { excelWorkSheet.Cells[1, 4] = "1"; }
            else { excelWorkSheet.Cells[1, 4] = "2"; }
            if (checkBoxA2.Checked == true) { excelWorkSheet.Cells[2, 4] = "1"; }
            else { excelWorkSheet.Cells[2, 4] = "2"; }
            if (checkBoxA3.Checked == true) { excelWorkSheet.Cells[3, 4] = "1"; }
            else { excelWorkSheet.Cells[3, 4] = "2"; }
            if (checkBoxA4.Checked == true) { excelWorkSheet.Cells[4, 4] = "1"; }
            else { excelWorkSheet.Cells[4, 4] = "2"; }
            if (checkBoxA5.Checked == true) { excelWorkSheet.Cells[5, 4] = "1"; }
            else { excelWorkSheet.Cells[5, 4] = "2"; }
            if (checkBoxA6.Checked == true) { excelWorkSheet.Cells[6, 4] = "1"; }
            else { excelWorkSheet.Cells[6, 4] = "2"; }
            if (checkBoxA7.Checked == true) { excelWorkSheet.Cells[7, 4] = "1"; }
            else { excelWorkSheet.Cells[7, 4] = "2"; }
            if (checkBoxA8.Checked == true) { excelWorkSheet.Cells[8, 4] = "1"; }
            else { excelWorkSheet.Cells[8, 4] = "2"; }
            if (checkBoxA9.Checked == true) { excelWorkSheet.Cells[9, 4] = "1"; }
            else { excelWorkSheet.Cells[9, 4] = "2"; }
            if (checkBoxA10.Checked == true) { excelWorkSheet.Cells[10, 4] = "1"; }
            else { excelWorkSheet.Cells[10, 4] = "2"; }
            if (checkBoxA11.Checked == true) { excelWorkSheet.Cells[11, 4] = "1"; }
            else { excelWorkSheet.Cells[11, 4] = "2"; }
            if (checkBoxA12.Checked == true) { excelWorkSheet.Cells[12, 4] = "1"; }
            else { excelWorkSheet.Cells[12, 4] = "2"; }
            if (checkBoxA13.Checked == true) { excelWorkSheet.Cells[13, 4] = "1"; }
            else { excelWorkSheet.Cells[13, 4] = "2"; }
            if (checkBoxA14.Checked == true) { excelWorkSheet.Cells[14, 4] = "1"; }
            else { excelWorkSheet.Cells[14, 4] = "2"; }
            if (checkBoxA15.Checked == true) { excelWorkSheet.Cells[15, 4] = "1"; }
            else { excelWorkSheet.Cells[15, 4] = "2"; }
            if (checkBoxA16.Checked == true) { excelWorkSheet.Cells[16, 4] = "1"; }
            else { excelWorkSheet.Cells[16, 4] = "2"; }
            if (checkBoxA17.Checked == true) { excelWorkSheet.Cells[17, 4] = "1"; }
            else { excelWorkSheet.Cells[17, 4] = "2"; }
            if (checkBoxA18.Checked == true) { excelWorkSheet.Cells[18, 4] = "1"; }
            else { excelWorkSheet.Cells[18, 4] = "2"; }
            if (checkBoxA19.Checked == true) { excelWorkSheet.Cells[19, 4] = "1"; }
            else { excelWorkSheet.Cells[19, 4] = "2"; }
            if (checkBoxA20.Checked == true) { excelWorkSheet.Cells[20, 4] = "1"; }
            else { excelWorkSheet.Cells[20, 4] = "2"; }
            if (checkBoxA21.Checked == true) { excelWorkSheet.Cells[21, 4] = "1"; }
            else { excelWorkSheet.Cells[21, 4] = "2"; }
            if (checkBoxA22.Checked == true) { excelWorkSheet.Cells[22, 4] = "1"; }
            else { excelWorkSheet.Cells[22, 4] = "2"; }
            if (checkBoxA23.Checked == true) { excelWorkSheet.Cells[23, 4] = "1"; }
            else { excelWorkSheet.Cells[23, 4] = "2"; }
            if (checkBoxA24.Checked == true) { excelWorkSheet.Cells[24, 4] = "1"; }
            else { excelWorkSheet.Cells[24, 4] = "2"; }
            if (checkBoxA25.Checked == true) { excelWorkSheet.Cells[25, 4] = "1"; }
            else { excelWorkSheet.Cells[25, 4] = "2"; }
            if (checkBoxA26.Checked == true) { excelWorkSheet.Cells[26, 4] = "1"; }
            else { excelWorkSheet.Cells[26, 4] = "2"; }
            if (checkBoxA27.Checked == true) { excelWorkSheet.Cells[27, 4] = "1"; }
            else { excelWorkSheet.Cells[27, 4] = "2"; }
            if (checkBoxA28.Checked == true) { excelWorkSheet.Cells[28, 4] = "1"; }
            else { excelWorkSheet.Cells[28, 4] = "2"; }
            if (checkBoxA29.Checked == true) { excelWorkSheet.Cells[29, 4] = "1"; }
            else { excelWorkSheet.Cells[29, 4] = "2"; }
            if (checkBoxA30.Checked == true) { excelWorkSheet.Cells[30, 4] = "1"; }
            else { excelWorkSheet.Cells[30, 4] = "2"; }
            if (checkBoxA31.Checked == true) { excelWorkSheet.Cells[31, 4] = "1"; }
            else { excelWorkSheet.Cells[31, 4] = "2"; }
            if (checkBoxA32.Checked == true) { excelWorkSheet.Cells[32, 4] = "1"; }
            else { excelWorkSheet.Cells[32, 4] = "2"; }
            if (checkBoxA33.Checked == true) { excelWorkSheet.Cells[33, 4] = "1"; }
            else { excelWorkSheet.Cells[33, 4] = "2"; }
            if (checkBoxA34.Checked == true) { excelWorkSheet.Cells[34, 4] = "1"; }
            else { excelWorkSheet.Cells[34, 4] = "2"; }
            if (checkBoxA35.Checked == true) { excelWorkSheet.Cells[35, 4] = "1"; }
            else { excelWorkSheet.Cells[35, 4] = "2"; }
            if (checkBoxA36.Checked == true) { excelWorkSheet.Cells[36, 4] = "1"; }
            else { excelWorkSheet.Cells[36, 4] = "2"; }
            if (checkBoxA37.Checked == true) { excelWorkSheet.Cells[37, 4] = "1"; }
            else { excelWorkSheet.Cells[37, 4] = "2"; }
            if (checkBoxA38.Checked == true) { excelWorkSheet.Cells[38, 4] = "1"; }
            else { excelWorkSheet.Cells[38, 4] = "2"; }
            if (checkBoxA39.Checked == true) { excelWorkSheet.Cells[39, 4] = "1"; }
            else { excelWorkSheet.Cells[39, 4] = "2"; }
            if (checkBoxA40.Checked == true) { excelWorkSheet.Cells[40, 4] = "1"; }
            else { excelWorkSheet.Cells[40, 4] = "2"; }
            if (checkBoxA41.Checked == true) { excelWorkSheet.Cells[41, 4] = "1"; }
            else { excelWorkSheet.Cells[41, 4] = "2"; }
            if (checkBoxA42.Checked == true) { excelWorkSheet.Cells[42, 4] = "1"; }
            else { excelWorkSheet.Cells[42, 4] = "2"; }
            if (checkBoxA43.Checked == true) { excelWorkSheet.Cells[43, 4] = "1"; }
            else { excelWorkSheet.Cells[43, 4] = "2"; }
            if (checkBoxA44.Checked == true) { excelWorkSheet.Cells[44, 4] = "1"; }
            else { excelWorkSheet.Cells[44, 4] = "2"; }
            oWB.Save();//Para salvar el archivo con la nota 
            oWB.Close(null, null, null);
            oXL.Workbooks.Close();
            oXL.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oXL);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkSheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oWB);
            excelWorkSheet = null;
            oWB = null;
            oXL = null;
            GC.Collect(); 

            
     
        }

        private void FormConfigurarDisponibilidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vientosDataSet.Disponibilidad' Puede moverla o quitarla según sea necesario.
            this.disponibilidadTableAdapter.Fill(this.vientosDataSet.Disponibilidad);

        }

        private void SeleccionarTodo_Click(object sender, EventArgs e)
        {
            checkBoxA1.Checked = true;
            checkBoxA2.Checked = true;
            checkBoxA3.Checked = true;
            checkBoxA4.Checked = true;
            checkBoxA5.Checked = true;
            checkBoxA6.Checked = true;
            checkBoxA7.Checked = true;
            checkBoxA8.Checked = true;
            checkBoxA9.Checked = true;
            checkBoxA10.Checked = true;
            checkBoxA11.Checked = true;
            checkBoxA12.Checked = true;
            checkBoxA13.Checked = true;
            checkBoxA14.Checked = true;
            checkBoxA15.Checked = true;
            checkBoxA16.Checked = true;
            checkBoxA17.Checked = true;
            checkBoxA18.Checked = true;
            checkBoxA19.Checked = true;
            checkBoxA20.Checked = true;
            checkBoxA21.Checked = true;
            checkBoxA22.Checked = true;
            checkBoxA23.Checked = true;
            checkBoxA24.Checked = true;
            checkBoxA25.Checked = true;
            checkBoxA26.Checked = true;
            checkBoxA27.Checked = true;
            checkBoxA28.Checked = true;
            checkBoxA29.Checked = true;
            checkBoxA30.Checked = true;
            checkBoxA31.Checked = true;
            checkBoxA32.Checked = true;
            checkBoxA33.Checked = true;
            checkBoxA34.Checked = true;
            checkBoxA35.Checked = true;
            checkBoxA36.Checked = true;
            checkBoxA37.Checked = true;
            checkBoxA38.Checked = true;
            checkBoxA39.Checked = true;
            checkBoxA40.Checked = true;
            checkBoxA41.Checked = true;
            checkBoxA42.Checked = true;
            checkBoxA43.Checked = true;
            checkBoxA44.Checked = true;

           
            
               
        }

        private void DeseleccionarTodo_Click(object sender, EventArgs e)
        {
            checkBoxA1.Checked = false;
            checkBoxA2.Checked = false;
            checkBoxA3.Checked = false;
            checkBoxA4.Checked = false;
            checkBoxA5.Checked = false;
            checkBoxA6.Checked = false;
            checkBoxA7.Checked = false;
            checkBoxA8.Checked = false;
            checkBoxA9.Checked = false;
            checkBoxA10.Checked = false;
            checkBoxA11.Checked = false;
            checkBoxA12.Checked = false;
            checkBoxA13.Checked = false;
            checkBoxA14.Checked = false;
            checkBoxA15.Checked = false;
            checkBoxA16.Checked = false;
            checkBoxA17.Checked = false;
            checkBoxA18.Checked = false;
            checkBoxA19.Checked = false;
            checkBoxA20.Checked = false;
            checkBoxA21.Checked = false;
            checkBoxA22.Checked = false;
            checkBoxA23.Checked = false;
            checkBoxA24.Checked = false;
            checkBoxA25.Checked = false;
            checkBoxA26.Checked = false;
            checkBoxA27.Checked = false;
            checkBoxA28.Checked = false;
            checkBoxA29.Checked = false;
            checkBoxA30.Checked = false;
            checkBoxA31.Checked = false;
            checkBoxA32.Checked = false;
            checkBoxA33.Checked = false;
            checkBoxA34.Checked = false;
            checkBoxA35.Checked = false;
            checkBoxA36.Checked = false;
            checkBoxA37.Checked = false;
            checkBoxA38.Checked = false;
            checkBoxA39.Checked = false;
            checkBoxA40.Checked = false;
            checkBoxA41.Checked = false;
            checkBoxA42.Checked = false;
            checkBoxA43.Checked = false;
            checkBoxA44.Checked = false;
        }

       
        




       
      

       
    }
}
