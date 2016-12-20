
namespace OperadoresBool
{
    class operadorbool2
    {
        static void Main(string[] args)
        {

            int calificacion1 = 65;
            int calificacion2 = 85;
            if ((calificacion1 >= 70 && calificacion1 <= 100) && (calificacion2 >= 70 && calificacion2 <= 100)) System.Console.WriteLine("Aprobado");
            else System.Console.WriteLine("Reprobado");

            System.Console.ReadKey();

        }//Final de metodo Main
    }//Final de clase operadorbool
}//Final de namespace

