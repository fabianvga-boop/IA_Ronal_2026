using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_RONAL_2026
{
    public class CLEstado
    {

        #region Campos
        private int[,] _tablero;
        private int _nivel;
        private CLEstado _padre;
        private int _h3;



        #endregion


        #region Propiedades

        public int[,] tablero
        {
            get => _tablero;
            set => _tablero = value;

        }

        public int Nivel
        {
            get => _nivel;
            set => _nivel = value;

        }
        public CLEstado Padre
        {
            get => _padre;
            set => _padre = value;
        }

        public int h3
        {
            get => _h3;
            set => _h3 = value;
        }
        #endregion


        #region Constructor


        public CLEstado()
        {
            this._tablero = new int[3, 3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                
                    this._tablero[i, j] = 0;
                this._nivel = 0;
            
            


        }


        public CLEstado(int p00, int p01, int p02,
                        int p10, int p11, int p12,
                        int p20, int p21, int p22)
        {
            this._tablero = new int[3, 3];
            this._tablero[0, 0] = p00;
            this._tablero[1, 0] = p10;
            this._tablero[2, 0] = p20;
            this._tablero[0, 1] = p01;
            this._tablero[1, 1] = p11;
            this._tablero[2, 1] = p21;
            this._tablero[0, 2] = p02;
            this._tablero[1, 2] = p12;
            this._tablero[2, 2] = p22;
            this._nivel = 0;
            this._padre = null;
            this._h3 = H3();

        }



        #endregion


        #region Metodos

        public List<CLEstado> GenerarHijos()
        {
            List<CLEstado> Respuesta = new List<CLEstado>();
            String pos0 = "";

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (this._tablero[i, j] == 0)
                    {
                        pos0 = i.ToString() + j.ToString();
                    }

            CLEstado A;

            switch (pos0)
            {
                case "00": // Mueve Derecha, Mueve Abajo
                    A = new CLEstado(this._tablero[0, 1], this._tablero[0, 0], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[1, 1], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[1, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[0, 0], this._tablero[1, 1], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;
                    Respuesta.Add(A);
                    break;

                case "01": // Mueve Izquierda, Mueve Derecha, Mueve Abajo
                    A = new CLEstado(this._tablero[0, 1], this._tablero[0, 0], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[1, 1], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 2], this._tablero[0, 1],
                                     this._tablero[1, 0], this._tablero[1, 1], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[1, 1], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[0, 1], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;


                    Respuesta.Add(A);
                    break;

                case "02": // Mueve Izquierda, Mueve Abajo
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 2], this._tablero[0, 1],
                                     this._tablero[1, 0], this._tablero[1, 1], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[1, 2],
                                     this._tablero[1, 0], this._tablero[1, 1], this._tablero[0, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    break;

                case "10": // Mueve Arriba, Mueve Derecha, Mueve Abajo
                    A = new CLEstado(this._tablero[1, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[0, 0], this._tablero[1, 1], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[1, 1], this._tablero[1, 0], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[2, 0], this._tablero[1, 1], this._tablero[1, 2],
                                     this._tablero[1, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    break;

                case "11": // Mueve Arriba, Izquierda, Derecha, Abajo
                    A = new CLEstado(this._tablero[0, 0], this._tablero[1, 1], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[0, 1], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[1, 1], this._tablero[1, 0], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[1, 2], this._tablero[1, 1],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[2, 1], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[1, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    break;

                case "12": // Mueve Arriba, Izquierda, Abajo
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[1, 2],
                                     this._tablero[1, 0], this._tablero[1, 1], this._tablero[0, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[1, 2], this._tablero[1, 1],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[1, 1], this._tablero[2, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[1, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    break;

                case "20": // Mueve Arriba, Derecha
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[2, 0], this._tablero[1, 1], this._tablero[1, 2],
                                     this._tablero[1, 0], this._tablero[2, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[1, 1], this._tablero[1, 2],
                                     this._tablero[2, 1], this._tablero[2, 0], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    break;

                case "21": // Mueve Arriba, Izquierda, Derecha
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[2, 1], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[1, 1], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[1, 1], this._tablero[1, 2],
                                     this._tablero[2, 1], this._tablero[2, 0], this._tablero[2, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[1, 1], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[2, 2], this._tablero[2, 1]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    break;

                case "22": // Mueve Arriba, Izquierda
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[1, 1], this._tablero[2, 2],
                                     this._tablero[2, 0], this._tablero[2, 1], this._tablero[1, 2]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0], this._tablero[0, 1], this._tablero[0, 2],
                                     this._tablero[1, 0], this._tablero[1, 1], this._tablero[1, 2],
                                     this._tablero[2, 0], this._tablero[2, 2], this._tablero[2, 1]);
                    A.Padre = this;

                    Respuesta.Add(A);
                    break;
            }

            return Respuesta;
        }


        public bool EsFinal()
        {
            bool res = false;

            // Estado meta circular:
            // 1 2 3
            // 8 0 4
            // 7 6 5
            if (this._tablero[0, 0] == 1 &&
                this._tablero[0, 1] == 2 &&
                this._tablero[0, 2] == 3 &&
                this._tablero[1, 0] == 8 &&
                this._tablero[1, 1] == 0 &&
                this._tablero[1, 2] == 4 &&
                this._tablero[2, 0] == 7 &&
                this._tablero[2, 1] == 6 &&
                this._tablero[2, 2] == 5)
            {
                res = true;
            }

            return res;
        }

        #endregion


        public bool EsIgual(CLEstado EstadoAux)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Si el valor en la posición actual es diferente al del EstadoAux, no son iguales

                    //Comparacio del valor en la posición (i, j) del tablero actual
                    //con el valor en la misma posición del EstadoAuxliar (Abierto o Cerrado) 
                    if (this._tablero[i, j] != EstadoAux._tablero[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int H1()
        {
            int H1 = 0;

            int[,] matrizMeta =
            {
        { 1, 2, 3 },
        { 8, 0, 4 },
        { 7, 6, 5 }
    };

            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (_tablero[fila, col] != 0 && _tablero[fila, col] != matrizMeta[fila, col])
                    {
                        H1++;
                    }
                }
            }

            return H1; 
        }

        public int H2()
        {
            int distancia = 0;

            int[] metaFila = { 1, 0, 0, 0, 1, 2, 2, 2, 1 };
            int[] metaCol = { 1, 0, 1, 2, 2, 2, 1, 0, 0 };

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    int valor = _tablero[f, c];

                    if (valor != 0)
                    {
                        distancia += Math.Abs(f - metaFila[valor]) + Math.Abs(c - metaCol[valor]);
                    }
                }
            }

            return distancia; 
        }

        public int H3()
        {
            int penalizacion = 0;

            int[] camino =
            {
        _tablero[0, 0],
        _tablero[0, 1],
        _tablero[0, 2],
        _tablero[1, 2],
        _tablero[2, 2],
        _tablero[2, 1],
        _tablero[2, 0],
        _tablero[1, 0]
    };

            for (int k = 0; k < 8; k++)
            {
                int nodoActual = camino[k];
                int nodoSiguiente = camino[(k + 1) % 8];

                if (nodoActual != 0)
                {
                    int sucesorIdeal = (nodoActual == 8) ? 1 : nodoActual + 1;

                    if (nodoSiguiente != sucesorIdeal)
                    {
                        penalizacion += 2;
                    }
                }
            }

            if (_tablero[1, 1] != 0)
            {
                penalizacion++;
            }

            return H2() + (penalizacion);
        }

    }
}
