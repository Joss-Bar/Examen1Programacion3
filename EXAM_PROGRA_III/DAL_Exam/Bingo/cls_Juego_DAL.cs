using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Exam.Bingo
{
    public class cls_Juego_DAL
    {
        #region VARIABLES PRIVADAS

            private Random _ranNumeros;
            private byte[] _arrCartonCompleto, _arrFigura_X, _arrFigura_T, _arrFigura_IV_Esquinas;
            private byte _bOpcJuego, _bNumBolita;
            private string _sMsjError;

        #endregion

        #region CONSTRUCTORES O VARIABLES PÚBLICAS

            public Random ranNumeros { get => _ranNumeros; set => _ranNumeros = value; }
            public byte[] arrCartonCompleto { get => _arrCartonCompleto; set => _arrCartonCompleto = value; }
            public byte[] arrFigura_X { get => _arrFigura_X; set => _arrFigura_X = value; }
            public byte[] arrFigura_T { get => _arrFigura_T; set => _arrFigura_T = value; }
            public byte[] arrFigura_IV_Esquinas { get => _arrFigura_IV_Esquinas; set => _arrFigura_IV_Esquinas = value; }
            public byte bOpcJuego { get => _bOpcJuego; set => _bOpcJuego = value; }
            public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
            public byte bNumBolita { get => _bNumBolita; set => _bNumBolita = value; }

        #endregion
    }
}
