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

            //Definicion de variables
            List<CLEstado> Solucion = new List<CLEstado>();
            List<CLEstado> Abiertos = new List<CLEstado>();
            List<CLEstado> Cerrados = new List<CLEstado>();
            List<CLEstado> Hijos = new List<CLEstado>();
            CLEstado Actual = new CLEstado();

            Abiertos.Add(Inicial);
            Actual = Abiertos[0];


            while (!Actual.EsFinal() || Abiertos.Count > 0)
            {
                Cerrados.Add(Actual);
                Abiertos.RemoveAt(0);

                Hijos = Actual.GenerarHijos();

                Hijos = TratarRepetidos(Hijos, Abiertos, Cerrados);

                foreach (CLEstado a in Hijos)
                {
                    Abiertos.Add(a);
                }

                Actual = Abiertos[0];



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

       
    }
}
