
using Cap_Datos;


namespace Cap_Negocios
{
    
    public class Cls_Entidades
    {
        Cls_Planilla Objplanilla = new Cls_Planilla();

        private double v_salario, v_salariobase,v_montoventa,v_porcentaje, v_cant_venta;

        public double V_salario { get => v_salario; set => v_salario = value; }
        public double V_salariobase { get => v_salariobase; set => v_salariobase = value; }
        public double V_montoventa { get => v_montoventa; set => v_montoventa = value; }
        public double V_porcentaje { get => v_porcentaje; set => v_porcentaje = value; }
        public double V_cant_venta { get => v_cant_venta; set => v_cant_venta = value; }

        public double m_obtener_salario()
        {
            double vObenter = Objplanilla.m_calculosalario(V_salariobase,V_montoventa,V_porcentaje,V_cant_venta);
            return vObenter;
        }

    }
}
