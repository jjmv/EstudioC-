namespace Pantalla
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Title = "Programa1"; //Cambia el titulo de pantalla de la consola
            System.Console.BackgroundColor = System.ConsoleColor.Gray;  //Para elegir color de fondo
            System.Console.Clear();  //Para cambiar color

            System.Console.ForegroundColor = System.ConsoleColor.Blue;  //Para elegir el color de letra

            System.Console.SetCursorPosition(6, 2);
            System.Console.Write("Nombre");
            System.Console.SetCursorPosition(6, 4);
            System.Console.Write("Dirección");
            System.Console.SetCursorPosition(6, 6);
            System.Console.Write("Telefono");


            System.Console.SetCursorPosition(18, 2);
            string nombre = System.Console.ReadLine();
            System.Console.SetCursorPosition(18, 4);
            string direccion = System.Console.ReadLine();
            System.Console.SetCursorPosition(18, 6);
            string telefono = System.Console.ReadLine();


            System.Console.ReadKey();
        }//fin del metodo Main
    }//Fin de la clase 
}//fin del namespace