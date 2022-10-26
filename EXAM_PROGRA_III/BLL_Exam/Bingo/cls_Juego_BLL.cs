using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Exam.Bingo;

namespace BLL_Exam.Bingo
{
    public class cls_Juego_BLL
    {
        public void GenerarResultadoPartida(ref cls_Juego_DAL Obj_Bingo_DAL)
        {
            Obj_Bingo_DAL.ranNumeros = new Random();

            switch (Obj_Bingo_DAL.bOpcJuego)
            {
                case 1:
                    {
                        // JUEGO CARTÓN EN 4 ESQUINAS
                        Juego_IV_Esquinas(ref Obj_Bingo_DAL);
                        break;
                    }
                case 2:
                    {
                        // JUEGO CARTÓN EN "T"
                        Juego_T(ref Obj_Bingo_DAL);
                        break;
                    }
                case 3:
                    {
                        // JUEGO CARTÓN EN "X"                        
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void Juego_IV_Esquinas(ref cls_Juego_DAL Obj_Bingo_DAL)
        {
            try
            {                
                Obj_Bingo_DAL.arrCartonCompleto = new byte[20];

                for (int i = 0; i < Obj_Bingo_DAL.arrCartonCompleto.Length; i++)
                {
                    Obj_Bingo_DAL.bNumBolita = Convert.ToByte(Obj_Bingo_DAL.ranNumeros.Next(0, 100));

                    if (Obj_Bingo_DAL.arrCartonCompleto.Contains(Obj_Bingo_DAL.bNumBolita))
                    {
                        i--;
                    }                    
                }

                for (int i = 0; i < Obj_Bingo_DAL.arrFigura_IV_Esquinas.Length; i++)
                {
                    Obj_Bingo_DAL.bNumBolita = Convert.ToByte(Obj_Bingo_DAL.ranNumeros.Next(0, 100));

                    if (Obj_Bingo_DAL.arrFigura_IV_Esquinas.Contains(Obj_Bingo_DAL.bNumBolita))
                    {
                        i--;
                    }
                    else
                    {
                        if ((Obj_Bingo_DAL.bNumBolita % 2) == 0)
                        {
                            Obj_Bingo_DAL.arrFigura_IV_Esquinas[i] = Obj_Bingo_DAL.bNumBolita;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Obj_Bingo_DAL.sMsjError = ex.Message.ToString();
            }
        }

        private void Juego_X(ref cls_Juego_DAL Obj_Bingo_DAL)
        {
            try
            {
                Obj_Bingo_DAL.arrFigura_X = new byte[8];
                Obj_Bingo_DAL.arrCartonCompleto = new byte[16];

                for (int i = 0; i < Obj_Bingo_DAL.arrCartonCompleto.Length; i++)
                {
                    Obj_Bingo_DAL.bNumBolita = Convert.ToByte(Obj_Bingo_DAL.ranNumeros.Next(0, 100));

                    if (Obj_Bingo_DAL.arrCartonCompleto.Contains(Obj_Bingo_DAL.bNumBolita))
                    {
                        i--;
                    }
                }

                for (int i = 0; i < Obj_Bingo_DAL.arrFigura_X.Length; i++)
                {
                    Obj_Bingo_DAL.bNumBolita = Convert.ToByte(Obj_Bingo_DAL.ranNumeros.Next(0, 100));

                    if (Obj_Bingo_DAL.arrFigura_X.Contains(Obj_Bingo_DAL.bNumBolita))
                    {
                        i--;
                    }
                    else
                    {
                        if ((Obj_Bingo_DAL.bNumBolita % 2) != 0)
                        {
                            Obj_Bingo_DAL.arrFigura_X[i] = Obj_Bingo_DAL.bNumBolita;
                        }                       
                    }
                }
            }
            catch (Exception ex)
            {
                Obj_Bingo_DAL.sMsjError = ex.Message.ToString();
            }
        }

        private void Juego_T(ref cls_Juego_DAL Obj_Bingo_DAL)
        {
            try
            {
                Obj_Bingo_DAL.arrFigura_T = new byte[8];
                Obj_Bingo_DAL.arrCartonCompleto = new byte[16];

                for (int i = 0; i < Obj_Bingo_DAL.arrCartonCompleto.Length; i++)
                {
                    Obj_Bingo_DAL.bNumBolita = Convert.ToByte(Obj_Bingo_DAL.ranNumeros.Next(0, 100));

                    if (Obj_Bingo_DAL.arrCartonCompleto.Contains(Obj_Bingo_DAL.bNumBolita))
                    {
                        i--;
                    }
                    else
                    {
                        Obj_Bingo_DAL.arrCartonCompleto[i] = Obj_Bingo_DAL.bNumBolita;
                    }
                }

                for (int i = 0; i < Obj_Bingo_DAL.arrFigura_T.Length; i++)
                {
                    Obj_Bingo_DAL.bNumBolita = Convert.ToByte(Obj_Bingo_DAL.ranNumeros.Next(0, 100));

                    if (Obj_Bingo_DAL.arrFigura_T.Contains(Obj_Bingo_DAL.bNumBolita))
                    {
                        i--;
                    }
                    else
                    {
                        if ((Obj_Bingo_DAL.bNumBolita % 2) == 0)
                        {
                            Obj_Bingo_DAL.arrFigura_T[i] = Obj_Bingo_DAL.bNumBolita;
                        }                       
                    }
                }
            }
            catch (Exception ex)
            {
                Obj_Bingo_DAL.sMsjError = ex.Message.ToString();
            }
        }
    }
}

