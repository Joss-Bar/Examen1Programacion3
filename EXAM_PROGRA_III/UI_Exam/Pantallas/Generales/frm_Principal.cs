using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Exam.Pantallas.Ejercicios;


namespace UI_Exam.Pantallas.Generales
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void pbx_Ejercicios_Click(object sender, EventArgs e)
        {
            frm_Bingo mipantalla = new frm_Bingo();
            mipantalla.ShowDialog();

        }

        private void pbx_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea Salir Realmente de la Aplicación...???", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
