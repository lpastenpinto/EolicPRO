using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimizacionVientos
{
    class Penalizacion
    {
        public double Valor_Pertenencia(double x, double meta)
        {
            if (x < meta)
            {
                //   Console.WriteLine("Funcion Gauss");
                double k = 0.2;
                double valor_pertenencia = (1 - Funcion_Gaussiana(k, x, meta));
                return valor_pertenencia;
            }
            else
            {
                //   Console.WriteLine("Funcion Z");
                double b = meta * 1.4;  //1.4 VALOR A CAMBIAR ????
                double valor_pertenencia = (1 - Funcion_Z(meta, b, x));
                return valor_pertenencia;
            }
        }



        public double Funcion_Gaussiana(double k, double x, double m)
        {

            double e = Math.E;
            double potencia = -k * Math.Pow((x - m), 2);
            double valor_pertenencia = Math.Pow(e, potencia);
            return valor_pertenencia;
        }




        public double Funcion_Z(double a, double b, double x)
        {

            if (x <= a)
            {
                return 1;
            }
            else if ((a < x) && (x < (a + b) / 2))
            {
                double parentesis = (x - a) / (a - b);
                return 1 - 2 * Math.Pow(parentesis, 2);
            }
            else if (((a + b) / 2 <= x) && (x < b))
            {

                double parentesis = (b - x) / (a - b);
                return 2 * Math.Pow(parentesis, 2);
            }
            else
            {
                return 0;
            }

        }

    }
}
