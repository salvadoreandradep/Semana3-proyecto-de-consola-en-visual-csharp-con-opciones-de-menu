using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3
{
    class principal
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Proyecto de Menu");
            System.Console.WriteLine("Primer Programa Usando Estructuras");

            System.Console.ReadKey();

            int repetir;

            //menu_interno();

            do
            {
                menu_interno();

                System.Console.WriteLine("Ingrese 1 para repetir menú");
                System.Console.WriteLine("Ingrese 2 para salir");
                repetir = Int32.Parse(Console.ReadLine());

            } while (repetir == 1);

        } //Cierre de función principal


        //Inicio de funciones interna
        static void menu_interno()
        {
            string opcion;
            int opcionint;

            System.Console.WriteLine("Menu Principal");
            System.Console.WriteLine("1. Ejemplo If");
            System.Console.WriteLine("2. Ejemplo Switch");
            System.Console.WriteLine("3. Ejemplo For");
            System.Console.WriteLine("4. Ejemplo Wor");
            System.Console.WriteLine("5. Ejemplo Do While");

            System.Console.WriteLine("Selecciona tu opcion: ");
            opcion = Console.ReadLine();
            opcionint = Int32.Parse(opcion);

            switch (opcionint)
            {
                case 1:
                    //Ejemplo para llamar clase externa
                    programa_if();

                    //llamada función interna
                    //programa_if();
                    break;

                case 2:
                    //llamada de función interna
                    programa_switch();
                    break;

                case 3:
                    //llamada de función interna
                    programa_for();
                    break;

                case 4:
                    //llamada de función interna
                    programa_while();
                    break;
                case 5:
                    //llamada de función interna
                    programa_dowhile();
                    break;
            }

        }

        //Función interna para ejemplo if
        static void programa_if()
        {
            System.Console.WriteLine("Aqui llamo ejemplo If");

        }

        //Función interna para ejemplo switch
        static void programa_switch()
        {
            System.Console.WriteLine("Aqui llamo ejemplo Switch");
        }

        //Función interna para ejemplo for
        static void programa_for()
        {
            System.Console.WriteLine("Aqui llamo ejemplo For");
        }

        //Función interna para ejemplo while
        static void programa_while()
        {
            System.Console.WriteLine("Aqui llamo ejemplo While");
        }

        //Función interna para ejemplo dowhile
        static void programa_dowhile()
        {
            System.Console.WriteLine("Aqui llamo ejemplo DoWhile");
        }

        //Fin de funciones internas




    }
}
