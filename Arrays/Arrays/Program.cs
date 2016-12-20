namespace Arrays
    {
    class Program
    {
        static void Main(string[] args)
        {

            int[] arregloUnidimensional = new int[3];

            arregloUnidimensional[0] = 1;
            arregloUnidimensional[1] = 2;
            arregloUnidimensional[2] = 3;

            string[] stringArray = { "Uno", "Dos", "Tres" }; //Asignar valores desde código
            System.Console.WriteLine(stringArray[2]);

            //Lectura y escritura de arrays
            int count;
            for(count = 0; count <= 2; count++)
            {
                System.Console.WriteLine($"Escribe el valor para la posicion {count} de tu arreglo");
                stringArray[count] = System.Console.ReadLine();
            }//Fin del For para el array


            //Lectura  de arrays
            int lecturaUnidimensional = stringArray.Length;

            for(count = 0; count <= lecturaUnidimensional - 1 ; count++)
            {
                System.Console.WriteLine($"El valor del arreglo unidimensional en la posicion {count} tiene el valor {stringArray[count]}");
            }//Fin del for


            //Lectura de arrays 2
            foreach(string lectura in stringArray)
            {
                System.Console.WriteLine(lectura);
            }//Fin del foreach


            //-----Arreglos Multidimensionales
            int[,] arregloMultidimensional = new int[3,3];
            //Llenado de columna 1
            arregloMultidimensional[0, 0] = 1;
            arregloMultidimensional[1, 0] = 2;
            arregloMultidimensional[2, 0] = 3;

            //Llenado de columna 2
            arregloMultidimensional[0, 1] = 4;
            arregloMultidimensional[1, 1] = 5;
            arregloMultidimensional[2, 1] = 6;

            //Llenado de columna 3
            arregloMultidimensional[0, 2] = 7;
            arregloMultidimensional[1, 2] = 8;
            arregloMultidimensional[2, 2] = 9;

            string[,] arregloMultidimensional2 = { {"uno-f1","dos-f1","tres-f1" }, {"uno-f2", "dos-f2", "tres-f2" } };

            //Escritura en arreglo multidimensional
            int fila = 1, columnas = 2;
            int i, j;

            for(i = 0; i<=fila; i++)
            {
                for(j = 0; j <= columnas; j++)
                {

                    System.Console.WriteLine($"Asignar valor para la posicion {i}, {j}");
                    arregloMultidimensional2[i, j] = System.Console.ReadLine(); 
                }//Fin del for para columnas
            }//fin del for para fila


            //Lectura de arreglo multidimensional

            for(i = 0; i <= fila; i++)
            {
                for (j = 0; j <= columnas; j++)
                {

                    System.Console.WriteLine($"El valor asignado a arregloMultidimensional2 [{i},{j}] es: {arregloMultidimensional2[i,j]}");
                   
                }//Fin del for para columnas
            }//fin del for para fila







            System.Console.ReadKey();
        }//Fin del metodo Main
    }//Fin de la clase
}//Fin de namespace