using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_RONAL_2026
{
    public static class CLAlgoritmoDeBusqueda
    {


        public static List<CLEstado> AnchuraPrioritaria(CLEstado Inicial)
        {
            List<CLEstado> Solucion = new List<CLEstado>();
            List<CLEstado> Abiertos = new List<CLEstado>();
            List<CLEstado> Cerrados = new List<CLEstado>();
            List<CLEstado> Hijos = new List<CLEstado>();
            CLEstado Actual = new CLEstado();

            Inicial.Nivel = 0;
            Inicial.Padre = null; 
            Abiertos.Add(Inicial);
            Actual = Abiertos[0];

            while (!Actual.EsFinal() && Abiertos.Count > 0)
            {
                Cerrados.Add(Actual);
                Abiertos.RemoveAt(0);

                Hijos = Actual.GenerarHijos();
                Hijos = TratarRepetidos(Hijos, Abiertos, Cerrados);

                foreach (CLEstado a in Hijos)
                {
                    a.Nivel = Actual.Nivel + 1;
                    Abiertos.Add(a);
                }

                if (Abiertos.Count > 0)
                {
                    Actual = Abiertos[0];
                }
            }


            if (Actual.EsFinal())
            {
                CLEstado rastreador = Actual;
                while (rastreador != null)
                {
                    Solucion.Add(rastreador);
                    rastreador = rastreador.Padre; 
                }

  
                Solucion.Reverse();
            }

            return Solucion;
        }

        private static List<CLEstado> TratarRepetidos(List<CLEstado> hijos, List<CLEstado> abiertos, List<CLEstado> cerrados)
        {
            bool encontrado = false;
            List<CLEstado> hijosSinRepetidos = new List<CLEstado>();

            foreach (CLEstado a in hijos)
            {
                encontrado = false;

                //Comparar con abiertos
                foreach (CLEstado abierto in abiertos)
                {
                    if (a.EsIgual(abierto)) 
                    {
                        encontrado = true;
                        break; 
                    }
                }

                //Comparar con cerrados (solo si no se encontro en abiertos)
                if (!encontrado)
                {
                    foreach (CLEstado cerrado in cerrados)
                    {
                        if (a.EsIgual(cerrado))
                        {
                            encontrado = true;
                            break; 
                        }
                    }
                }

                if (!encontrado)
                {
                    hijosSinRepetidos.Add(a);
                }
            }

            return hijosSinRepetidos;
        }

        public static List<CLEstado> ProfundidadLimitada(CLEstado Inicial, int Limite)
        {
            List<CLEstado> Solucion = new List<CLEstado>();
            List<CLEstado> Abiertos = new List<CLEstado>();
            List<CLEstado> Cerrados = new List<CLEstado>();
            CLEstado Actual = new CLEstado();
            // 1. Iniciar nivel y padre
            Inicial.Nivel = 0;
            Inicial.Padre = null;

            Abiertos.Add(Inicial);
            Actual = Abiertos[Abiertos.Count - 1]; // LIFO (Pila)

            while (!Actual.EsFinal() && Abiertos.Count > 0)
            {
                Cerrados.Add(Actual);
                Abiertos.RemoveAt(Abiertos.Count - 1);

                // 2. Solo expandimos si no hemos llegado al límite
                if (Actual.Nivel < Limite)
                {
                    List<CLEstado> Hijos = Actual.GenerarHijos();

                    // 3. ¡VITAL! Asignarle el nivel y el padre a los hijos antes de tratarlos
                    foreach (CLEstado hijo in Hijos)
                    {
                        hijo.Nivel = Actual.Nivel + 1;
                    }

                    Hijos = TratarRepetidosProfundidad(Hijos, Abiertos, Cerrados);

                    foreach (CLEstado a in Hijos)
                    {
                        Abiertos.Add(a);
                    }
                }

                // 4. Protección contra lista vacía
                if (Abiertos.Count > 0)
                {
                    Actual = Abiertos[Abiertos.Count - 1];
                }
            }

            if (Actual.EsFinal())
            {
                CLEstado rastreador = Actual;
                while (rastreador != null)
                {
                    Solucion.Add(rastreador);
                    rastreador = rastreador.Padre;
                }

                // 5. ¡VITAL! Voltear la lista para que la película empiece desde el origen
                Solucion.Reverse();
            }
            return Solucion;
        }

        private static List<CLEstado> TratarRepetidosProfundidad(List<CLEstado> hijos, List<CLEstado> abiertos, List<CLEstado> cerrados)
        {
            List<CLEstado> HijosDepurado = new List<CLEstado>();
            bool encontrado = false;

            foreach (CLEstado hijo in hijos)
            {
                encontrado = false;

                // Comparar con abiertos
                foreach (var a in abiertos)
                {
                    if (hijo.EsIgual(a))
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado) continue;

                // Comparar con cerrados
                foreach (var c in cerrados)
                {
                    if (hijo.EsIgual(c))
                    {
                        if (hijo.Nivel >= c.Nivel)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                }

                if (!encontrado)
                {
                    HijosDepurado.Add(hijo);
                }
            }

            return HijosDepurado;
        }


        public static List<CLEstado> ProfundidadIterativa(CLEstado Inicial, int limiteMaximo)
        {
            List<CLEstado> Solucion = new List<CLEstado>();


            int nivelMensaje = -1;


            for (int prof = 1; prof <= limiteMaximo; prof++)
            {
                //Limpiamos las listas en cada nueva vuelta
                List<CLEstado> Abiertos = new List<CLEstado>();
                List<CLEstado> Cerrados = new List<CLEstado>();
                CLEstado Actual = new CLEstado();

                // estado inicial
                Inicial.Nivel = 0;
                Inicial.Padre = null;
                Abiertos.Add(Inicial);


                Actual = Abiertos[Abiertos.Count - 1];

                while (!Actual.EsFinal() && Abiertos.Count > 0)
                {
                    Cerrados.Add(Actual);

                    if (Actual.Nivel > nivelMensaje)
                    {
                        MessageBox.Show("Avanzando en el nivel de profundidad: " + Actual.Nivel, "Buscando solución...");
                        nivelMensaje = Actual.Nivel;
                    }
                    Abiertos.RemoveAt(Abiertos.Count - 1);


                    if (Actual.Nivel < prof)
                    {
                        List<CLEstado> Hijos = Actual.GenerarHijos();

                        foreach (CLEstado hijo in Hijos)
                        {
                            hijo.Nivel = Actual.Nivel + 1;
                        }

                        Hijos = TratarRepetidosProfundidad(Hijos, Abiertos, Cerrados);

                        foreach (CLEstado a in Hijos)
                        {
                            Abiertos.Add(a);
                        }
                    }

                    if (Abiertos.Count > 0)
                    {
                        Actual = Abiertos[Abiertos.Count - 1];
                    }
                }

                if (Actual.EsFinal())
                {
                    CLEstado rastreador = Actual;
                    while (rastreador != null)
                    {
                        Solucion.Add(rastreador);
                        rastreador = rastreador.Padre;
                    }
                    Solucion.Reverse();

                    return Solucion;
                }

            }

            return Solucion;
        }


            public static List<CLEstado> AlgortimoHeuristicoH3(CLEstado Inicial)
        {
            //Definición de variables
            List<CLEstado> Solucion = new List<CLEstado>();
            List<CLEstado> Abiertos = new List<CLEstado>();
            List<CLEstado> Cerrados = new List<CLEstado>();
            List<CLEstado> Hijos = new List<CLEstado>();
            CLEstado Actual = new CLEstado();
            //Algoritmo
            Abiertos.Add(Inicial);
            Actual = Abiertos[0];
            while (!Actual.EsFinal() && Abiertos.Count > 0)
            {
                Cerrados.Add(Actual);
                Abiertos.RemoveAt(0);
                Hijos = Actual.GenerarHijos();
                Hijos = TratarRepetidos(Hijos, Abiertos, Cerrados);
                foreach (CLEstado a in Hijos)
                    Abiertos.Add(a);
                //ORDENAR ABIERTOS POR H3
                Actual = Abiertos[0];
            }
            if (Actual.EsFinal())
            {
                Solucion.Add(Actual);
                while (Actual.Padre != null)
                {
                    Solucion.Add(Actual.Padre);
                    Actual = Actual.Padre;
                }
            }
            return Solucion;
        }
    }

    
}
