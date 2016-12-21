using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Area de figuras";
            int opcionMenu1;
            do
            {
                Menu1();
                Console.SetCursorPosition(60, 4);
                opcionMenu1 = Convert.ToInt16(Console.ReadLine());
                switch (opcionMenu1)
                {
                    case 1: MenuTriangulo();
                        break;
                    default: break;

                    case 2: MenuCirculo();
                        break;
                    

                    case 3: MenuRectangulo();
                        break;
                   

                    case 4: MenuCuadrado();
                        break;
                  


                }
            } while (opcionMenu1 != 5);  //FIN DEL DO WHILE

            Console.ReadKey();
            
        }//Fin del metodo Main

        static void Menu1()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            MarcoMenu1();

            Console.SetCursorPosition(40, 3);
            System.Console.Write("Area de figuras geometricas");
            Console.SetCursorPosition(40, 4);
            Console.Write("Elija una opción");

            Console.SetCursorPosition(35, 6);
            Console.Write("1- Triangulo");
            Console.SetCursorPosition(35, 8);
            Console.Write("2- Circulo");
            Console.SetCursorPosition(35, 10);
            Console.Write("3- Rectangulo");
            Console.SetCursorPosition(35, 12);
            Console.Write("4- Cuadrado");
            Console.SetCursorPosition(35, 14);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("5- Salir");

        }//Fin del metodo menu

        static void MarcoMenu1()
        {
            int x, y;
            for(x = 34; x <= 70; x++)
            {
                Console.SetCursorPosition(x, 2);
                Console.Write("-");
            }//Fin del dibujado de linea superior
            for(x = 34; x <= 70; x++)
            {
                Console.SetCursorPosition(x, 15);
                Console.Write("-");
            }
            for (x = 34; x <= 70; x++)
            {
                Console.SetCursorPosition(x, 5);
                Console.Write("-");
            }
            Console.SetCursorPosition(33, 2);
            Console.Write("*");
            Console.SetCursorPosition(71, 2);
            Console.Write("*");
            Console.SetCursorPosition(33, 5);
            Console.Write("*");
            Console.SetCursorPosition(71, 5);
            Console.Write("*");

            for(y = 3; y <= 14; y++)
            {
                Console.SetCursorPosition(33, y);
                Console.Write("|");
            }
            for (y = 3; y <= 14; y++)
            {
                Console.SetCursorPosition(71, y);
                Console.Write("|");
            }

        }//Fin del metodo MarcoMenu1

        static void MarcoFiguras()
        {
            int x, y;
            for (x = 34; x <= 70; x++)
            {
                Console.SetCursorPosition(x, 2);
                Console.Write("-");
            }//Fin del dibujado de linea superior
            for (x = 34; x <= 70; x++)
            {
                Console.SetCursorPosition(x, 8);
                Console.Write("-");
            }
            for (x = 34; x <= 70; x++)
            {
                Console.SetCursorPosition(x, 5);
                Console.Write("-");
            }
            Console.SetCursorPosition(33, 2);
            Console.Write("*");
            Console.SetCursorPosition(71, 2);
            Console.Write("*");
            Console.SetCursorPosition(33, 5);
            Console.Write("*");
            Console.SetCursorPosition(71, 5);
            Console.Write("*");

            for (y = 3; y <= 8; y++)
            {
                Console.SetCursorPosition(33, y);
                Console.Write("|");
            }
            for (y = 3; y <= 8; y++)
            {
                Console.SetCursorPosition(71, y);
                Console.Write("|");
            }

        }//Fin del metodo MarcoTriangulo

        static void MenuTriangulo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            MarcoFiguras();
      
            Console.SetCursorPosition(37, 3);
            Console.Write("Ingrese el valor de la base: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            decimal Base = Convert.ToDecimal(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(37, 3);
            Console.Write("Ingrese el valor de la altura: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            decimal Altura = Convert.ToDecimal(Console.ReadLine());

            decimal Resultado = (Base * Altura) / 2;
            Console.SetCursorPosition(45, 7);
            Console.Write($"El area es: {Resultado}");

            Console.ReadKey();
        }// FIn del metodo MenuTriangulo

        static void MenuCirculo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            MarcoFiguras();

            Console.SetCursorPosition(37, 3);
            Console.Write("Ingrese el valor del radio: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            double Radio = Convert.ToDouble(Console.ReadLine());

            double Resultado = 3.1416 * Radio * Radio;
            Console.SetCursorPosition(45, 7);
            Console.Write($"El area es: {Resultado}");

            Console.ReadKey();
        }// FIn del metodo MenuCirculo

        static void MenuRectangulo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            MarcoFiguras();

            Console.SetCursorPosition(37, 3);
            Console.Write("Ingrese el valor de la base: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            decimal Base = Convert.ToDecimal(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(37, 3);
            Console.Write("Ingrese el valor de la altura: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            decimal Altura = Convert.ToDecimal(Console.ReadLine());

            decimal Resultado = (Base * Altura);
            Console.SetCursorPosition(45, 7);
            Console.Write($"El area es: {Resultado}");

            Console.ReadKey();
        }// FIn del metodo MenuTriangulo

        static void MenuCuadrado()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            MarcoFiguras();

            Console.SetCursorPosition(37, 3);
            Console.Write("Ingrese el valor del lado: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            decimal Lado = Convert.ToDecimal(Console.ReadLine());
         
            decimal Resultado = (Lado * Lado);
            Console.SetCursorPosition(45, 7);
            Console.Write($"El area es: {Resultado}");

            Console.ReadKey();
        }// FIn del metodo MenuTriangulo



    }//Fin de la clase programa
}//Fin del namespace
