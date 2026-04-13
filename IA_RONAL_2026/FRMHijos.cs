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
    public partial class FRMHijos : Form
    {


        #region Variables

        public List<CLEstado> Hijos = new List<CLEstado>();
        private int apuntador = 0;


        #endregion


        #region Constructor

        public FRMHijos()
        {
            InitializeComponent();
        }

        #endregion


        #region Metodos


        private void TrasladarEstadoaTablero(int apuntador)
        {
            LBL00.Text = Hijos[apuntador].tablero[0, 0].ToString();
            LBL01.Text = Hijos[apuntador].tablero[0, 1].ToString();
            LBL02.Text = Hijos[apuntador].tablero[0, 2].ToString();
            LBL10.Text = Hijos[apuntador].tablero[1, 0].ToString();
            LBL11.Text = Hijos[apuntador].tablero[1, 1].ToString();
            LBL12.Text = Hijos[apuntador].tablero[1, 2].ToString();
            LBL20.Text = Hijos[apuntador].tablero[2, 0].ToString();
            LBL21.Text = Hijos[apuntador].tablero[2, 1].ToString();
            LBL22.Text = Hijos[apuntador].tablero[2, 2].ToString();

            LBLHijo.Text = "Hijo: " + (apuntador + 1).ToString();
        }
        #endregion



        #region Eventos


        private void BTNIzquierdo_Click(object sender, EventArgs e)
        {
            if (apuntador>0)
            {
                apuntador--;
                TrasladarEstadoaTablero(apuntador);
            }

        }

        private void BTNDerecho_Click(object sender, EventArgs e)
        {
            if (Hijos.Count - 1 > apuntador)
            {
                apuntador++;
                TrasladarEstadoaTablero(apuntador);
            }


        }

        private void FRMHijos_Load(object sender, EventArgs e)
        {
            if (Hijos.Count > 0)
            {
                apuntador = 0;
                TrasladarEstadoaTablero(apuntador);


            }

            else
            {
                MessageBox.Show("No hay hijos");
            }
        }



        #endregion



    }
}
