using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_Datos
{
    public class Cls_Planilla
    {
        public Double m_calculosalario(double salario_base,double monto_venta,double porcentaje, double cantidad_venta)
        {

            Double salario = salario_base+(monto_venta*(porcentaje/100)*cantidad_venta);
            return salario;

        }

    }
}
