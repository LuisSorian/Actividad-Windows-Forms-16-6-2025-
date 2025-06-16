using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piedra__Papel_y_Tijeras
{
    public partial class PPT : Form
    {
        double puntajeAI, puntajeJugador;
        public PPT()
        {
            InitializeComponent();
            RBPapelJG.Checked = false;
            RBTijerasJG.Checked = false;
            RBPiedraJG.Checked = false;
        }

        private void BTNJugar_Click(object sender, EventArgs e)
        {
            Random Seleccion = new Random();
            int AI = Seleccion.Next(1, 4);
            double cerrar = 0;

            if (AI == 1)
            {
                RBPapelAI.Checked = true;
                if (RBTijerasJG.Checked == true)
                {
                    LBLResultado.Text = "GANASTE LA RONDA!";
                    puntajeJugador += 1;
                    TXTJG.Text = puntajeJugador.ToString();
                }
                if (RBPapelJG.Checked == true)
                {
                    LBLResultado.Text = "EMPATE!";
                }
                if (RBPiedraJG.Checked == true)
                {
                    LBLResultado.Text = "PERDISTE LA RONDA!";
                    puntajeAI += 1;
                    TXTAI.Text = puntajeAI.ToString();
                }
            }
            else if (AI == 2)
            {
                RBTijerasAI.Checked = true;
                if (RBTijerasJG.Checked == true)
                {
                    LBLResultado.Text = "EMPATE!";
                }
                if (RBPapelJG.Checked == true)
                {
                    LBLResultado.Text = "PERDISTE LA RONDA!";
                    puntajeAI += 1;
                    TXTAI.Text = puntajeAI.ToString();
                }
                if (RBPiedraJG.Checked == true)
                {
                    LBLResultado.Text = "GANASTE LA RONDA!";
                    puntajeJugador += 1;
                    TXTJG.Text = puntajeJugador.ToString();
                }
                }
            else if (AI == 3)
            {
                RBPiedraAI.Checked = true;
                if (RBTijerasJG.Checked == true)
                {
                    LBLResultado.Text = "PERDISTE LA RONDA!";
                    puntajeAI += 1;
                    TXTAI.Text = puntajeAI.ToString();
                }
                if (RBPapelJG.Checked == true)
                {
                    LBLResultado.Text = "GANASTE LA RONDA!";
                    puntajeJugador += 1;
                    TXTJG.Text = puntajeJugador.ToString();
                }
                if (RBPiedraJG.Checked == true)
                {
                    LBLResultado.Text = "EMPATE!";
                }
            }
            else
            {
                LBLResultado.Text = "NO ELEGISTES NADA...";
            }

            if (puntajeAI > 3)
            {
                puntajeJugador = 0;
                puntajeAI = 0;
                LBLResultado.Text = "OOPS HAS PERDIDO!";
            }
            if (puntajeJugador > 3)
            {   
                puntajeJugador = 0;
                puntajeAI = 0;
                LBLResultado.Text = "FELICIDADES TU OPONENTE \nHA SIDO VENCIDO!";
            }

        }
    }
}
