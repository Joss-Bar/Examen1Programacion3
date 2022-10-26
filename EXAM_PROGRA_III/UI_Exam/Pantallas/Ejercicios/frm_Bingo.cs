using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Exam.Bingo;
using DAL_Exam.Bingo;

namespace UI_Exam.Pantallas.Ejercicios
{
    public partial class frm_Bingo : Form
    {
        #region VARIABLES GLOBALES

            cls_Juego_BLL Obj_Juego_BLL = new cls_Juego_BLL();
            cls_Juego_DAL Obj_Juego_DAL = new cls_Juego_DAL();

        #endregion

        #region EVENTOS

            public frm_Bingo()
            {
                InitializeComponent();
            }

            private void frm_Bingo_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (MessageBox.Show("Desea regresar a la pantalla de ingreso...???", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

            private void btn_Iniciar_Click(object sender, EventArgs e)
            {
                if (rbt_CuatroEsquinas.Checked)
                {
                    Obj_Juego_DAL.bOpcJuego = 1;
                }

                if (rbt_T.Checked)
                {
                    Obj_Juego_DAL.bOpcJuego = 2;
                }

                if (rbt_X.Checked)
                {
                    Obj_Juego_DAL.bOpcJuego = 3;
                }

                //Llama al metodo del BLL para generar el cartón aleatorio
                Obj_Juego_BLL.GenerarResultadoPartida(ref Obj_Juego_DAL);

                //llama al metodo hecho en el PL para desplegar los datos en pantalla
                LlenarCarton();

                rbt_CuatroEsquinas.Enabled = false;
                rbt_T.Enabled = false;
                rbt_X.Enabled = false;
                gbx_Partida.Visible = true;
                btn_Iniciar.Enabled = false;

            }

            private void btn_Limpiar_Click(object sender, EventArgs e)
            {
                gbx_Partida.Visible = false;
                rbt_CuatroEsquinas.Enabled = true;
                rbt_T.Enabled = true;
                rbt_X.Enabled = true;
                btn_Iniciar.Enabled = true;
            }

        #endregion

        #region EVENTOS   

            private void LlenarCarton()
            {
                switch (Obj_Juego_DAL.bOpcJuego)
                {
                    case 1:
                        {
                            #region MOSTAR JUEGO 4 ESQUINAS
                        
                                lbl_A.Text = Obj_Juego_DAL.arrFigura_IV_Esquinas[0].ToString();
                                lbl_A.BackColor = Color.Blue;
                                lbl_A.ForeColor = Color.White;

                                lbl_B.Text = Obj_Juego_DAL.arrCartonCompleto[0].ToString();
                                lbl_B.BackColor = Color.White;
                                lbl_B.ForeColor = Color.Black;

                                lbl_C.Text = Obj_Juego_DAL.arrCartonCompleto[1].ToString();
                                lbl_C.BackColor = Color.White;
                                lbl_C.ForeColor = Color.Black;

                                lbl_D.Text = Obj_Juego_DAL.arrCartonCompleto[2].ToString();
                                lbl_D.BackColor = Color.White;
                                lbl_D.ForeColor = Color.Black;

                                lbl_E.Text = Obj_Juego_DAL.arrFigura_IV_Esquinas[1].ToString();
                                lbl_E.BackColor = Color.Blue;
                                lbl_E.ForeColor = Color.White;

                                lbl_F.Text = Obj_Juego_DAL.arrCartonCompleto[3].ToString();
                                lbl_F.BackColor = Color.White;
                                lbl_F.ForeColor = Color.Black;

                                lbl_G.Text = Obj_Juego_DAL.arrCartonCompleto[4].ToString();
                                lbl_G.BackColor = Color.White;
                                lbl_G.ForeColor = Color.Black;

                                lbl_H.Text = Obj_Juego_DAL.arrCartonCompleto[5].ToString();
                                lbl_H.BackColor = Color.White;
                                lbl_H.ForeColor = Color.Black;

                                lbl_I.Text = Obj_Juego_DAL.arrCartonCompleto[6].ToString();
                                lbl_I.BackColor = Color.White;
                                lbl_I.ForeColor = Color.Black;

                                lbl_J.Text = Obj_Juego_DAL.arrCartonCompleto[7].ToString();
                                lbl_J.BackColor = Color.White;
                                lbl_J.ForeColor = Color.Black;

                                lbl_K.Text = Obj_Juego_DAL.arrCartonCompleto[8].ToString();
                                lbl_K.BackColor = Color.White;
                                lbl_K.ForeColor = Color.Black;

                                lbl_L.Text = Obj_Juego_DAL.arrCartonCompleto[9].ToString();
                                lbl_L.BackColor = Color.White;
                                lbl_L.ForeColor = Color.Black;

                                lbl_M.Text = Obj_Juego_DAL.arrCartonCompleto[10].ToString();
                                lbl_M.BackColor = Color.White;
                                lbl_M.ForeColor = Color.Black;

                                lbl_N.Text = Obj_Juego_DAL.arrCartonCompleto[11].ToString();
                                lbl_N.BackColor = Color.White;
                                lbl_N.ForeColor = Color.Black;

                                lbl_O.Text = Obj_Juego_DAL.arrCartonCompleto[12].ToString();
                                lbl_O.BackColor = Color.White;
                                lbl_O.ForeColor = Color.Black;

                                lbl_P.Text = Obj_Juego_DAL.arrCartonCompleto[13].ToString();
                                lbl_P.BackColor = Color.White;
                                lbl_P.ForeColor = Color.Black;

                                lbl_Q.Text = Obj_Juego_DAL.arrCartonCompleto[14].ToString();
                                lbl_Q.BackColor = Color.White;
                                lbl_Q.ForeColor = Color.Black;

                                lbl_R.Text = Obj_Juego_DAL.arrCartonCompleto[15].ToString();
                                lbl_R.BackColor = Color.White;
                                lbl_R.ForeColor = Color.Black;

                                lbl_S.Text = Obj_Juego_DAL.arrCartonCompleto[16].ToString();
                                lbl_S.BackColor = Color.White;
                                lbl_S.ForeColor = Color.Black;

                                lbl_T.Text = Obj_Juego_DAL.arrFigura_IV_Esquinas[2].ToString();
                                lbl_T.BackColor = Color.Blue;
                                lbl_T.ForeColor = Color.White;

                                lbl_U.Text = Obj_Juego_DAL.arrCartonCompleto[17].ToString();
                                lbl_U.BackColor = Color.White;
                                lbl_U.ForeColor = Color.Black;

                                lbl_V.Text = Obj_Juego_DAL.arrCartonCompleto[18].ToString();
                                lbl_V.BackColor = Color.White;
                                lbl_V.ForeColor = Color.Black;

                                lbl_W.Text = Obj_Juego_DAL.arrCartonCompleto[19].ToString();
                                lbl_W.BackColor = Color.White;
                                lbl_W.ForeColor = Color.Black;                              

                                lbl_X.Text = Obj_Juego_DAL.arrFigura_IV_Esquinas[3].ToString();
                                lbl_X.BackColor = Color.Blue;
                                lbl_X.ForeColor = Color.White;

                                lbl_Free.BackColor = Color.White;
                                lbl_Free.ForeColor = Color.Black;

                            #endregion

                            break;
                        }
                    case 2:
                        {
                            #region MOSTAR JUEGO T

                                lbl_A.Text = Obj_Juego_DAL.arrFigura_T[0].ToString();
                                lbl_A.BackColor = Color.Blue;
                                lbl_A.ForeColor = Color.White;

                                lbl_B.Text = Obj_Juego_DAL.arrFigura_T[1].ToString();
                                lbl_B.BackColor = Color.Blue;
                                lbl_B.ForeColor = Color.White;

                                lbl_C.Text = Obj_Juego_DAL.arrFigura_T[2].ToString();
                                lbl_C.BackColor = Color.Blue;
                                lbl_C.ForeColor = Color.White;

                                lbl_D.Text = Obj_Juego_DAL.arrFigura_T[3].ToString();
                                lbl_D.BackColor = Color.Blue;
                                lbl_D.ForeColor = Color.White;

                                lbl_E.Text = Obj_Juego_DAL.arrFigura_T[4].ToString();
                                lbl_E.BackColor = Color.Blue;
                                lbl_E.ForeColor = Color.White;

                                lbl_F.Text = Obj_Juego_DAL.arrCartonCompleto[0].ToString();
                                lbl_F.BackColor = Color.White;
                                lbl_F.ForeColor = Color.Black;

                                lbl_G.Text = Obj_Juego_DAL.arrCartonCompleto[1].ToString();
                                lbl_G.BackColor = Color.White;
                                lbl_G.ForeColor = Color.Black;

                                lbl_H.Text = Obj_Juego_DAL.arrFigura_T[5].ToString();
                                lbl_H.BackColor = Color.Blue;
                                lbl_H.ForeColor = Color.White;

                                lbl_I.Text = Obj_Juego_DAL.arrCartonCompleto[2].ToString();
                                lbl_I.BackColor = Color.White;
                                lbl_I.ForeColor = Color.Black;

                                lbl_J.Text = Obj_Juego_DAL.arrCartonCompleto[3].ToString();
                                lbl_J.BackColor = Color.White;
                                lbl_J.ForeColor = Color.Black;

                                lbl_K.Text = Obj_Juego_DAL.arrCartonCompleto[4].ToString();
                                lbl_K.BackColor = Color.White;
                                lbl_K.ForeColor = Color.Black;

                                lbl_L.Text = Obj_Juego_DAL.arrCartonCompleto[5].ToString();
                                lbl_L.BackColor = Color.White;
                                lbl_L.ForeColor = Color.Black;

                                lbl_M.Text = Obj_Juego_DAL.arrCartonCompleto[6].ToString();
                                lbl_M.BackColor = Color.White;
                                lbl_M.ForeColor = Color.Black;

                                lbl_N.Text = Obj_Juego_DAL.arrCartonCompleto[7].ToString();
                                lbl_N.BackColor = Color.White;
                                lbl_N.ForeColor = Color.Black;

                                lbl_O.Text = Obj_Juego_DAL.arrCartonCompleto[8].ToString();
                                lbl_O.BackColor = Color.White;
                                lbl_O.ForeColor = Color.Black;

                                lbl_P.Text = Obj_Juego_DAL.arrCartonCompleto[9].ToString();
                                lbl_P.BackColor = Color.White;
                                lbl_P.ForeColor = Color.Black;

                                lbl_Q.Text = Obj_Juego_DAL.arrFigura_T[6].ToString();
                                lbl_Q.BackColor = Color.Blue;
                                lbl_Q.ForeColor = Color.White;

                                lbl_R.Text = Obj_Juego_DAL.arrCartonCompleto[10].ToString();
                                lbl_R.BackColor = Color.White;
                                lbl_R.ForeColor = Color.Black;

                                lbl_S.Text = Obj_Juego_DAL.arrCartonCompleto[11].ToString();
                                lbl_S.BackColor = Color.White;
                                lbl_S.ForeColor = Color.Black;

                                lbl_T.Text = Obj_Juego_DAL.arrCartonCompleto[12].ToString();
                                lbl_T.BackColor = Color.White;
                                lbl_T.ForeColor = Color.Black;

                                lbl_U.Text = Obj_Juego_DAL.arrCartonCompleto[13].ToString();
                                lbl_U.BackColor = Color.White;
                                lbl_U.ForeColor = Color.Black;

                                lbl_V.Text = Obj_Juego_DAL.arrFigura_T[7].ToString();
                                lbl_V.BackColor = Color.Blue;
                                lbl_V.ForeColor = Color.White;

                                lbl_W.Text = Obj_Juego_DAL.arrCartonCompleto[14].ToString();
                                lbl_W.BackColor = Color.White;
                                lbl_W.ForeColor = Color.Black;

                                lbl_X.Text = Obj_Juego_DAL.arrCartonCompleto[15].ToString();
                                lbl_X.BackColor = Color.White;
                                lbl_X.ForeColor = Color.Black;

                                lbl_Free.BackColor = Color.Blue;
                                lbl_Free.ForeColor = Color.White;

                        #endregion

                            break;
                        }
                    case 3:
                        {
                            #region MOSTAR JUEGO X

                                lbl_A.Text = Obj_Juego_DAL.arrFigura_X[0].ToString();
                                lbl_A.BackColor = Color.Blue;
                                lbl_A.ForeColor = Color.White;

                                lbl_B.Text = Obj_Juego_DAL.arrCartonCompleto[0].ToString();
                                lbl_B.BackColor = Color.White;
                                lbl_B.ForeColor = Color.Black;

                                lbl_C.Text = Obj_Juego_DAL.arrCartonCompleto[1].ToString();
                                lbl_C.BackColor = Color.White;
                                lbl_C.ForeColor = Color.Black;

                                lbl_D.Text = Obj_Juego_DAL.arrCartonCompleto[2].ToString();
                                lbl_D.BackColor = Color.White;
                                lbl_D.ForeColor = Color.Black;

                                lbl_E.Text = Obj_Juego_DAL.arrFigura_X[1].ToString();
                                lbl_E.BackColor = Color.Blue;
                                lbl_E.ForeColor = Color.White;

                                lbl_F.Text = Obj_Juego_DAL.arrCartonCompleto[3].ToString();
                                lbl_F.BackColor = Color.White;
                                lbl_F.ForeColor = Color.Black;

                                lbl_G.Text = Obj_Juego_DAL.arrFigura_X[2].ToString();
                                lbl_G.BackColor = Color.Blue;
                                lbl_G.ForeColor = Color.White;

                                lbl_H.Text = Obj_Juego_DAL.arrCartonCompleto[4].ToString();
                                lbl_H.BackColor = Color.White;
                                lbl_H.ForeColor = Color.Black;

                                lbl_I.Text = Obj_Juego_DAL.arrFigura_X[3].ToString();
                                lbl_I.BackColor = Color.Blue;
                                lbl_I.ForeColor = Color.White;

                                lbl_J.Text = Obj_Juego_DAL.arrCartonCompleto[5].ToString();
                                lbl_J.BackColor = Color.White;
                                lbl_J.ForeColor = Color.Black;

                                lbl_K.Text = Obj_Juego_DAL.arrCartonCompleto[6].ToString();
                                lbl_K.BackColor = Color.White;
                                lbl_K.ForeColor = Color.Black;

                                lbl_L.Text = Obj_Juego_DAL.arrCartonCompleto[7].ToString();
                                lbl_L.BackColor = Color.White;
                                lbl_L.ForeColor = Color.Black;

                                lbl_M.Text = Obj_Juego_DAL.arrCartonCompleto[8].ToString();
                                lbl_M.BackColor = Color.White;
                                lbl_M.ForeColor = Color.Black;

                                lbl_N.Text = Obj_Juego_DAL.arrCartonCompleto[9].ToString();
                                lbl_N.BackColor = Color.White;
                                lbl_N.ForeColor = Color.Black;

                                lbl_O.Text = Obj_Juego_DAL.arrCartonCompleto[10].ToString();
                                lbl_O.BackColor = Color.White;
                                lbl_O.ForeColor = Color.Black;

                                lbl_P.Text = Obj_Juego_DAL.arrFigura_X[4].ToString();
                                lbl_P.BackColor = Color.Blue;
                                lbl_P.ForeColor = Color.White;

                                lbl_Q.Text = Obj_Juego_DAL.arrCartonCompleto[50].ToString();
                                lbl_Q.BackColor = Color.White;
                                lbl_Q.ForeColor = Color.Black;

                                lbl_R.Text = Obj_Juego_DAL.arrFigura_X[5].ToString();
                                lbl_R.BackColor = Color.Blue;
                                lbl_R.ForeColor = Color.White;

                                lbl_S.Text = Obj_Juego_DAL.arrCartonCompleto[12].ToString();
                                lbl_S.BackColor = Color.White;
                                lbl_S.ForeColor = Color.Black;

                                lbl_T.Text = Obj_Juego_DAL.arrFigura_X[6].ToString();
                                lbl_T.BackColor = Color.Blue;
                                lbl_T.ForeColor = Color.White;

                                lbl_U.Text = Obj_Juego_DAL.arrCartonCompleto[13].ToString();
                                lbl_U.BackColor = Color.White;
                                lbl_U.ForeColor = Color.Black;

                                lbl_V.Text = Obj_Juego_DAL.arrCartonCompleto[14].ToString();
                                lbl_V.BackColor = Color.White;
                                lbl_V.ForeColor = Color.Black;

                                lbl_W.Text = Obj_Juego_DAL.arrCartonCompleto[15].ToString();
                                lbl_W.BackColor = Color.White;
                                lbl_W.ForeColor = Color.Black;

                                lbl_X.Text = Obj_Juego_DAL.arrFigura_X[45].ToString();
                                lbl_X.BackColor = Color.Blue;
                                lbl_X.ForeColor = Color.White;

                                lbl_Free.BackColor = Color.Blue;
                                lbl_Free.ForeColor = Color.White;

                            #endregion

                            break;
                        }
                    default:
                        break;
                }
            }

        #endregion
    }
}
