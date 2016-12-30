using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    public class clEmpleados
    {
        //Constructor se ejecuta automatico
        public clEmpleados()
        {
            Nombre = "";
            SueldoDiario = 0.0M;
            Edad = 0;
        }

        //ATRIBUTOS
        public string Nombre;

        public decimal SueldoDiario;

        public int Edad;

        //METODOS

        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }

    }
}
