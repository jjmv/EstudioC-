namespace Inicio
{
    class Lectura
    {
        static void Main(string[] args)
        {
            System.Console.Write("Hola Mundo");
            System.Console.WriteLine("Hola Mundo con Write Line 2");

            string palabra = "Palabra por parametros";
            System.Console.WriteLine(palabra);

            short dia = 19, mes = 12, año = 2016;

            System.Console.WriteLine("El día es: {0}", dia);
            System.Console.WriteLine("La fecha es: {0}/{1}/{2}", dia, mes, año);

            System.Console.WriteLine($"El dia es {dia} , el mes es {mes}, el año es {año}");

            float punto1 = 5.5f;
            decimal decimal1 = 7.65M;
            double variable_doble = 7.5;

            System.Console.ReadKey();
        }//Fin del método Main

    }//Fin de Clase Program

}//Fin del NameSpace