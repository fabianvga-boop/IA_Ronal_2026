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
                        // 6. ¡CORRECCIÓN DE LLAVES!
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

            // Bucle externo: Controla el incremento de la profundidad (prof)
            // Esto equivale al "mientras (no esfinal) y prof < limite" de tu imagen
            for (int prof = 1; prof <= limiteMaximo; prof++)
            {
                // Estabiertos.inicializar() -> Limpiamos las listas en cada nueva vuelta
                List<CLEstado> Abiertos = new List<CLEstado>();
                List<CLEstado> Cerrados = new List<CLEstado>();
                CLEstado Actual = new CLEstado();

                // Estabiertos.insertar(Estadoinicial)
                Inicial.Nivel = 0;
                Inicial.Padre = null;
                Abiertos.Add(Inicial);

                // Actual = Estabiertos.primero() -> Como es profundidad, usamos la Pila (LIFO)
                Actual = Abiertos[Abiertos.Count - 1];

                // Bucle interno: Búsqueda en profundidad limitada tradicional
                while (!Actual.EsFinal() && Abiertos.Count > 0)
                {
                    Cerrados.Add(Actual);
                    Abiertos.RemoveAt(Abiertos.Count - 1);

                    // "Si profundidad(Actual) <= prof entonces..."
                    if (Actual.Nivel < prof)
                    {
                        List<CLEstado> Hijos = Actual.GenerarHijos();

                        // Asignamos nivel y padre antes de tratar repetidos
                        foreach (CLEstado hijo in Hijos)
                        {
                            hijo.Nivel = Actual.Nivel + 1;
                        }

                        Hijos = TratarRepetidosProfundidad(Hijos, Abiertos, Cerrados);

                        // Estabiertos.insertar(Hijos)
                        foreach (CLEstado a in Hijos)
                        {
                            Abiertos.Add(a);
                        }
                    }

                    // Avanzar al siguiente estado
                    if (Abiertos.Count > 0)
                    {
                        Actual = Abiertos[Abiertos.Count - 1];
                    }
                }

                // Si al terminar la búsqueda en este nivel encontramos la meta, reconstruimos y SALIMOS
                if (Actual.EsFinal())
                {
                    CLEstado rastreador = Actual;
                    while (rastreador != null)
                    {
                        Solucion.Add(rastreador);
                        rastreador = rastreador.Padre;
                    }
                    Solucion.Reverse();

                    return Solucion; // Rompe el ciclo 'for' y devuelve la solución
                }

                // Si no lo encuentra, el ciclo 'for' hace prof = prof + 1 y vuelve a empezar
            }

            // Si se agota el límite máximo y nunca entró al return de arriba, fracasó.
            return Solucion;
        }
    }
}
