namespace Escritura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lectura y escritura de un String
            System.Console.WriteLine("¿Cual es tu nombre?: ");
            string nombre = System.Console.ReadLine();
            System.Console.WriteLine($"Tu nombre es {nombre}");

            //Lectura y escritura de un Int
            System.Console.WriteLine("¿Cual es tu edad?:");
            int edad = System.Int16.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"Tu tienes {edad} años.");

            //Lectura y escritura de un float
            System.Console.WriteLine("¿Cuanto mides?");
            decimal altura = System.Decimal.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"Tu altura es {altura} metros");

            //pasar de valor numerico a valor numerico
            double numero = 5.345874;
            System.Console.WriteLine(numero);
            int conversion = System.Convert.ToInt16(numero);
            System.Console.WriteLine(conversion);

            System.Console.ReadKey();
        }//Fin del metodo Main
    }//Fin de la clase Program
}//Fin del namespace
