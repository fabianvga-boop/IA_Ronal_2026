using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_RONAL_2026
{
    public partial class FRMOchoPuzzle : Form
    {

        int contador = 0;
        private String pos0;
        private String[,] posiciones;
        List<CLEstado> caminoSolucion;
        int pasoActualAnimacion = 0;

        public FRMOchoPuzzle()
        {
            InitializeComponent();
        }
        private void LBL00_Click(object sender, EventArgs e)
        {
            if (LBL10.Text == "0")
            {
                LBL10.Text = LBL00.Text;
                LBL00.Text = "0";
            }
            else if (LBL01.Text == "0")
            {
                LBL01.Text = LBL00.Text;
                LBL00.Text = "0";
            }
        }

        private void LBL10_Click(object sender, EventArgs e)
        {
            if (LBL00.Text == "0")
            {
                LBL00.Text = LBL10.Text;
                LBL10.Text = "0";
            }
            else if (LBL11.Text == "0")
            {
                LBL11.Text = LBL10.Text;
                LBL10.Text = "0";
            }
            else if (LBL20.Text == "0")
            {
                LBL20.Text = LBL10.Text;
                LBL10.Text = "0";
            }
        }

        private void LBL20_Click(object sender, EventArgs e)
        {
            if (LBL10.Text == "0")
            {
                LBL10.Text = LBL20.Text;
                LBL20.Text = "0";
            }
            else if (LBL21.Text == "0")
            {
                LBL21.Text = LBL20.Text;
                LBL20.Text = "0";
            }
        }

        private void LBL01_Click(object sender, EventArgs e)
        {
            if (LBL00.Text == "0")
            {
                LBL00.Text = LBL01.Text;
                LBL01.Text = "0";
            }
            else if (LBL11.Text == "0")
            {
                LBL11.Text = LBL01.Text;
                LBL01.Text = "0";
            }
            else if (LBL02.Text == "0")
            {
                LBL02.Text = LBL01.Text;
                LBL01.Text = "0";
            }
        }

        private void LBL02_Click(object sender, EventArgs e)
        {
            if (LBL01.Text == "0")
            {
                LBL01.Text = LBL02.Text;
                LBL02.Text = "0";
            }
            else if (LBL12.Text == "0")
            {
                LBL12.Text = LBL02.Text;
                LBL02.Text = "0";
            }
        }

        private void LBL11_Click(object sender, EventArgs e)
        {
            if (LBL01.Text == "0")
            {
                LBL01.Text = LBL11.Text;
                LBL11.Text = "0";
            }
            else if (LBL10.Text == "0")
            {
                LBL10.Text = LBL11.Text;
                LBL11.Text = "0";
            }
            else if (LBL21.Text == "0")
            {
                LBL21.Text = LBL11.Text;
                LBL11.Text = "0";
            }
            else if (LBL12.Text == "0")
            {
                LBL12.Text = LBL11.Text;
                LBL11.Text = "0";
            }
        }

        private void LBL12_Click(object sender, EventArgs e)
        {
            if (LBL11.Text == "0")
            {
                LBL11.Text = LBL12.Text;
                LBL12.Text = "0";
            }
            else if (LBL22.Text == "0")
            {
                LBL22.Text = LBL12.Text;
                LBL12.Text = "0";
            }
            else if (LBL02.Text == "0")
            {
                LBL02.Text = LBL12.Text;
                LBL12.Text = "0";
            }
        }

        private void LBL21_Click(object sender, EventArgs e)
        {
            if (LBL11.Text == "0")
            {
                LBL11.Text = LBL21.Text;
                LBL21.Text = "0";
            }
            else if (LBL20.Text == "0")
            {
                LBL20.Text = LBL21.Text;
                LBL21.Text = "0";
            }
            else if (LBL22.Text == "0")
            {
                LBL22.Text = LBL21.Text;
                LBL21.Text = "0";
            }
        }

        private void LBL22_Click(object sender, EventArgs e)
        {
            if (LBL21.Text == "0")
            {
                LBL21.Text = LBL22.Text;
                LBL22.Text = "0";
            }
            else if (LBL12.Text == "0")
            {
                LBL12.Text = LBL22.Text;
                LBL22.Text = "0";
            }
        }
        private void BTNDesordenar_Click(object sender, EventArgs e)
        {
            TRMReloj.Enabled = true;
        }

        private void TRMReloj_Tick(object sender, EventArgs e)
        {
            posiciones = new string[3, 3];

            posiciones[0, 0] = LBL00.Text;
            posiciones[0, 1] = LBL01.Text;
            posiciones[0, 2] = LBL02.Text;
            posiciones[1, 0] = LBL10.Text;
            posiciones[1, 1] = LBL11.Text;
            posiciones[1, 2] = LBL12.Text;
            posiciones[2, 0] = LBL20.Text;
            posiciones[2, 1] = LBL21.Text;
            posiciones[2, 2] = LBL22.Text;



            if (contador < 20)
            {
                contador++;
                LBLContador.Text = contador.ToString();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (posiciones[i, j] == "0")
                        {
                            pos0 = i.ToString() + j.ToString();
                        }

                    }
                }

                Random rn = new Random();
                int aleatorio = 0;
                switch (pos0)
                {
                    case "00":
                        aleatorio = rn.Next(1, 3);
                        if (aleatorio == 1)
                        {
                            LBL00.Text = LBL10.Text;
                            LBL10.Text = "0";
                        }
                        else
                        {
                            LBL00.Text = LBL01.Text;
                            LBL01.Text = "0";
                        }

                        break;
                    case "01":

                        aleatorio = rn.Next(1, 4);
                        if (aleatorio == 1)
                        {
                            LBL01.Text = LBL00.Text;
                            LBL00.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL01.Text = LBL11.Text;
                                LBL11.Text = "0";
                            }
                            else
                            {
                                LBL01.Text = LBL02.Text;
                                LBL02.Text = "0";

                            }
                        }

                        break;
                    case "02":
                        aleatorio = rn.Next(1, 3);
                        if (aleatorio == 1)
                        {
                            LBL02.Text = LBL01.Text;
                            LBL01.Text = "0";
                        }
                        else
                        {
                            LBL02.Text = LBL12.Text;
                            LBL12.Text = "0";
                        }

                        break;
                    case "10":
                        aleatorio = rn.Next(1, 4);
                        if (aleatorio == 1)
                        {
                            LBL10.Text = LBL00.Text;
                            LBL00.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL10.Text = LBL11.Text;
                                LBL11.Text = "0";
                            }
                            else
                            {
                                LBL10.Text = LBL20.Text;
                                LBL20.Text = "0";

                            }
                        }

                        break;
                    case "11":
                        aleatorio = rn.Next(1, 5);
                        if (aleatorio == 1)
                        {
                            LBL11.Text = LBL01.Text;
                            LBL01.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL11.Text = LBL12.Text;
                                LBL12.Text = "0";

                            }
                            else
                            {
                                if (aleatorio == 3)
                                {
                                    LBL11.Text = LBL21.Text;
                                    LBL21.Text = "0";
                                }
                                else
                                {
                                    LBL11.Text = LBL10.Text;
                                    LBL10.Text = "0";

                                }
                            }
                        }

                        break;
                    case "12":
                        aleatorio = rn.Next(1, 4);
                        if (aleatorio == 1)
                        {
                            LBL12.Text = LBL02.Text;
                            LBL02.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL12.Text = LBL11.Text;
                                LBL11.Text = "0";
                            }
                            else
                            {
                                LBL12.Text = LBL22.Text;
                                LBL22.Text = "0";

                            }
                        }

                        break;
                    case "20":
                        aleatorio = rn.Next(1, 3);
                        if (aleatorio == 1)
                        {
                            LBL20.Text = LBL10.Text;
                            LBL10.Text = "0";
                        }
                        else
                        {
                            LBL20.Text = LBL21.Text;
                            LBL21.Text = "0";
                        }

                        break;
                    case "21":
                        aleatorio = rn.Next(1, 4);
                        if (aleatorio == 1)
                        {
                            LBL21.Text = LBL20.Text;
                            LBL20.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL21.Text = LBL11.Text;
                                LBL11.Text = "0";
                            }
                            else
                            {
                                LBL21.Text = LBL22.Text;
                                LBL22.Text = "0";

                            }
                        }

                        break;
                    case "22":

                        aleatorio = rn.Next(1, 3);
                        if (aleatorio == 1)
                        {
                            LBL22.Text = LBL21.Text;
                            LBL21.Text = "0";
                        }
                        else
                        {
                            LBL22.Text = LBL12.Text;
                            LBL12.Text = "0";
                        }

                        break;
                }

            }
            else
            {
                TRMReloj.Enabled = false;
                MessageBox.Show("Reloj apagado");
                LBLContador.Text = "";
                contador = 0;
            }
        }




        private void BTNGenerarHijos_Click(object sender, EventArgs e)
        {
            CLEstado Inicial = new CLEstado(Convert.ToInt32(LBL00.Text),
                                            Convert.ToInt32(LBL01.Text),
                                            Convert.ToInt32(LBL02.Text),
                                            Convert.ToInt32(LBL10.Text),
                                            Convert.ToInt32(LBL11.Text),
                                            Convert.ToInt32(LBL12.Text),
                                            Convert.ToInt32(LBL20.Text),
                                            Convert.ToInt32(LBL21.Text),
                                            Convert.ToInt32(LBL22.Text));

            List<CLEstado> Hijos = Inicial.GenerarHijos();
            FRMHijos A = new FRMHijos();

            A.Hijos = Hijos;
            A.ShowDialog();


        }

        private void LBLContador_Click(object sender, EventArgs e)
        {

        }

        private void BTNesFinal_Click(object sender, EventArgs e)
        {
            CLEstado estadoActual = new CLEstado(
                Convert.ToInt32(LBL00.Text),
                Convert.ToInt32(LBL01.Text),
                Convert.ToInt32(LBL02.Text),
                Convert.ToInt32(LBL10.Text),
                Convert.ToInt32(LBL11.Text),
                Convert.ToInt32(LBL12.Text),
                Convert.ToInt32(LBL20.Text),
                Convert.ToInt32(LBL21.Text),
                Convert.ToInt32(LBL22.Text)
            );

            if (estadoActual.EsFinal() == true)
            {

                MessageBox.Show("Es el Estado Final");
            }
            else
            {

                MessageBox.Show("NO es el estado Final");
            }

        }

        private void BTNAnchuraPrioritaria_Click_1(object sender, EventArgs e)
        {
            CLEstado estadoActual = new CLEstado(
                Convert.ToInt32(LBL00.Text),
                Convert.ToInt32(LBL01.Text),
                Convert.ToInt32(LBL02.Text),
                Convert.ToInt32(LBL10.Text),
                Convert.ToInt32(LBL11.Text),
                Convert.ToInt32(LBL12.Text),
                Convert.ToInt32(LBL20.Text),
                Convert.ToInt32(LBL21.Text),
                Convert.ToInt32(LBL22.Text)
            );

            // Buscar solución
            caminoSolucion = CLAlgoritmoDeBusqueda.AnchuraPrioritaria(estadoActual);

            if (caminoSolucion.Count > 0)
            {
                pasoActualAnimacion = 0;
                TRMcontador.Interval = 500;
                TRMcontador.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontró solución");
            }
        }

        private void TRMcontador_Tick_1(object sender, EventArgs e)
        {
            if (caminoSolucion == null || pasoActualAnimacion >= caminoSolucion.Count)
            {
                TRMcontador.Enabled = false;
                MessageBox.Show("Solución Completada");
                return;
            }

            CLEstado p = caminoSolucion[pasoActualAnimacion];
            LBL00.Text = p.tablero[0, 0].ToString();
            LBL01.Text = p.tablero[0, 1].ToString();
            LBL02.Text = p.tablero[0, 2].ToString();
            LBL10.Text = p.tablero[1, 0].ToString();
            LBL11.Text = p.tablero[1, 1].ToString();
            LBL12.Text = p.tablero[1, 2].ToString();
            LBL20.Text = p.tablero[2, 0].ToString();
            LBL21.Text = p.tablero[2, 1].ToString();
            LBL22.Text = p.tablero[2, 2].ToString();

            LBLContador.Text = pasoActualAnimacion.ToString();

            pasoActualAnimacion++;
        }

      

 
    }
}

