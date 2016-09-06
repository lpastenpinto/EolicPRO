using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimizacionVientos
{
    class Calculo_Produccion_Energia
    {
        //se aplica a cada aerogenerador con 1
        public double Calculo_Produccion_Energia_Libre(double velocidad_viento)
        {

            double Velocidad_de_Viento_de_Conexion = 3;
            double Potencial_Nominal = 12;
            double m = (Velocidad_de_Viento_de_Conexion + Potencial_Nominal) / 2;

            if ((velocidad_viento <= 3) || (velocidad_viento >= 25))
            {
                return 0;
            }
            else
            {
                if (velocidad_viento <= Velocidad_de_Viento_de_Conexion)
                {
                    return 0;
                }
                else if ((Velocidad_de_Viento_de_Conexion < velocidad_viento) && (velocidad_viento <= m))
                {
                    double parentesis = (velocidad_viento - Velocidad_de_Viento_de_Conexion) / (Potencial_Nominal - Velocidad_de_Viento_de_Conexion);
                    double resultado = 2 * Math.Pow(parentesis, 2);
                    return resultado * 2300;
                }
                else if ((m < velocidad_viento) && (velocidad_viento < Potencial_Nominal))
                {
                    double parentesis = (velocidad_viento - Potencial_Nominal) / (Potencial_Nominal - Velocidad_de_Viento_de_Conexion);
                    double resultado = 1 - 2 * Math.Pow(parentesis, 2);
                    return resultado * 2300;

                }
                else
                {
                    return 2300;
                }
            }
        }


        public double Calculo_Produccion_Energia_Bruta(double energia_libre)
        {
            return 0;
        }


        //se aplica a todo el resultado final antes de asignar fitness
        public double Calculo_Produccion_Energia_Neta(double energia_bruta)
        {

            double factor_perdida_disponibilidad = 0.01;
            double factor_perdida_garantia_curva_potencia = 0.04;
            double factor_perdida_electricas = 0.02;
            double factor_perdida_desgaste_palas = 0.005;
            double factor_perdida_histeresis = 0.005;
            double factor_perdida_otros = 0.01;

            double energia_neta;

            energia_neta = energia_bruta - (energia_bruta * factor_perdida_desgaste_palas);
            energia_neta = energia_neta - (energia_bruta * factor_perdida_disponibilidad);
            energia_neta = energia_neta - (energia_bruta * factor_perdida_electricas);
            energia_neta = energia_neta - (energia_bruta * factor_perdida_garantia_curva_potencia);
            energia_neta = energia_neta - (energia_bruta * factor_perdida_histeresis);
            energia_neta = energia_neta - (energia_bruta * factor_perdida_otros);

            return energia_neta;
        }



        public double Calculo_Perfil_Vertical_Viento(double velocidad_referencia, double altura_referencia, double altura_sobre_nivel_suelo)
        {

            double factor_rugosidad = 0.03;
            //v = v ref ln(z/z 0 ) / ln(z ref /z 0 )=
            double parentesis = Math.Log(altura_sobre_nivel_suelo / factor_rugosidad) / Math.Log(altura_referencia / factor_rugosidad);
            //Math.Log(argX)
            return velocidad_referencia * parentesis;
        }


        public double Calculo_Efecto_Estela(double velocidad_viento_aerogenerador_1, double altura_aerogenerador_1, double altura_aerogenerador_2)
        {

            double factor_rugosidad = 0.03;
            double constante_caida_estela = 0.5 / Math.Log(altura_aerogenerador_2 / factor_rugosidad);
            double parentesis = altura_aerogenerador_2 / altura_aerogenerador_1;
            //Math.Pow(
            return velocidad_viento_aerogenerador_1 * Math.Pow(parentesis, constante_caida_estela);
        }


        public double Calculo_Produccion_Individuo()
        {


            return 0;
        }
    }
}
