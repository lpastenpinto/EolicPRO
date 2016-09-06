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
    public partial class FormTomaDatosViento : Form
    {
        public FormTomaDatosViento()
        {
            InitializeComponent();
            webBrowserTomaDatos.Navigate("http://es.windfinder.com/forecast/puerto_aldea");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxVelocidadTramo1.Text == "" || textBoxVelocidadTramo2.Text == "" || textBoxVelocidadTramo3.Text == "" || textBoxVelocidadTramo4.Text == "" || textBoxVelocidadTramo5.Text == "" || textBoxVelocidadTramo6.Text == "" || textBoxVelocidadTramo7.Text == "" || textBoxVelocidadTramo8.Text == "")
            {

                MessageBox.Show("Debe ingresar todos los datos", "Error Ingreso datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Insertar();
                MessageBox.Show("Datos Ingresados Correctamente", "Ingreso Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }



        private void Insertar()
        {
            DateTime manana = DateTime.Today.AddDays(1);
            string fecha = manana.ToString("dd-MM-yyyy");

            this.historicos_climaTableAdapter.Insertar(fecha, "2:01-5:00", comboBoxTramo1.Text, Convert.ToInt16(textBoxVelocidadTramo1.Text));
            this.historicos_climaTableAdapter.Insertar(fecha, "5:01-8:00", comboBoxTramo2.Text, Convert.ToInt16(textBoxVelocidadTramo2.Text));
            this.historicos_climaTableAdapter.Insertar(fecha, "8:01-11:00", comboBoxTramo3.Text, Convert.ToInt16(textBoxVelocidadTramo3.Text));
            this.historicos_climaTableAdapter.Insertar(fecha, "11:01-14:00", comboBoxTramo4.Text, Convert.ToInt16(textBoxVelocidadTramo4.Text));
            this.historicos_climaTableAdapter.Insertar(fecha, "14:01-17:00", comboBoxTramo5.Text, Convert.ToInt16(textBoxVelocidadTramo5.Text));
            this.historicos_climaTableAdapter.Insertar(fecha, "17:01-20:00", comboBoxTramo6.Text, Convert.ToInt16(textBoxVelocidadTramo6.Text));
            this.historicos_climaTableAdapter.Insertar(fecha, "20:01-23:00", comboBoxTramo7.Text, Convert.ToInt16(textBoxVelocidadTramo7.Text));
            this.historicos_climaTableAdapter.Insertar(fecha, "23:01-2:00", comboBoxTramo8.Text, Convert.ToInt16(textBoxVelocidadTramo8.Text));
            
            //Generar nueva instancia de Principal.
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        
        }

        private void FormTomaDatosViento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vientosDataSet.Historicos_clima' Puede moverla o quitarla según sea necesario.
            this.historicos_climaTableAdapter.Fill(this.vientosDataSet.Historicos_clima);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRosaVientos rosa = new FormRosaVientos();
            rosa.Show();
        }

        private void textBoxVelocidadTramo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar)){e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {   e.Handled = false;}
                else {e.Handled = true;} 
        }

        private void textBoxVelocidadTramo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            { e.Handled = false; }
            else { e.Handled = true; } 
        }

        private void textBoxVelocidadTramo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            { e.Handled = false; }
            else { e.Handled = true; } 
        }

        private void textBoxVelocidadTramo4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            { e.Handled = false; }
            else { e.Handled = true; } 
        }

        private void textBoxVelocidadTramo5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            { e.Handled = false; }
            else { e.Handled = true; } 
        }

        private void textBoxVelocidadTramo6_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            { e.Handled = false; }
            else { e.Handled = true; } 
        }

        private void textBoxVelocidadTramo7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            { e.Handled = false; }
            else { e.Handled = true; } 
        }

        private void textBoxVelocidadTramo8_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            { e.Handled = false; }
            else { e.Handled = true; } 
        }

       

       



      
        


    }
}
