using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace OptimizacionVientos
{

    public partial class FormPrincipal : Form
    {

        List<double> energiaAeros = new List<double>();

        List<double> porcentajes = new List<double>();

        List<double> energiaAerosTramo1 = new List<double>();
        List<double> energiaAerosTramo2 = new List<double>();
        List<double> energiaAerosTramo3 = new List<double>();
        List<double> energiaAerosTramo4 = new List<double>();
        List<double> energiaAerosTramo5 = new List<double>();
        List<double> energiaAerosTramo6 = new List<double>();
        List<double> energiaAerosTramo7 = new List<double>();
        List<double> energiaAerosTramo8 = new List<double>();
        

        public FormPrincipal()
        {
            
            InitializeComponent();
            planificacion.Visible = false;
            webBrowser1.Navigate("localhost/Aeros/mapa.php");
        }
   
        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

            MessageBox.Show("Se cerrara la Aplicación");
        }

        private void verHistoricosToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FormHistoricos historicos = new FormHistoricos();
                historicos.ShowDialog();
        }

        private void configurarDisponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfigurarDisponibilidad disponibilidad = new FormConfigurarDisponibilidad();
            disponibilidad.ShowDialog();
            webBrowser1.Navigate("localhost/Aeros/mapa.php");

        }


        private void planificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            double energia_anual = Convert.ToDouble(this.historicosTableAdapter.EnergiaProducidaParaAno());
            double meta_anual = Convert.ToDouble(this.meta_AnualTableAdapter.TraerMetaAnual())*1000;
            //MessageBox.Show("Meta anual en GW" + meta_anual);
            DateTime fecha_fin_año = new DateTime(2014, 12, 31);
            DateTime fecha_actual = DateTime.Today.AddDays(1);
            TimeSpan diferencia = fecha_fin_año - fecha_actual;
            int dias_diferencia = diferencia.Days;
            //MessageBox.Show("Dias que quedan del año"+dias_diferencia);
            double energia_a_producir = Math.Round((((meta_anual - energia_anual) / dias_diferencia)),2);

            //MessageBox.Show(""+energia_anual);
           
            textBoxEnergiaProducir.Text= Convert.ToString(energia_a_producir);
            double energia_anual_producida = Convert.ToDouble(this.historicosTableAdapter.EnergiaProducidaParaAno());
            labelPorcentaje.Text = Convert.ToString(Math.Round(Convert.ToDouble((energia_anual_producida * 100) / meta_anual), 2)) + "%";
            labelEnergiaAnual.Text = Convert.ToString(meta_anual/1000)+"[Gw]";
            DateTime manana = DateTime.Today.AddDays(1);
            string fecha = manana.ToString("dd-MM-yyyy");
            int contador = Convert.ToInt32(this.historicos_climaTableAdapter.verdatos(fecha).ToString());

            if (contador > 0) {
                MessageBox.Show("Ya Existen datos del viento de esa fecha", "Datos Existentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                groupBoxNoticia.Visible = false;
                planificacion.Visible = true;
                buttonGuardarPlanificacion.Visible = false;
                dataGridViewEnergiacadaUno.Rows.Clear();
                dataGridViewEnergiacadaUno.Visible = false;
                dataGridViewPlanificacion.Rows.Clear();
                labelEnergiaTotalProducida.Text = "";
                labelFechaPlanificacion.Text = "";
                labelTiempodeEjecucion.Text = "";      
                labelMensajeError.Visible = false;
                
            }
            else
            {
                FormTomaDatosViento tomarDatos = new FormTomaDatosViento();
                tomarDatos.ShowDialog();          
                groupBoxNoticia.Visible = false;
                planificacion.Visible = true;
                buttonGuardarPlanificacion.Visible = false;
                dataGridViewEnergiacadaUno.Rows.Clear();
                dataGridViewEnergiacadaUno.Visible = false;
                dataGridViewPlanificacion.Rows.Clear();
                labelEnergiaTotalProducida.Text = "";
                labelFechaPlanificacion.Text = "";
                labelTiempodeEjecucion.Text = ""; 
                labelMensajeError.Visible = false;
            }


        }


        private void cerrarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Desea Salir de la Aplicación", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca acerca = new Acerca();
            acerca.ShowDialog();
        }

        private void verHistoricosVientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoricosVientos vientos = new FormHistoricosVientos();
            vientos.ShowDialog();
        }




        private void buttonPlanificar_Click(object sender, EventArgs e)
        {
            //try{
            if (textBoxEnergiaProducir.Text == "" || textBoxIteraciones.Text == "")
            {
                MessageBox.Show("No deje campos en Blanco", "Error - Ingreso Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                //se realiza la planificación
            else {
                double energia_anual_producida = Convert.ToDouble(this.historicosTableAdapter.EnergiaProducidaParaAno());
                
                //MessageBox.Show(""+energia_anual);
                groupBoxResultados.Visible = false;
                progressBar.Visible = true;
                progressBar.Value = 0;
                labelProgreso.Visible = true;
                energiaAeros.Clear();
                porcentajes.Clear();
                buttonGuardarPlanificacion.Visible = false;
                List<double> tramos = new List<double>();
                this.pareto_tramoTableAdapter.Fill(vientosDataSet.pareto_tramo);
               // MessageBox.Show("ACA se hace la planificacion");
                double metaIngresada = Convert.ToDouble(textBoxEnergiaProducir.Text.Trim());
                double meta = metaIngresada - (metaIngresada * 0.05);  //Se le Agrega el 5% para produccion
                
                //borrar el datagrid
                dataGridViewEnergiacadaUno.Rows.Clear();
                dataGridViewEnergiacadaUno.Visible = false;
                dataGridViewPlanificacion.Rows.Clear();
                energiaAerosTramo1.Clear();
                energiaAerosTramo2.Clear();
                energiaAerosTramo3.Clear();
                energiaAerosTramo4.Clear();
                energiaAerosTramo5.Clear();
                energiaAerosTramo6.Clear();
                energiaAerosTramo7.Clear();
                energiaAerosTramo8.Clear();
                labelEnergiaTotalProducida.Text = "";
                labelFechaPlanificacion.Text = "";
                labelTiempodeEjecucion.Text = "";
                
                labelMensajeError.Visible = false;

             
                tramos = ObtenerParetoTramos(meta);

               
                double primerTramo = Convert.ToDouble(tramos[0].ToString())/3;
                double segundoTramo = Convert.ToDouble(tramos[1].ToString())/3;
                double tercerTramo = Convert.ToDouble(tramos[2].ToString())/3;
                double cuartoTramo = Convert.ToDouble(tramos[3].ToString())/3;
                double quintoTramo = Convert.ToDouble(tramos[4].ToString())/3;
                double sextoTramo = Convert.ToDouble(tramos[5].ToString())/3;
                double septimoTramo = Convert.ToDouble(tramos[6].ToString())/3;
                double octavoTramo = Convert.ToDouble(tramos[7].ToString())/3;

                //MessageBox.Show("" + primerTramo + "-" + segundoTramo + "-" + tercerTramo + "-" + cuartoTramo + "-" + quintoTramo + "-" + sextoTramo + "-" + septimoTramo + "-" + octavoTramo);


                DateTime manana = DateTime.Today.AddDays(1);
                string fecha = manana.ToString("dd-MM-yyyy");

                DateTime tiempo_inicial = DateTime.Now;
                //ejecucion de los AG

                progressBar.Value = 10;
                AlgoritmoGenetico("2:01-5:00",primerTramo);
                progressBar.Value = 22;
                AlgoritmoGenetico("5:01-8:00", segundoTramo);
                progressBar.Value = 34;
                AlgoritmoGenetico("8:01-11:00", tercerTramo);
                progressBar.Value = 46;
                AlgoritmoGenetico("11:01-14:00", cuartoTramo);
                progressBar.Value = 58;
                AlgoritmoGenetico("14:01-17:00", quintoTramo);
                progressBar.Value = 70;
                AlgoritmoGenetico("17:01-20:00", sextoTramo);
                progressBar.Value = 82;
                AlgoritmoGenetico("20:01-23:00", septimoTramo);
                progressBar.Value = 90;
                AlgoritmoGenetico("23:01-2:00", octavoTramo);
                progressBar.Value = 100;


               
                groupBoxResultados.Visible = true;
                DateTime tiempo_final = DateTime.Now;
                TimeSpan tiempo_total = new TimeSpan(tiempo_final.Ticks - tiempo_inicial.Ticks);
                
                buttonGuardarPlanificacion.Visible = true;
                
                
                labelTiempodeEjecucion.Text = Convert.ToString(tiempo_total);
                labelFechaPlanificacion.Text = fecha;
                //MessageBox.Show(Convert.ToString(Convert.ToDouble((energia_anual * 100) / 102000)));
                //labelPorcentaje.Text = Convert.ToString(Math.Round(Convert.ToDouble((energia_anual_producida * 100) / 102000),2)) + "%";
                progressBar.Visible = false;
                labelProgreso.Visible = false;

                if (obtenerEnergiaTotalProducida() == 0)
                {
                    MessageBox.Show("No se pudo Generar energía con la Configuración Actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    labelEnergiaTotalProducida.Text = Convert.ToString(Math.Round(obtenerEnergiaTotalProducida(), 2))+" [MW]";
                }

            }

            //}
            //catch (Exception a)
            //{

            //    MessageBox.Show("No existen Datos para Planificar", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
        
        }




        private List<double> ObtenerParetoTramos(double meta)
        {
           
            
            DateTime manana = DateTime.Today.AddDays(1);
            string fecha = manana.ToString("dd-MM-yyyy");

            this.historicos_climaTableAdapter.FillBy2(vientosDataSet.Historicos_clima, fecha);

            List<double> lista= new List<double>();
            double Porcentaje1 = Convert.ToDouble(dataGridViewPareto.Rows[0].Cells[1].Value.ToString());
            if (Convert.ToDouble(dataGridViewVelocidad.Rows[0].Cells[0].Value.ToString()) < 4) { Porcentaje1 = 0; }
            double Porcentaje2 = Convert.ToDouble(dataGridViewPareto.Rows[1].Cells[1].Value.ToString());
            if (Convert.ToDouble(dataGridViewVelocidad.Rows[1].Cells[0].Value.ToString()) < 4) { Porcentaje2 = 0; }
            double Porcentaje3 = Convert.ToDouble(dataGridViewPareto.Rows[2].Cells[1].Value.ToString());
            if (Convert.ToDouble(dataGridViewVelocidad.Rows[2].Cells[0].Value.ToString()) < 4) { Porcentaje3 = 0; }
            double Porcentaje4 = Convert.ToDouble(dataGridViewPareto.Rows[3].Cells[1].Value.ToString());
            if (Convert.ToDouble(dataGridViewVelocidad.Rows[3].Cells[0].Value.ToString()) < 4) { Porcentaje4 = 0; }
            double Porcentaje5 = Convert.ToDouble(dataGridViewPareto.Rows[4].Cells[1].Value.ToString());
            if (Convert.ToDouble(dataGridViewVelocidad.Rows[4].Cells[0].Value.ToString()) < 4) { Porcentaje5 = 0; }
            double Porcentaje6 = Convert.ToDouble(dataGridViewPareto.Rows[5].Cells[1].Value.ToString());
            if (Convert.ToDouble(dataGridViewVelocidad.Rows[5].Cells[0].Value.ToString()) < 4) { Porcentaje6 = 0; }
            double Porcentaje7 = Convert.ToDouble(dataGridViewPareto.Rows[6].Cells[1].Value.ToString());
            if (Convert.ToDouble(dataGridViewVelocidad.Rows[6].Cells[0].Value.ToString()) < 4) { Porcentaje7 = 0; }
            double Porcentaje8 = Convert.ToDouble(dataGridViewPareto.Rows[7].Cells[1].Value.ToString());
            if (Convert.ToDouble(dataGridViewVelocidad.Rows[7].Cells[0].Value.ToString()) < 4) { Porcentaje8 = 0; }

            double suma = Porcentaje1 + Porcentaje2 + Porcentaje3 + Porcentaje4 + Porcentaje5 + Porcentaje6 + Porcentaje7 + Porcentaje8;
            //agregamos los porcentajes

            //porcentajes.Clear();
            //porcentajes.Add(Math.Round((((Porcentaje1 * 100) / suma)),0));
            //porcentajes.Add(Math.Round((((Porcentaje2 * 100) / suma)), 0));
            //porcentajes.Add(Math.Round((((Porcentaje3 * 100) / suma)), 0));
            //porcentajes.Add(Math.Round((((Porcentaje4 * 100) / suma)), 0));
            //porcentajes.Add(Math.Round((((Porcentaje5 * 100) / suma)), 0));
            //porcentajes.Add(Math.Round((((Porcentaje6 * 100) / suma)), 0));
            //porcentajes.Add(Math.Round((((Porcentaje7 * 100) / suma)), 0));
            //porcentajes.Add(Math.Round((((Porcentaje8 * 100) / suma)), 0));

           



            //MessageBox.Show("Meta:"+meta+"  Suma de todo -"+suma+"---" + Porcentaje1 + "-" + Porcentaje2 + "-" + Porcentaje3 + "-" + Porcentaje4 + "-" + Porcentaje5 + "-" + Porcentaje6 + "-" + Porcentaje7 + "-" + Porcentaje8);
            double pareto1 = (meta*(Porcentaje1 * 100) / suma)/100;
            double pareto2 = (meta * (Porcentaje2 * 100) / suma) / 100;
            double pareto3 = (meta * (Porcentaje3 * 100) / suma) / 100;
            double pareto4 = (meta * (Porcentaje4 * 100) / suma) / 100;
            double pareto5 = (meta * (Porcentaje5 * 100) / suma) / 100;
            double pareto6 = (meta * (Porcentaje6 * 100) / suma) / 100;
            double pareto7 = (meta * (Porcentaje7 * 100) / suma) / 100;
            double pareto8 = (meta * (Porcentaje8 * 100) / suma) / 100;

           // MessageBox.Show("-"+pareto1+"-"+pareto2+"-"+pareto3+"-"+pareto4+"-"+pareto5+"-"+pareto6+"-"+pareto7+"-"+pareto8);
            lista.Add(pareto1);
            lista.Add(pareto2);
            lista.Add(pareto3);
            lista.Add(pareto4);
            lista.Add(pareto5);
            lista.Add(pareto6);
            lista.Add(pareto7);
            lista.Add(pareto8);
            return lista;
        }




        public double obtenerEnergiaTotalProducida()
        {
            double energia = 0;
            for (int i = 0; i < 8; i++)
            {
                double ener = Convert.ToDouble(dataGridViewPlanificacion.Rows[i].Cells[4].Value.ToString());
                energia = energia + ener;
                //MessageBox.Show(""+energia);

            }
            return (energia);
        }

    


        /// <summary>
        /// Algoritmo Principal del Modelo - Optimiza el rendimiento de los Aerogeneradores.
        /// </summary>
        private void AlgoritmoGenetico(string tramo, double energiaProducir)
        {

           
                string AerosFuncionaron = "";
               // MessageBox.Show(""+ energiaProducir);
                DateTime manana = DateTime.Today.AddDays(1);
                string fecha = manana.ToString("dd-MM-yyyy");

                this.historicos_climaTableAdapter.FillBy1(this.vientosDataSet.Historicos_clima, tramo, fecha);

                double velocidad_del_viento = Convert.ToDouble(dataGridViewVelocidadDireccion.Rows[0].Cells[1].Value);
                string direccion_del_viento = dataGridViewVelocidadDireccion.Rows[0].Cells[0].Value.ToString();

                if (energiaProducir != 0)
                {

                    int cantidad_iteraciones = Convert.ToInt32(textBoxIteraciones.Text); //Cantidad de iteraciones que da el Usuario.
                    int Tamaño_Poblacion = 1000;//poblacion Estatica
                    int probabilidad_cruce = 80;
                    double Meta_de_Produccion = energiaProducir;
                    //MessageBox.Show("Se busca esta energia:" + energiaProducir);
                    Excel matriz = new Excel();

                    List<int> Aerogeneradores_No_Disponibles = new List<int>();

                    Aerogeneradores_No_Disponibles = ObtenerNoDisponibles();

                    double[] altura_aerogeneradores = matriz.cargar_Altura_Aerogeneradores();

                    AG Ag = new AG();


                    //tamaño poblacion/direccion del viento/altura aerogeneradores/ meta a cumplir
                    Ag.Creacion_Poblacion_Inicial(Aerogeneradores_No_Disponibles, Tamaño_Poblacion, direccion_del_viento, velocidad_del_viento, altura_aerogeneradores, Meta_de_Produccion);

                    for (int x = 0; x < cantidad_iteraciones; x++)
                    {
                        Ag.Asignacion_Fitness_Poblacion(velocidad_del_viento);
                        //Ag.Visualizar_fitness();
                        Ag.Seleccion();  //Por torneo              
                        Ag.Cruce(probabilidad_cruce, 16, 32);   //Parametro probabilidad de cruce              
                        Ag.Mutacion(Aerogeneradores_No_Disponibles);
                        Ag.Elitismo_Minimizar(95); //(PARAMETRO-100) %  DE POBLACION INTERMEDIA QUE PASA INTACTA 
                        Ag.Reemplazo_Generacion();
                        //Ag.Comprobar_Convergencia_Poblacion(0.95);
                        //        Console.WriteLine("-----------------------------------------------------------------------");

                    }

                    //Ag.Comprobar_Convergencia_Poblacion(0.95);
                    int[] Solucion = Ag.Visualizar_Solucion();

                    double[] Produccion_Energia_Aerogeneradores = Ag.Calculo_Produccion_Individuo(Solucion, velocidad_del_viento);
                    for (int x = 0; x < 44; x++)
                    {
                        //Console.Write("     " + Solucion[x]);
                        if (Solucion[x] == 1)
                        {
                            AerosFuncionaron = AerosFuncionaron + "" + Convert.ToString(x) + "-";
                        }
                    }

                    List<double> EnergiaTramoTotal = new List<double>();
                    EnergiaTramoTotal.Clear();
                    for (int x = 0; x < 44; x++)
                    {
                        //System.Console.Write("\nProduccion aerogenerador: " + (x+1) + "  " + Produccion_Energia_Aerogeneradores[x]);
                        if (Produccion_Energia_Aerogeneradores[x] != 0)
                        {
                            energiaAeros.Add(Convert.ToDouble(Produccion_Energia_Aerogeneradores[x])*3);
                            EnergiaTramoTotal.Add(Convert.ToDouble(Produccion_Energia_Aerogeneradores[x])*3);
                            
                            if (tramo == "2:01-5:00") { energiaAerosTramo1.Add(Convert.ToDouble(Produccion_Energia_Aerogeneradores[x])*3); }
                            if (tramo == "5:01-8:00") { energiaAerosTramo2.Add(Convert.ToDouble(Produccion_Energia_Aerogeneradores[x])*3); }
                            if (tramo == "8:01-11:00") { energiaAerosTramo3.Add(Convert.ToDouble(Produccion_Energia_Aerogeneradores[x])*3); }
                            if (tramo == "11:01-14:00") { energiaAerosTramo4.Add(Convert.ToDouble(Produccion_Energia_Aerogeneradores[x])*3); }
                            if (tramo == "14:01-17:00") { energiaAerosTramo5.Add(Convert.ToDouble(Produccion_Energia_Aerogeneradores[x])*3); }
                            if (tramo == "17:01-20:00") { energiaAerosTramo6.Add(Convert.ToDouble(Produccion_Energia_Aerogeneradores[x])*3); }
                            if (tramo == "20:01-23:00") { energiaAerosTramo7.Add(Convert.ToDouble(Produccion_Energia_Aerogeneradores[x])*3); }
                            if (tramo == "23:01-2:00") { energiaAerosTramo8.Add(Convert.ToDouble(Produccion_Energia_Aerogeneradores[x])*3); }
                                                    }
                       

                    }

                   // Console.WriteLine("Produccion total" + Produccion_Energia_Aerogeneradores[44]);
                    if (Produccion_Energia_Aerogeneradores[44] > 0)
                    {
                        double sumarenergiatramo = SumarEnergiaTramo(EnergiaTramoTotal);
                        dataGridViewPlanificacion.Rows.Add(tramo, velocidad_del_viento, direccion_del_viento, Convert.ToString(AerosFuncionaron), Math.Round(sumarenergiatramo/ 1000, 2));
                    }
                    else
                    {
                        dataGridViewPlanificacion.Rows.Add(tramo, velocidad_del_viento, direccion_del_viento, "(*) Imposible producir meta de producción energética",0);
                    }
                    //Console.Read();
                }
                else {

                    dataGridViewPlanificacion.Rows.Add(tramo, velocidad_del_viento, direccion_del_viento, "(*) Imposible producir meta de producción energética", 0);
                    labelMensajeError.Visible = true;
                }
           
        }

        private double SumarEnergiaTramo(List<double> EnergiaTramoTotal)
        {
            double suma = 0;
            for (int i = 0; i <= EnergiaTramoTotal.Count-1; i++) {
                suma = suma + EnergiaTramoTotal[i];
            }
            return(suma);
        }

        


        //Se obtienen los Aeros no Disponibles...
        private List<int> ObtenerNoDisponibles()
        {
            List<int> No_Disponibles = new List<int>();
            this.disponibilidadTableAdapter.FillBy(vientosDataSet.Disponibilidad,"2");
  
            for (int fila = 0; fila < dataGridViewNoDisponibles.RowCount; fila++)
            {
                int aero = Convert.ToInt32(dataGridViewNoDisponibles.Rows[fila].Cells[0].Value);
                No_Disponibles.Add(aero);
            }

            return(No_Disponibles);
        }


        //No permitir ingresar Letras a los Campos pedidos...

        private void textBoxIteraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            { e.Handled = false; }
            else { e.Handled = true; } 
        }

        private void textBoxEnergiaProducir_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar)) 
                { e.Handled = false; 
            }else if (e.KeyChar == ',')
                             {
                                       e.Handled = false;
                             }else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            { e.Handled = false; 
                             }
                                else { e.Handled = true; } 
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vientosDataSet1.Meta_Anual' Puede moverla o quitarla según sea necesario.
            this.meta_AnualTableAdapter.Fill(this.vientosDataSet1.Meta_Anual);
            // TODO: esta línea de código carga datos en la tabla 'vientosDataSet.Historicos' Puede moverla o quitarla según sea necesario.
            this.historicosTableAdapter.Fill(this.vientosDataSet.Historicos);
            // TODO: esta línea de código carga datos en la tabla 'vientosDataSet.pareto_tramo' Puede moverla o quitarla según sea necesario.
            this.pareto_tramoTableAdapter.Fill(this.vientosDataSet.pareto_tramo);
            // TODO: esta línea de código carga datos en la tabla 'vientosDataSet.Historicos_clima' Puede moverla o quitarla según sea necesario.
            this.historicos_climaTableAdapter.Fill(this.vientosDataSet.Historicos_clima);
            // TODO: esta línea de código carga datos en la tabla 'vientosDataSet.Disponibilidad' Puede moverla o quitarla según sea necesario.
            this.disponibilidadTableAdapter.FillBy(this.vientosDataSet.Disponibilidad, "2");
        }


        //Al presionar la fila muestra en el webbrowser los aeros que funcionaron.
        private void dataGridViewPlanificacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MostrarEnergiaCadaUno( e );
                int filaseleccionada = e.RowIndex;
                //MessageBox.Show(""+filaseleccionada);
                string parametros = dataGridViewPlanificacion.Rows[filaseleccionada].Cells[3].Value.ToString();
                string get = parametros.Replace("-", "&");
                string ruta = "localhost/Aeros/mapaHistorico.php?" + get;

                webBrowser1.Navigate(ruta);
            }
            catch 
            {
                MessageBox.Show("Nada que Mostrar en el Mapa");

            }
        }

        private void MostrarEnergiaCadaUno(DataGridViewCellEventArgs e)
        {

            try
            {
                int filaSeleccionada = e.RowIndex;
                dataGridViewEnergiacadaUno.Rows.Clear();
                dataGridViewEnergiacadaUno.Visible = true;
                //MessageBox.Show("Se selecciono la fila"+filaSeleccionada);
                string[] aero1 = dataGridViewPlanificacion.Rows[filaSeleccionada].Cells[3].Value.ToString().Split('-');


                if (filaSeleccionada == 0)
                {
                    for (int i = 0; i < energiaAerosTramo1.Count; i++)
                    {
                        dataGridViewEnergiacadaUno.Rows.Add(aero1[i], Math.Round(energiaAerosTramo1[i] / 1000, 2) + " [MW]");
                    }
                }
                if (filaSeleccionada == 1)
                {
                    for (int i = 0; i < energiaAerosTramo2.Count; i++)
                    {
                        dataGridViewEnergiacadaUno.Rows.Add(aero1[i], Math.Round(energiaAerosTramo2[i] / 1000, 2) + " [MW]");
                    }
                }
                if (filaSeleccionada == 2)
                {
                    for (int i = 0; i < energiaAerosTramo3.Count; i++)
                    {
                        dataGridViewEnergiacadaUno.Rows.Add(aero1[i], Math.Round(energiaAerosTramo3[i] / 1000, 2) + " [MW]");
                    }
                }
                if (filaSeleccionada == 3)
                {
                    for (int i = 0; i < energiaAerosTramo4.Count; i++)
                    {
                        dataGridViewEnergiacadaUno.Rows.Add(aero1[i], Math.Round(energiaAerosTramo4[i] / 1000, 2) + " [MW]");
                    }
                }
                if (filaSeleccionada == 4)
                {
                    for (int i = 0; i < energiaAerosTramo5.Count; i++)
                    {
                        dataGridViewEnergiacadaUno.Rows.Add(aero1[i], Math.Round(energiaAerosTramo5[i] / 1000, 2) + " [MW]");
                    }
                }
                if (filaSeleccionada == 5)
                {
                    for (int i = 0; i < energiaAerosTramo6.Count; i++)
                    {
                        dataGridViewEnergiacadaUno.Rows.Add(aero1[i], Math.Round(energiaAerosTramo6[i] / 1000, 2) + " [MW]");
                    }
                }
                if (filaSeleccionada == 6)
                {
                    for (int i = 0; i < energiaAerosTramo7.Count; i++)
                    {
                        dataGridViewEnergiacadaUno.Rows.Add(aero1[i], Math.Round(energiaAerosTramo7[i] / 1000, 2) + " [MW]");
                    }
                }
                if (filaSeleccionada == 7)
                {
                    for (int i = 0; i < energiaAerosTramo8.Count; i++)
                    {
                        dataGridViewEnergiacadaUno.Rows.Add(aero1[i], Math.Round(energiaAerosTramo8[i] / 1000, 2)+" [MW]");
                    }
                }

            }
            catch{ }

        }


        private void configurarParetoTramosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> listaVelocidad = ObtenerVelocidades();
            FormPareto pareto = new FormPareto(Convert.ToDouble(textBoxEnergiaProducir.Text),listaVelocidad);
            pareto.ShowDialog();
        }

        private List<int> ObtenerVelocidades()
        {

            DateTime manana = DateTime.Today.AddDays(1);
            string fecha = manana.ToString("dd-MM-yyyy");
            List<int> velocidades = new List<int>();

            this.historicos_climaTableAdapter.FillBy2(vientosDataSet.Historicos_clima, fecha);
            velocidades.Add(Convert.ToInt16(dataGridViewVelocidad.Rows[0].Cells[0].Value.ToString()));
            velocidades.Add(Convert.ToInt16(dataGridViewVelocidad.Rows[1].Cells[0].Value.ToString()));
            velocidades.Add(Convert.ToInt16(dataGridViewVelocidad.Rows[2].Cells[0].Value.ToString()));
            velocidades.Add(Convert.ToInt16(dataGridViewVelocidad.Rows[3].Cells[0].Value.ToString()));
            velocidades.Add(Convert.ToInt16(dataGridViewVelocidad.Rows[4].Cells[0].Value.ToString()));
            velocidades.Add(Convert.ToInt16(dataGridViewVelocidad.Rows[5].Cells[0].Value.ToString()));
            velocidades.Add(Convert.ToInt16(dataGridViewVelocidad.Rows[6].Cells[0].Value.ToString()));
            velocidades.Add(Convert.ToInt16(dataGridViewVelocidad.Rows[7].Cells[0].Value.ToString()));

            

            return velocidades;
        }



        private void buttonGuardarPlanificacion_Click(object sender, EventArgs e)

        {
            DateTime manana = DateTime.Today.AddDays(1);
            string fecha = manana.ToString("dd-MM-yyyy");

            int contador = Convert.ToInt16(this.historicosTableAdapter.ContarFecha(fecha).ToString());

            if (contador == 0)
            {

                DialogResult dialogResult = MessageBox.Show("Desea Guardar la Planificación - Una vez que la guarde no podra realizar otra para este día", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Planificación Guardada con Exito", "Planificación guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GuardarPlanificacion();

                    DialogResult dialogResult2 = MessageBox.Show("Desea Generar un Excel de la Planificación", "Generar Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult2 == DialogResult.Yes)
                    {

                        ExportarExcelPlanificacion();
                        MessageBox.Show("Excel Generado con exito!","Generar Excel",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("Planificación Guardada con Exito", "Planificación guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    MessageBox.Show("NO se guardaron Cambios", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else {
                MessageBox.Show("No se puede guardar mas de una Planificación por día", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult dialogResult2 = MessageBox.Show("Desea Generar un Excel de la Planificacion", "Generar Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult2 == DialogResult.Yes)
                {
                    ExportarExcelPlanificacion();


                }
            }
        }



        //Guarda la Planificacion en la base de datos
        private void GuardarPlanificacion()
        {

                DateTime manana = DateTime.Today.AddDays(1);
                string fecha = manana.ToString("dd-MM-yyyy");
                int contador = 0;
                string[] aero1 = dataGridViewPlanificacion.Rows[0].Cells[3].Value.ToString().Split('-');

            for (int i = 0; i < aero1.Length-1; i++) {
                //MessageBox.Show(fecha+"-"+ dataGridViewPlanificacion.Rows[0].Cells[0].Value.ToString()+"-"+ energiaAeros[contador]/1000+"---"+ dataGridViewPlanificacion.Rows[0].Cells[2].Value.ToString()+"--"+ Convert.ToInt16(dataGridViewPlanificacion.Rows[0].Cells[1].Value.ToString())+"--"+ Convert.ToInt16(aero1[i]));
                this.historicosTableAdapter.InsertarHistorico(fecha,dataGridViewPlanificacion.Rows[0].Cells[0].Value.ToString(),Math.Round(energiaAeros[contador]/1000,2),dataGridViewPlanificacion.Rows[0].Cells[2].Value.ToString(),Convert.ToInt16(dataGridViewPlanificacion.Rows[0].Cells[1].Value.ToString()),Convert.ToInt16(aero1[i]));
                contador++;
            }

            string[] aero2 = dataGridViewPlanificacion.Rows[1].Cells[3].Value.ToString().Split('-');

            for (int i = 0; i < aero2.Length - 1; i++)
            {
                //MessageBox.Show(fecha + "-" + dataGridViewPlanificacion.Rows[1].Cells[0].Value.ToString() + "-" + energiaAeros[contador] + "---" + dataGridViewPlanificacion.Rows[1].Cells[2].Value.ToString() + "--" + Convert.ToInt16(dataGridViewPlanificacion.Rows[1].Cells[1].Value.ToString()) + "--" + Convert.ToInt16(aero2[i]));
                this.historicosTableAdapter.InsertarHistorico(fecha ,dataGridViewPlanificacion.Rows[1].Cells[0].Value.ToString(),Math.Round(energiaAeros[contador]/1000,2),dataGridViewPlanificacion.Rows[1].Cells[2].Value.ToString(),Convert.ToInt16(dataGridViewPlanificacion.Rows[1].Cells[1].Value.ToString()),Convert.ToInt16(aero2[i]));
                contador++;
            }


            string[] aero3 = dataGridViewPlanificacion.Rows[2].Cells[3].Value.ToString().Split('-');

            for (int i = 0; i < aero3.Length - 1; i++)
            {
                //MessageBox.Show(fecha + "-" + dataGridViewPlanificacion.Rows[2].Cells[0].Value.ToString() + "-" + energiaAeros[contador] + "---" + dataGridViewPlanificacion.Rows[2].Cells[2].Value.ToString() + "--" + Convert.ToInt16(dataGridViewPlanificacion.Rows[2].Cells[1].Value.ToString()) + "--" + Convert.ToInt16(aero3[i]));
                this.historicosTableAdapter.InsertarHistorico(fecha ,dataGridViewPlanificacion.Rows[2].Cells[0].Value.ToString(),Math.Round(energiaAeros[contador]/1000,2),dataGridViewPlanificacion.Rows[2].Cells[2].Value.ToString(),Convert.ToInt16(dataGridViewPlanificacion.Rows[2].Cells[1].Value.ToString()),Convert.ToInt16(aero3[i]));
                contador++;
            }
            string[] aero4 = dataGridViewPlanificacion.Rows[3].Cells[3].Value.ToString().Split('-');

            for (int i = 0; i < aero4.Length - 1; i++)
            {
                //MessageBox.Show(fecha + "-" + dataGridViewPlanificacion.Rows[3].Cells[0].Value.ToString() + "-" + energiaAeros[contador] + "---" + dataGridViewPlanificacion.Rows[3].Cells[2].Value.ToString() + "--" + Convert.ToInt16(dataGridViewPlanificacion.Rows[3].Cells[1].Value.ToString()) + "--" + Convert.ToInt16(aero4[i]));
                this.historicosTableAdapter.InsertarHistorico(fecha, dataGridViewPlanificacion.Rows[3].Cells[0].Value.ToString(),Math.Round(energiaAeros[contador]/1000,2) , dataGridViewPlanificacion.Rows[3].Cells[2].Value.ToString(), Convert.ToInt16(dataGridViewPlanificacion.Rows[3].Cells[1].Value.ToString()),Convert.ToInt16(aero4[i]));
                contador++;
            }
            string[] aero5 = dataGridViewPlanificacion.Rows[4].Cells[3].Value.ToString().Split('-');

            for (int i = 0; i < aero5.Length - 1; i++)
            {
               // MessageBox.Show(fecha + "-" + dataGridViewPlanificacion.Rows[4].Cells[0].Value.ToString() + "-" + energiaAeros[contador] + "---" + dataGridViewPlanificacion.Rows[4].Cells[2].Value.ToString() + "--" + Convert.ToInt16(dataGridViewPlanificacion.Rows[4].Cells[1].Value.ToString()) + "--" + Convert.ToInt16(aero5[i]));
                this.historicosTableAdapter.InsertarHistorico(fecha , dataGridViewPlanificacion.Rows[4].Cells[0].Value.ToString() ,Math.Round(energiaAeros[contador]/1000,2), dataGridViewPlanificacion.Rows[4].Cells[2].Value.ToString() , Convert.ToInt16(dataGridViewPlanificacion.Rows[4].Cells[1].Value.ToString()), Convert.ToInt16(aero5[i]));
                contador++;
            }
            string[] aero6 = dataGridViewPlanificacion.Rows[5].Cells[3].Value.ToString().Split('-');

            for (int i = 0; i < aero6.Length - 1; i++)
            {
                //MessageBox.Show(fecha + "-" + dataGridViewPlanificacion.Rows[5].Cells[0].Value.ToString() + "-" + energiaAeros[contador] + "---" + dataGridViewPlanificacion.Rows[5].Cells[2].Value.ToString() + "--" + Convert.ToInt16(dataGridViewPlanificacion.Rows[5].Cells[1].Value.ToString()) + "--" + Convert.ToInt16(aero6[i]));
                this.historicosTableAdapter.InsertarHistorico(fecha , dataGridViewPlanificacion.Rows[5].Cells[0].Value.ToString(), Math.Round(energiaAeros[contador]/1000,2), dataGridViewPlanificacion.Rows[5].Cells[2].Value.ToString() ,Convert.ToInt16(dataGridViewPlanificacion.Rows[5].Cells[1].Value.ToString()) ,Convert.ToInt16(aero6[i]));
                contador++;
            }
            string[] aero7 = dataGridViewPlanificacion.Rows[6].Cells[3].Value.ToString().Split('-');

            for (int i = 0; i < aero7.Length - 1; i++)
            {
                //MessageBox.Show(fecha + "-" + dataGridViewPlanificacion.Rows[6].Cells[0].Value.ToString() + "-" + energiaAeros[contador] + "---" + dataGridViewPlanificacion.Rows[6].Cells[2].Value.ToString() + "--" + Convert.ToInt16(dataGridViewPlanificacion.Rows[6].Cells[1].Value.ToString()) + "--" + Convert.ToInt16(aero7[i]));
                this.historicosTableAdapter.InsertarHistorico(fecha, dataGridViewPlanificacion.Rows[6].Cells[0].Value.ToString(), Math.Round(energiaAeros[contador]/1000,2), dataGridViewPlanificacion.Rows[6].Cells[2].Value.ToString() , Convert.ToInt16(dataGridViewPlanificacion.Rows[6].Cells[1].Value.ToString()) , Convert.ToInt16(aero7[i]));
                contador++;
            }
            string[] aero8 = dataGridViewPlanificacion.Rows[7].Cells[3].Value.ToString().Split('-');

            for (int i = 0; i < aero8.Length - 1; i++)
            {
                //MessageBox.Show(fecha + "-" + dataGridViewPlanificacion.Rows[7].Cells[0].Value.ToString() + "-" + energiaAeros[contador] + "---" + dataGridViewPlanificacion.Rows[7].Cells[2].Value.ToString() + "--" + Convert.ToInt16(dataGridViewPlanificacion.Rows[7].Cells[1].Value.ToString()) + "--" + Convert.ToInt16(aero8[i]));
                this.historicosTableAdapter.InsertarHistorico(fecha , dataGridViewPlanificacion.Rows[7].Cells[0].Value.ToString(), Math.Round(energiaAeros[contador]/1000,2) , dataGridViewPlanificacion.Rows[7].Cells[2].Value.ToString() , Convert.ToInt16(dataGridViewPlanificacion.Rows[7].Cells[1].Value.ToString()), Convert.ToInt16(aero8[i]));
                contador++;
            }

                
        }

        private void ExportarExcelPlanificacion()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int ColumnIndex = 0;
            foreach (DataGridViewColumn col in dataGridViewPlanificacion.Columns)
            {
                ColumnIndex++;
                excel.Cells[1, ColumnIndex] = col.Name;
            }
            int rowIndex = 0;
            foreach (DataGridViewRow row in dataGridViewPlanificacion.Rows)
            {
                rowIndex++;
                ColumnIndex = 0;
                foreach (DataGridViewColumn col in dataGridViewPlanificacion.Columns)
                {
                    ColumnIndex++;
                    excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;

                }

            }
            excel.Visible = true;
            Worksheet worksheet = (Worksheet)excel.ActiveSheet;
            worksheet.Activate();
        
        }

        private void verHistoricosAerogeneradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoricosAerogeneradores historicos_aeros = new FormHistoricosAerogeneradores();
            historicos_aeros.ShowDialog();
        }

        private void rosaDeLosVientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRosaVientos rosa = new FormRosaVientos();
            rosa.Show();
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("C://MU.pdf");
        }

        private void configurarMetaAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMeta meta = new FormMeta();
            meta.ShowDialog();
        }

        
       

    }
}
