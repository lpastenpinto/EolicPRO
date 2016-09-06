using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimizacionVientos
{
    class AG
    {
        double[] Altura_Aerogeneradores;
        int[] Efecto_Estela_Aerogenerador_1;
        int[] Efecto_Estela_Aerogenerador_2;
        int Cantidad_Genes = 44;  //44
        int[,] Poblacion;
        int[,] Poblacion_Intermedia;
        int Tamaño_Poblacion_inicial;
        int[] Indices_Poblacion_Seleccionada;
        int[] Indices_Correlativos_Poblacion_Elit;
        double[] Fitness;
        int[] Indices_Ordenados_por_Fitness;
        double Meta_Produccion_a_Cumplir;
        double[] Produccion_de_Individuos;
        double[] Velocidad_Viento_General;


        public void Determinar_Efecto_Estela_Activos(string direccion_viento)
        {
            string[,] matriz_temporal;
            Excel matriz = new Excel();
            matriz_temporal = matriz.cargar_Efecto_Estela();

            int indice = 0;
            for (int x = 0; x < 66; x++)
            {
                if (matriz_temporal[x, 1].Equals(direccion_viento))
                {
                    indice++;
                }
            }

            Efecto_Estela_Aerogenerador_1 = new int[indice];
            Efecto_Estela_Aerogenerador_2 = new int[indice];

            int index = 0;
            for (int x = 0; x < 66; x++)
            {
                if (matriz_temporal[x, 1].Equals(direccion_viento))
                {
                    Efecto_Estela_Aerogenerador_1[index] = Convert.ToInt32(matriz_temporal[x, 0]);
                    Efecto_Estela_Aerogenerador_2[index] = Convert.ToInt32(matriz_temporal[x, 2]);
                    index++;
                }
            }
        }



        public void Creacion_Poblacion_Inicial(List<int> Aerogeneradores_No_Disponible, int Tamaño_Poblacion, string direccion_del_viento, double velocidad_viento, double[] Matriz_Altura_aerogeneradores, double Meta)
        {

            Indices_Poblacion_Seleccionada = new int[(Tamaño_Poblacion / 2) + 1];
            Poblacion = new int[Tamaño_Poblacion, Cantidad_Genes];
            Poblacion_Intermedia = new int[Tamaño_Poblacion, Cantidad_Genes];
            Fitness = new double[Tamaño_Poblacion];
            Indices_Correlativos_Poblacion_Elit = new int[Tamaño_Poblacion];
            Indices_Ordenados_por_Fitness = new int[Tamaño_Poblacion];
            Altura_Aerogeneradores = Matriz_Altura_aerogeneradores;
            Meta_Produccion_a_Cumplir = Meta;
            Produccion_de_Individuos = new double[Tamaño_Poblacion];
            Velocidad_Viento_General = new double[44];
            Random Valor_Gen = new Random();
            Random probabilidad = new Random();

            Determinar_Efecto_Estela_Activos(direccion_del_viento);

            Tamaño_Poblacion_inicial = Tamaño_Poblacion;


            Calculo_Produccion_Energia calculo = new Calculo_Produccion_Energia();
            for (int x = 0; x < 44; x++)
            {
                Velocidad_Viento_General[x] = calculo.Calculo_Perfil_Vertical_Viento(velocidad_viento, 100, Altura_Aerogeneradores[x]);

            }


            for (int x = 0; x < Tamaño_Poblacion; x++)
            {
                //double produccion_individuo=0;
                //while (produccion_individuo < Meta)
                //{ 

                double probabilidad_gen_1 = 70;

                for (int y = 0; y < Cantidad_Genes; y++)
                {
                    if (!Aerogeneradores_No_Disponible.Contains(y))
                    {
                        double numero_aleatorio = probabilidad.Next(0, 101);

                        if (numero_aleatorio <= probabilidad_gen_1)
                        {
                            Poblacion[x, y] = 1;
                            //Poblacion[x, y] = Valor_Gen.Next(0, 2);
                        }
                        else
                        {
                            Poblacion[x, y] = 0;
                        }
                    }
                    else
                    {

                        Poblacion[x, y] = 0;
                    }
                }
                //  produccion_individuo=Asignacion_Fitness_Individuo(velocidad_viento,x);

                //}
                //Console.WriteLine("Prod" + produccion_individuo);
                Indices_Correlativos_Poblacion_Elit[x] = x; //llenar con indices correlativos para operador Elitismo

            }


        }



        /*public void Asignacion_Fitness_Cada_Individuo() {

            int fitness = 0;
            for (int x = 0; x < Tamaño_Poblacion_inicial; x++)
            {
                fitness = 0;
                for (int y = 0; y < Cantidad_Genes; y++)
                {
                    fitness = fitness + Poblacion[x, y] * 1;
                    if (Poblacion[x, y].Equals(1))
                    {

                    }

                }
                Fitness[x] = fitness;
                Indices_Correlativos_Poblacion_Elit[x] = x;
                fitness = 0;
            }  
        }

        */


        public double Asignacion_Fitness_Individuo(double velocidad_del_viento, int x)
        {

            Calculo_Produccion_Energia Calculo_produccion_individuo = new Calculo_Produccion_Energia();
            double[] Velocidad_Viento_Cada_Individuo = (double[])Velocidad_Viento_General.Clone();
            double fitness = 0;
            double Produccion_Energia_Individuo = 0;
            for (int y = 0; y < Cantidad_Genes; y++)
            {
                fitness = fitness + Poblacion[x, y] * 1;

                if (Poblacion[x, y].Equals(1))
                {

                    bool verifica_estela = Efecto_Estela_Aerogenerador_2.Contains(y);
                    if (verifica_estela.Equals(true))
                    {
                        int indice_aerogenerador_1 = 0;
                        int indice_aerogenerador_2 = 0;
                        for (int z = 0; z < Efecto_Estela_Aerogenerador_2.Length; z++)
                        {
                            if (Efecto_Estela_Aerogenerador_2[z].Equals(y))
                            {
                                indice_aerogenerador_1 = Efecto_Estela_Aerogenerador_1[z] - 1;
                                indice_aerogenerador_2 = Efecto_Estela_Aerogenerador_2[z] - 1;
                            }
                        }

                        if (Poblacion[x, indice_aerogenerador_1].Equals(1))
                        {
                            //ACA SE VE EFECTO ESTELA
                            double altura_aerogenerador_1 = Altura_Aerogeneradores[indice_aerogenerador_1];
                            double altura_aerogenerador_2 = Altura_Aerogeneradores[indice_aerogenerador_2];
                            double velocidad_viento_aerogenerador_1 = Velocidad_Viento_Cada_Individuo[2];

                            double velocidad_viento_aerogenerador_2 = Calculo_produccion_individuo.Calculo_Efecto_Estela(velocidad_viento_aerogenerador_1, altura_aerogenerador_1, altura_aerogenerador_2);
                            Velocidad_Viento_Cada_Individuo[y] = velocidad_viento_aerogenerador_2;

                            Produccion_Energia_Individuo = Produccion_Energia_Individuo + Calculo_produccion_individuo.Calculo_Produccion_Energia_Libre(velocidad_viento_aerogenerador_2);

                        }
                        else
                        {

                            Produccion_Energia_Individuo = Produccion_Energia_Individuo + Calculo_produccion_individuo.Calculo_Produccion_Energia_Libre(velocidad_del_viento);

                        }
                    }
                    else
                    {

                        Produccion_Energia_Individuo = Produccion_Energia_Individuo + Calculo_produccion_individuo.Calculo_Produccion_Energia_Libre(velocidad_del_viento);
                    }
                }

            }


            Produccion_Energia_Individuo = Calculo_produccion_individuo.Calculo_Produccion_Energia_Neta(Produccion_Energia_Individuo);
            Produccion_Energia_Individuo = Produccion_Energia_Individuo / 1000;

            return Produccion_Energia_Individuo;

        }



        public void Asignacion_Fitness_Poblacion(double velocidad_del_viento)
        {

            Calculo_Produccion_Energia Calculo_produccion = new Calculo_Produccion_Energia();

            double Produccion_Energia_Individuo = 0;
            double[] Velocidad_Viento_Individuo;

            int fitness = 0;

            for (int x = 0; x < Tamaño_Poblacion_inicial; x++)
            {
                Velocidad_Viento_Individuo = (double[])Velocidad_Viento_General.Clone();
                fitness = 0;
                Produccion_Energia_Individuo = 0;
                for (int y = 0; y < Cantidad_Genes; y++)
                {
                    fitness = fitness + Poblacion[x, y] * 1;

                    if (Poblacion[x, y].Equals(1))
                    {

                        bool verifica_estela = Efecto_Estela_Aerogenerador_2.Contains(y);
                        if (verifica_estela.Equals(true))
                        {
                            int indice_aerogenerador_1 = 0;
                            int indice_aerogenerador_2 = 0;
                            for (int z = 0; z < Efecto_Estela_Aerogenerador_2.Length; z++)
                            {
                                if (Efecto_Estela_Aerogenerador_2[z].Equals(y))
                                {
                                    indice_aerogenerador_1 = Efecto_Estela_Aerogenerador_1[z] - 1;
                                    indice_aerogenerador_2 = Efecto_Estela_Aerogenerador_2[z] - 1;
                                }
                            }

                            if (Poblacion[x, indice_aerogenerador_1].Equals(1))
                            {
                                //ACA SE VE EFECTO ESTELA

                                double altura_aerogenerador_1 = Altura_Aerogeneradores[indice_aerogenerador_1];
                                double altura_aerogenerador_2 = Altura_Aerogeneradores[indice_aerogenerador_2];
                                double velocidad_viento_aerogenerador_1 = Velocidad_Viento_Individuo[2];

                                double velocidad_viento_aerogenerador_2 = Calculo_produccion.Calculo_Efecto_Estela(velocidad_viento_aerogenerador_1, altura_aerogenerador_1, altura_aerogenerador_2);
                                Velocidad_Viento_Individuo[y] = velocidad_viento_aerogenerador_2;

                                Produccion_Energia_Individuo = Produccion_Energia_Individuo + Calculo_produccion.Calculo_Produccion_Energia_Libre(velocidad_viento_aerogenerador_2);

                            }
                            else
                            {

                                Produccion_Energia_Individuo = Produccion_Energia_Individuo + Calculo_produccion.Calculo_Produccion_Energia_Libre(Velocidad_Viento_Individuo[y]);

                            }

                        }
                        else
                        {
                            Produccion_Energia_Individuo = Produccion_Energia_Individuo + Calculo_produccion.Calculo_Produccion_Energia_Libre(Velocidad_Viento_Individuo[y]);
                        }
                    }

                }


                Produccion_Energia_Individuo = Calculo_produccion.Calculo_Produccion_Energia_Neta(Produccion_Energia_Individuo);
                Produccion_Energia_Individuo = Produccion_Energia_Individuo / 1000;

                Produccion_de_Individuos[x] = Produccion_Energia_Individuo;

                Penalizacion penalizacion = new Penalizacion();
                double penalizacion_individuo = penalizacion.Valor_Pertenencia(Produccion_Energia_Individuo, Meta_Produccion_a_Cumplir);

                Fitness[x] = fitness + (penalizacion_individuo * 100);
                Indices_Correlativos_Poblacion_Elit[x] = x;
                fitness = 0;
            }
        }



        public void Seleccion()
        {

            double probabilidad_de_ganar_mayor_fitness = 0.3;     //cambiar dependiendo de maximizar o minimizar        

            double valor_fitness_1;
            double valor_fitness_2;

            int indice_individuo_1;
            int indice_individuo_2;
            int indice_individuo_mayor;
            int indice_individuo_menor;
            int indice_individuo_seleccionado;

            Random rand = new Random();

            for (int x = 0; x < (Tamaño_Poblacion_inicial / 2) + 1; x++)
            {

                indice_individuo_1 = rand.Next(0, Tamaño_Poblacion_inicial);
                valor_fitness_1 = Fitness[indice_individuo_1];

                indice_individuo_2 = rand.Next(0, Tamaño_Poblacion_inicial); //Next. Numeros entre 0 y limite
                valor_fitness_2 = Fitness[indice_individuo_2];

                double probabilidad_seleccion = rand.NextDouble(); //NextDouble numeros entre 0 y 1 doubles.                

                if (valor_fitness_1 > valor_fitness_2)
                {
                    indice_individuo_mayor = indice_individuo_1;
                    indice_individuo_menor = indice_individuo_2;
                }
                else
                {
                    indice_individuo_mayor = indice_individuo_2;
                    indice_individuo_menor = indice_individuo_1;
                }


                if (probabilidad_seleccion <= probabilidad_de_ganar_mayor_fitness)
                {
                    indice_individuo_seleccionado = indice_individuo_mayor;
                }
                else
                {
                    indice_individuo_seleccionado = indice_individuo_menor;
                }
                Indices_Poblacion_Seleccionada[x] = indice_individuo_seleccionado;

            }

        }




        public void Cruce(int probabilidad_cruce)
        {
            Random rand = new Random();
            int indice_padre_1;
            int indice_padre_2;

            int indice_punto_corte_1 = 3;
            int indice_punto_corte_2 = 7;

            int indice = 0; //netamente para que sea de 2 en 2 la proxima generacion  25/100 * 1000 = 250


            for (int x = 0; x < (Indices_Poblacion_Seleccionada.Length) * probabilidad_cruce / 100; x++) //95/100
            {
                indice_padre_1 = Indices_Poblacion_Seleccionada[rand.Next(0, Indices_Poblacion_Seleccionada.Length)];
                indice_padre_2 = Indices_Poblacion_Seleccionada[rand.Next(0, Indices_Poblacion_Seleccionada.Length)];

                for (int y = 0; y < indice_punto_corte_1; y++)
                {
                    Poblacion_Intermedia[indice, y] = Poblacion[indice_padre_1, y];
                    Poblacion_Intermedia[indice + 1, y] = Poblacion[indice_padre_2, y];

                }
                for (int z = indice_punto_corte_1; z < indice_punto_corte_2; z++)
                {
                    Poblacion_Intermedia[indice, z] = Poblacion[indice_padre_2, z];
                    Poblacion_Intermedia[indice + 1, z] = Poblacion[indice_padre_1, z];
                }
                for (int w = indice_punto_corte_2; w < Cantidad_Genes; w++)
                {
                    Poblacion_Intermedia[indice, w] = Poblacion[indice_padre_1, w];
                    Poblacion_Intermedia[indice + 1, w] = Poblacion[indice_padre_2, w];
                }

                indice = indice + 2;
            }
        }



        public void Cruce(int probabilidad_cruce, int indice_punto_corte_1, int indice_punto_corte_2)
        {
            Random rand = new Random();
            int indice_padre_1;
            int indice_padre_2;

            int indice = 0; //netamente para que sea de 2 en 2 la proxima generacion  25/100 * 1000 = 250
            int cantidad_total_individuos_Poblacion_Intermedia = Tamaño_Poblacion_inicial * 95 / 100;
            int cantidad_actual_individuos_Poblacion_Intermedia = 0;

            while (cantidad_actual_individuos_Poblacion_Intermedia < cantidad_total_individuos_Poblacion_Intermedia)
            {

                indice_padre_1 = Indices_Poblacion_Seleccionada[rand.Next(0, Indices_Poblacion_Seleccionada.Length)];
                indice_padre_2 = Indices_Poblacion_Seleccionada[rand.Next(0, Indices_Poblacion_Seleccionada.Length)];

                double numero_aleatorio = rand.Next(0, 101);

                if (numero_aleatorio <= probabilidad_cruce)
                {

                    for (int y = 0; y < indice_punto_corte_1; y++)
                    {

                        Poblacion_Intermedia[indice, y] = Poblacion[indice_padre_1, y];
                        Poblacion_Intermedia[indice + 1, y] = Poblacion[indice_padre_2, y];

                    }
                    for (int z = indice_punto_corte_1; z < indice_punto_corte_2; z++)
                    {
                        Poblacion_Intermedia[indice, z] = Poblacion[indice_padre_2, z];
                        Poblacion_Intermedia[indice + 1, z] = Poblacion[indice_padre_1, z];
                    }
                    for (int w = indice_punto_corte_2; w < Cantidad_Genes; w++)
                    {
                        Poblacion_Intermedia[indice, w] = Poblacion[indice_padre_1, w];
                        Poblacion_Intermedia[indice + 1, w] = Poblacion[indice_padre_2, w];
                    }

                    indice = indice + 2;
                    cantidad_actual_individuos_Poblacion_Intermedia = cantidad_actual_individuos_Poblacion_Intermedia + 2;
                }

            }
        }


        public void Mutacion(List<int> Aerogeneradores_No_Disponibles)
        {

            int numero_mutacion = 5; //CUALQUIER NUMERO ENTRE 1 Y 100 SIRVE /PROB 1%
            int numero_aleatorio;
            Random rand = new Random();

            for (int x = 0; x < Tamaño_Poblacion_inicial; x++)
            {
                numero_aleatorio = rand.Next(0, 101);
                if (numero_mutacion.Equals(numero_aleatorio))
                {

                    int cantidad_genes_a_cambiar = rand.Next(1, 6);

                    for (int y = 0; y < cantidad_genes_a_cambiar; y++)
                    {

                        int indice_gen_mutar = rand.Next(0, Cantidad_Genes);

                        if (!Aerogeneradores_No_Disponibles.Contains(indice_gen_mutar))
                        {
                            if (Poblacion_Intermedia[x, indice_gen_mutar].Equals(0))
                            {
                                Poblacion_Intermedia[x, indice_gen_mutar] = 1;
                            }
                            else
                            {
                                Poblacion_Intermedia[x, indice_gen_mutar] = 0;
                            }
                        }
                    }
                }
            }

        }


        public void Elitismo_Maximizar(int probabilidad_cruce)
        {

            Indices_Ordenados_por_Fitness = null;
            Indices_Ordenados_por_Fitness = Indices_Correlativos_Poblacion_Elit;
            Array.Sort(Fitness, Indices_Ordenados_por_Fitness); //Orden menor a mayor

            double Diferencia_probabilidad_cruce = 1 - ((double)probabilidad_cruce / 100);
            int Cantidad_individuos_Elit = Convert.ToInt32(Math.Ceiling(Diferencia_probabilidad_cruce * Tamaño_Poblacion_inicial));


            for (int x = 0; x < Cantidad_individuos_Elit; x++)
            {

                int indice = Indices_Ordenados_por_Fitness[Tamaño_Poblacion_inicial - 1 - x];

                for (int y = 0; y < Cantidad_Genes; y++)
                {

                    Poblacion_Intermedia[Tamaño_Poblacion_inicial - 1 - x, y] = Poblacion[indice, y];

                }
            }
        }




        public void Elitismo_Minimizar(int probabilidad_cruce)
        {

            Indices_Ordenados_por_Fitness = null;
            Indices_Ordenados_por_Fitness = Indices_Correlativos_Poblacion_Elit;
            Array.Sort(Fitness, Indices_Ordenados_por_Fitness); //Orden menor a mayor               

            double Diferencia_probabilidad_cruce = 1 - ((double)probabilidad_cruce / 100);
            int Cantidad_individuos_Elit = Convert.ToInt32(Math.Ceiling(Diferencia_probabilidad_cruce * Tamaño_Poblacion_inicial));


            for (int x = 0; x < Cantidad_individuos_Elit; x++)
            {

                int indice = Indices_Ordenados_por_Fitness[x];

                for (int y = 0; y < Cantidad_Genes; y++)
                {

                    Poblacion_Intermedia[Tamaño_Poblacion_inicial - 1 - x, y] = Poblacion[indice, y];

                }

            }
        }



        public void Reemplazo_Generacion()
        {

            Poblacion = (int[,])Poblacion_Intermedia.Clone();


        }


        public double Comprobar_Convergencia_Poblacion(double porcentaje_ideal_convergencia)
        {
            double cantidad_0 = 0;
            double cantidad_1 = 0;
            for (int x = 0; x < Cantidad_Genes; x++)
            {
                for (int y = 0; y < Tamaño_Poblacion_inicial - 1; y++)
                {

                    if (Poblacion[y, x].Equals(0))
                    {
                        cantidad_0 = cantidad_0 + 1;
                    }
                    else
                    {
                        cantidad_1 = cantidad_1 + 1;
                    }

                }

                double porcentaje_0s_enPoblacion = cantidad_0 / Tamaño_Poblacion_inicial;
                double porcentaje_1s_enPoblacion = cantidad_1 / Tamaño_Poblacion_inicial;

                if ((porcentaje_0s_enPoblacion < porcentaje_ideal_convergencia) && (porcentaje_1s_enPoblacion < porcentaje_ideal_convergencia))
                {
                    Console.WriteLine("Gen: " + x + " NO converge, con un porcentaje de 0s de " + porcentaje_0s_enPoblacion + " y un porcentaje de 1s de:" + porcentaje_1s_enPoblacion);
                    return 0;
                }
            }
            Console.WriteLine("Cromosomas convergen");
            return 1;
        }



        public void Visualizar_fitness()
        {
            Console.WriteLine("Poblacion");
            for (int x = 0; x < Tamaño_Poblacion_inicial; x++)
            {
                for (int y = 0; y < Cantidad_Genes; y++)
                {

                    Console.Write("     " + Poblacion[x, y]);

                }
                Console.WriteLine("     Fitness: " + Fitness[x]);
                Console.WriteLine("");
            }
            Console.WriteLine("");

        }


        public int[] Visualizar_Solucion()
        {

            int[] Solucion = new int[44];

            Random rand = new Random();
            int x = rand.Next(0, Tamaño_Poblacion_inicial);

            for (int y = 0; y < Cantidad_Genes; y++)
            {
                Solucion[y] = Poblacion[x, y];
            }

            Console.WriteLine("Fitness" + Fitness[x] + "        Produccion:" + Produccion_de_Individuos[x]);
            return Solucion;
        }




        public void Visualizacion_Final()
        {
            Console.WriteLine("Poblacion");
            int fitness;
            for (int x = 0; x < Tamaño_Poblacion_inicial; x++)
            {
                fitness = 0;
                for (int y = 0; y < Cantidad_Genes; y++)
                {
                    fitness = fitness + Poblacion[x, y] * 1;
                    Console.Write("     " + Poblacion[x, y]);

                }

                Console.WriteLine("     Fit: " + fitness);
                Console.WriteLine("");
                fitness = 0;
            }
            Console.WriteLine("");

        }


        public void Visualizar_Despues_Operadores()
        {
            Console.WriteLine("Poblacion despues Cruce");
            for (int x = 0; x < Tamaño_Poblacion_inicial; x++)
            {
                for (int y = 0; y < Cantidad_Genes; y++)
                {

                    Console.Write("  " + Poblacion_Intermedia[x, y]);

                }
                Console.WriteLine("");
            }


        }


        public double[] Calculo_Produccion_Individuo(int[] Solucion, double velocidad_del_viento)
        {

            Calculo_Produccion_Energia Calculo_produccion_individuo = new Calculo_Produccion_Energia();
            double[] Velocidad_Viento_Cada_Individuo = (double[])Velocidad_Viento_General.Clone();
            double[] Produccion_del_Parque = new double[45];
            double Produccion_Energia_Individuo = 0;
            double Produccion_Aerogenerador;
            for (int y = 0; y < Cantidad_Genes; y++)
            {
                Produccion_Aerogenerador = 0;
                if (Solucion[y].Equals(1))
                {

                    bool verifica_estela = Efecto_Estela_Aerogenerador_2.Contains(y);
                    if (verifica_estela.Equals(true))
                    {

                        int indice_aerogenerador_1 = 0;
                        int indice_aerogenerador_2 = 0;
                        for (int z = 0; z < Efecto_Estela_Aerogenerador_2.Length; z++)
                        {
                            if (Efecto_Estela_Aerogenerador_2[z].Equals(y))
                            {
                                indice_aerogenerador_1 = Efecto_Estela_Aerogenerador_1[z] - 1;
                                indice_aerogenerador_2 = Efecto_Estela_Aerogenerador_2[z] - 1;
                            }
                        }

                        if (Solucion[indice_aerogenerador_1].Equals(1))
                        {
                            //ACA SE VE EFECTO ESTELA

                            double altura_aerogenerador_1 = Altura_Aerogeneradores[indice_aerogenerador_1];
                            double altura_aerogenerador_2 = Altura_Aerogeneradores[indice_aerogenerador_2];
                            double velocidad_viento_aerogenerador_1 = Velocidad_Viento_Cada_Individuo[2];

                            double velocidad_viento_aerogenerador_2 = Calculo_produccion_individuo.Calculo_Efecto_Estela(velocidad_viento_aerogenerador_1, altura_aerogenerador_1, altura_aerogenerador_2);
                            Velocidad_Viento_Cada_Individuo[y] = velocidad_viento_aerogenerador_2;

                            Produccion_Aerogenerador = Calculo_produccion_individuo.Calculo_Produccion_Energia_Libre(velocidad_viento_aerogenerador_2);
                            Produccion_Energia_Individuo = Produccion_Energia_Individuo + Produccion_Aerogenerador;

                        }
                        else
                        {
                            Produccion_Aerogenerador = Calculo_produccion_individuo.Calculo_Produccion_Energia_Libre(Velocidad_Viento_Cada_Individuo[y]);
                            Produccion_Energia_Individuo = Produccion_Energia_Individuo + Produccion_Aerogenerador;
                        }

                    }
                    else
                    {
                        Produccion_Aerogenerador = Calculo_produccion_individuo.Calculo_Produccion_Energia_Libre(Velocidad_Viento_Cada_Individuo[y]);
                        Produccion_Energia_Individuo = Produccion_Energia_Individuo + Produccion_Aerogenerador;
                    }
                }

                Produccion_del_Parque[y] = Produccion_Aerogenerador;

            }

            Produccion_Energia_Individuo = Calculo_produccion_individuo.Calculo_Produccion_Energia_Neta(Produccion_Energia_Individuo);
            Produccion_Energia_Individuo = Produccion_Energia_Individuo / 1000;
            Produccion_del_Parque[Cantidad_Genes] = Produccion_Energia_Individuo;
            return Produccion_del_Parque;

        }
        

    }
}
