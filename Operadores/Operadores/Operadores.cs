namespace Operadores
{
    class Operadores
    {
        static void Main (string[] args)
        {
            int i;
            string Star = "*";

            for (i = 1; i <= 10; i++)
            {
                System.Console.WriteLine(Star);
                Star += "*";
            }//Final del For


            System.Console.ReadKey();
        }//Fin del método Main
    }//Fin del Método Operadores
}//Fin del namespace