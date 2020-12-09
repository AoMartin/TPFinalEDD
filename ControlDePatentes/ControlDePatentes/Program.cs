using System;
using System.Collections;
using System.Collections.Generic;

namespace ControlDePatentes
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            
            while (opcion != 11)
            {
                DibujarMenu();

                try
                {
                    Console.WriteLine("\n* Ingrese el número de la opción deseada: ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    //Chequea la opcion elegida dentro de un switch
                    ElegirOpcionMenu(opcion);
                }
                catch
                {
                    Console.WriteLine("\n-La opción elegida no es válida-\n");
                }
            }
            Console.WriteLine("\n-Fin de la aplicación-");
        }

        static void DibujarMenu()
        {
            Console.WriteLine("\n- CONTROL DE PATENTES -\n");
            Console.WriteLine("1. Crear Pila");
            Console.WriteLine("2. Borrar Pila");
            Console.WriteLine("3. Agregar patente");
            Console.WriteLine("4. Borrar patente");
            Console.WriteLine("5. Listar todas las patentes");
            Console.WriteLine("6. Listar última patente.");
            Console.WriteLine("7. Listar primera patente.");
            Console.WriteLine("8. Cantidad de patentes.");
            Console.WriteLine("9. Opcion inventada 1.");
            Console.WriteLine("10. Opcion inventada 2.");
            Console.WriteLine("11. Salir ");
        }

        static void ElegirOpcionMenu(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    CrearPila();
                    break;
                case 2:
                    BorrarPila();
                    break;
                case 3:
                    AgregarPatente();
                    break;
                case 4:
                    BorrarPatente();
                    break;
                case 5:
                    ListarPatentes();
                    break;
                case 6:
                    ListarUltimaPatente();
                    break;
                case 7:
                    ListarPrimerPatente();
                    break;
                case 8:
                    CantidadPatentes();
                    break;
                case 9:
                    Opcion1();
                    break;
                case 10:
                    Opcion2();
                    break;
                case 11:
                    Console.WriteLine("\n-SALIR-");
                    break;
                default:
                    Console.WriteLine("-La opción elegida no es válida-\n");
                    break;
            }
        }

        static void CrearPila()
        {

        }

        static void BorrarPila()
        {

        }

        static void AgregarPatente()
        {

        }

        static void BorrarPatente()
        {

        }

        static void ListarPatentes()
        {

        }

        static void ListarPrimerPatente()
        {

        }

        static void ListarUltimaPatente()
        {

        }

        static void CantidadPatentes()
        {

        }

        static void Opcion1()
        {

        }

        static void Opcion2()
        {

        }
    }
}
