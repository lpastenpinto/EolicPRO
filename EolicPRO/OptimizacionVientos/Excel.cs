using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimizacionVientos
{
    class Excel
    {
        public string[,] cargar_Efecto_Estela()
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Range range;

            string[,] Matriz_Efecto_Estela;
            Matriz_Efecto_Estela = new string[66, 3];

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open("C:/Efecto_Estela.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;

            for (int x = 2; x < 68; x++)
            {
                Matriz_Efecto_Estela[x - 2, 0] = xlWorkSheet.get_Range("A" + x, "A" + x).Value2.ToString();
                Matriz_Efecto_Estela[x - 2, 1] = xlWorkSheet.get_Range("B" + x, "B" + x).Value2.ToString();
                Matriz_Efecto_Estela[x - 2, 2] = xlWorkSheet.get_Range("C" + x, "C" + x).Value2.ToString();
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
            return Matriz_Efecto_Estela;

        }


        public double[] cargar_Altura_Aerogeneradores()
        {

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Range range;

            double[] Altura_Aerogeneradores;
            Altura_Aerogeneradores = new double[44];

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open("C:/Aerogeneradores.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;

            for (int x = 2; x < 46; x++)
            {
                Altura_Aerogeneradores[x - 2] = Convert.ToDouble(xlWorkSheet.get_Range("E" + x, "E" + x).Value2.ToString());

            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            return Altura_Aerogeneradores;

        }
    }
}
