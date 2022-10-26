using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cap_Negocios;


namespace Cap_Presentacion
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }
        
        Cls_Entidades OjbEnt = new Cls_Entidades();

        private void mObtenerpromedio()
        {
           // V_salariobase,V_montoventa,V_porcentaje,V_cant_venta
            OjbEnt.V_salariobase = Double.Parse(txtsalario_base.Text);
            OjbEnt.V_montoventa = Double.Parse(txtmonto_venta.Text);
            OjbEnt.V_porcentaje = Decimal.ToDouble(nudporcentaje_comision.Value);
            OjbEnt.V_cant_venta = Decimal.ToDouble(nudcantidadventas.Value);
            txtSalario_Neto.Text = OjbEnt.m_obtener_salario().ToString();
            
        }

        private void rbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularsalario_Click(object sender, EventArgs e)
        {
            mObtenerpromedio();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
                     
            this.Close ();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nudporcentaje_comision_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
