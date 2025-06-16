using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Clase
{
    public partial class APDescuento : Form
    {
        double descuento;
        public APDescuento()
        {
            InitializeComponent();
        }

        private void TXTBPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLPrecio_Click(object sender, EventArgs e)
        {

        }

        private void APDescuento_Load(object sender, EventArgs e)
        {

        }

        private void BTNCalcular_Click(object sender, EventArgs e)
        {
            double resultado, precio;
            precio = double.Parse(TXTBPrecio.Text);
            if (string.IsNullOrEmpty(TXTBPrecio.Text))
            {
                MessageBox.Show("Por favor no dejes campos vacios");
            }
            else
            {
                precio = double.Parse(TXTBPrecio.Text);
                if (RB5.Checked == true)
                {
                    TXTBTotal.BackColor = Color.White;
                    TXTBTotal.ForeColor = Color.Black;
                    descuento = 0.05 * precio;
                    resultado = precio - descuento;
                    TXTBTotal.Text = resultado.ToString("N2");
                }
                else if (RB15.Checked == true)
                {
                    TXTBTotal.BackColor = Color.White;
                    TXTBTotal.ForeColor = Color.Black;
                    descuento = 0.15 * precio;
                    resultado = precio - descuento;
                    TXTBTotal.Text = resultado.ToString("N2");
                }
                else if (RB20.Checked == true)
                {
                    TXTBTotal.BackColor = Color.White;
                    TXTBTotal.ForeColor = Color.Black;
                    descuento = 0.20 * precio;
                    resultado = precio - descuento;
                    TXTBTotal.Text = resultado.ToString("N2");
                }
                else
                {
                    LBLError.ForeColor = Color.Red;
                    TXTBTotal.BackColor = Color.Black;
                    TXTBTotal.ForeColor = Color.Yellow;
                    LBLError.Text = "No se aplico ningun descuento 😥";
                    TXTBTotal.Text = precio.ToString();
                }
                }
        }
    }
}
