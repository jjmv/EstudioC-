using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion del objeto empleado
            clEmpleados empleado;
            //Aqui se instancia el objeto
            empleado = new clEmpleados();

            empleado.Edad = 25;
            empleado.Nombre = "Javier";
            empleado.SueldoDiario = 12.5m;
            decimal total;
            total = empleado.CalculaSalario(30);
            System.Console.WriteLine($"El salario mensual de {empleado.Nombre}");
            System.Console.WriteLine($"Es de {total}");
            System.Console.ReadKey();
        }
    }
}
