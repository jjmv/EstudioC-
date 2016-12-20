namespace Funciones
{
    class functions
    {
        static void Main(string[] args)
        {
            double Base = 5, Altura = 7.5;
            double area = Rectangulo(Base, Altura);

            System.Console.WriteLine(area);


            System.Console.ReadKey();
        }//Fin del metodo Main



        public static double Rectangulo(double Base, double Altura)
        {

            double resultado = Base * Altura;
            return resultado;
        }//Fin de la funcion Rectangulo()

    }//Fin de la clase functions
}//Fin del namespace