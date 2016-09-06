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
    public partial class FormPareto : Form
    {
        double energia_a_producir;
        
        List<int> listaTraeVelocidad = new List<int>();

        public FormPareto(double p, List<int> listaVelocidad)
        {
            energia_a_producir = p;
            listaTraeVelocidad = listaVelocidad;
            InitializeComponent();
            labelEnergia.Text = Convert.ToString(p);
            agregarVelocidades();
            CambiarValoresPareto();

            
        }



        private void agregarVelocidades()
        {
            textBoxVelocidad1.Text = Convert.ToString(listaTraeVelocidad[0]);
            textBoxVelocidad2.Text = Convert.ToString(listaTraeVelocidad[1]);
            textBoxVelocidad3.Text = Convert.ToString(listaTraeVelocidad[2]);
            textBoxVelocidad4.Text = Convert.ToString(listaTraeVelocidad[3]);
            textBoxVelocidad5.Text = Convert.ToString(listaTraeVelocidad[4]);
            textBoxVelocidad6.Text = Convert.ToString(listaTraeVelocidad[5]);
            textBoxVelocidad7.Text = Convert.ToString(listaTraeVelocidad[6]);
            textBoxVelocidad8.Text = Convert.ToString(listaTraeVelocidad[7]);
        }

       
        

        private void pareto_tramoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pareto_tramoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vientosDataSet);

        }

        private void FormPareto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vientosDataSet.pareto_tramo' Puede moverla o quitarla según sea necesario.
            this.pareto_tramoTableAdapter.Fill(this.vientosDataSet.pareto_tramo);

            textBoxTramo1.Text = dataGridViewPareto.Rows[0].Cells[1].Value.ToString();
            textBoxTramo2.Text = dataGridViewPareto.Rows[1].Cells[1].Value.ToString();
            textBoxTramo3.Text = dataGridViewPareto.Rows[2].Cells[1].Value.ToString();
            textBoxTramo4.Text = dataGridViewPareto.Rows[3].Cells[1].Value.ToString();
            textBoxTramo5.Text = dataGridViewPareto.Rows[4].Cells[1].Value.ToString();
            textBoxTramo6.Text = dataGridViewPareto.Rows[5].Cells[1].Value.ToString();
            textBoxTramo7.Text = dataGridViewPareto.Rows[6].Cells[1].Value.ToString();
            textBoxTramo8.Text = dataGridViewPareto.Rows[7].Cells[1].Value.ToString();

        }




        private void textBoxTramo1_KeyPress(object sender, KeyPressEventArgs e)
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




        private void CambiarValoresPareto()
        {
            
            try
                {
                    if (Convert.ToDouble(textBoxTramo1.Text) > 100 || Convert.ToDouble(textBoxTramo2.Text) > 100 || Convert.ToDouble(textBoxTramo3.Text) > 100 || Convert.ToDouble(textBoxTramo4.Text) > 100 || Convert.ToDouble(textBoxTramo5.Text) > 100 || Convert.ToDouble(textBoxTramo6.Text) > 100 || Convert.ToDouble(textBoxTramo7.Text) > 100 || Convert.ToDouble(textBoxTramo8.Text) > 100)
                    {
                        MessageBox.Show("No puede ser mayor a 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                
                    double tramo1 = Convert.ToDouble(textBoxTramo1.Text);
                    double tramo2 = Convert.ToDouble(textBoxTramo2.Text);
                    double tramo3 = Convert.ToDouble(textBoxTramo3.Text);
                    double tramo4 = Convert.ToDouble(textBoxTramo4.Text);
                    double tramo5 = Convert.ToDouble(textBoxTramo5.Text);
                    double tramo6 = Convert.ToDouble(textBoxTramo6.Text);
                    double tramo7 = Convert.ToDouble(textBoxTramo7.Text);
                    double tramo8 = Convert.ToDouble(textBoxTramo8.Text);

                    double suma = tramo1 + tramo2 + tramo3 + tramo4 + tramo5 + tramo6 + tramo7 + tramo8;
                    //MessageBox.Show(""+energia_a_producir);
                    //MessageBox.Show("Suma completa"+ suma);
                    textBoxEtramo1.Text = Convert.ToString(Math.Round(((energia_a_producir * (tramo1 * 100) / suma) / 100), 2));
                    textBoxEtramo2.Text = Convert.ToString(Math.Round(((energia_a_producir * (tramo2 * 100) / suma) / 100), 2));
                    textBoxEtramo3.Text = Convert.ToString(Math.Round(((energia_a_producir * (tramo3 * 100) / suma) / 100), 2));
                    textBoxEtramo4.Text = Convert.ToString(Math.Round(((energia_a_producir * (tramo4 * 100) / suma) / 100), 2));
                    textBoxEtramo5.Text = Convert.ToString(Math.Round(((energia_a_producir * (tramo5 * 100) / suma) / 100), 2));
                    textBoxEtramo6.Text = Convert.ToString(Math.Round(((energia_a_producir * (tramo6 * 100) / suma) / 100), 2));
                    textBoxEtramo7.Text = Convert.ToString(Math.Round(((energia_a_producir * (tramo7 * 100) / suma) / 100), 2));
                    textBoxEtramo8.Text = Convert.ToString(Math.Round(((energia_a_producir * (tramo8 * 100) / suma) / 100), 2));
                }
            }
                catch 
                {

                }


            }
        

        private void textBoxTramo2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxTramo3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxTramo4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxTramo5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxTramo6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxTramo7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxTramo8_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FormPareto_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            { e.Handled = false; }
            else { e.Handled = true; } 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBoxTramo1.Text) > 100 || Convert.ToDouble(textBoxTramo2.Text) > 100 || Convert.ToDouble(textBoxTramo3.Text) > 100 || Convert.ToDouble(textBoxTramo4.Text) > 100 || Convert.ToDouble(textBoxTramo5.Text) > 100 || Convert.ToDouble(textBoxTramo6.Text) > 100 || Convert.ToDouble(textBoxTramo7.Text) > 100 || Convert.ToDouble(textBoxTramo8.Text) > 100)
            {
                MessageBox.Show("Ingrese Correctamente los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                
                this.pareto_tramoTableAdapter.ActualizarPareto(Convert.ToDouble(textBoxTramo1.Text), "2:01-5:00");
                this.pareto_tramoTableAdapter.ActualizarPareto(Convert.ToDouble(textBoxTramo2.Text), "5:01-8:00");
                this.pareto_tramoTableAdapter.ActualizarPareto(Convert.ToDouble(textBoxTramo3.Text), "8:01-11:00");
                this.pareto_tramoTableAdapter.ActualizarPareto(Convert.ToDouble(textBoxTramo4.Text), "11:01-14:00");
                this.pareto_tramoTableAdapter.ActualizarPareto(Convert.ToDouble(textBoxTramo5.Text), "14:01-17:00");
                this.pareto_tramoTableAdapter.ActualizarPareto(Convert.ToDouble(textBoxTramo6.Text), "17:01-20:00");
                this.pareto_tramoTableAdapter.ActualizarPareto(Convert.ToDouble(textBoxTramo7.Text), "20:01-23:00");
                this.pareto_tramoTableAdapter.ActualizarPareto(Convert.ToDouble(textBoxTramo8.Text), "23:01-02:00");
                MessageBox.Show("Se actualizaron los porcentajes","Actualización",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
                
            }
        }





        private void textBoxTramo1_TextChanged(object sender, EventArgs e)
        {
            CambiarValoresPareto();
        }

        private void textBoxTramo2_TextChanged(object sender, EventArgs e)
        {
            CambiarValoresPareto();
        }

        private void textBoxTramo3_TextChanged(object sender, EventArgs e)
        {
            CambiarValoresPareto();
        }

        private void textBoxTramo4_TextChanged(object sender, EventArgs e)
        {
            CambiarValoresPareto();
        }

        private void textBoxTramo5_TextChanged(object sender, EventArgs e)
        {
            CambiarValoresPareto();
        }

        private void textBoxTramo6_TextChanged(object sender, EventArgs e)
        {
            CambiarValoresPareto();
        }

        private void textBoxTramo7_TextChanged(object sender, EventArgs e)
        {
            CambiarValoresPareto();
        }

        private void textBoxTramo8_TextChanged(object sender, EventArgs e)
        {
            CambiarValoresPareto();
        }

        
    }
}
