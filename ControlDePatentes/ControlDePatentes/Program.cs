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
            Stack<string> pilaPatentes = null;

            while (opcion != 11)
            {
                DibujarMenu();

                try
                {
                    Console.WriteLine("\n* Ingrese el número de la opción deseada: ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    //Chequea la opcion elegida dentro de un switch y alli modifica la pila
                    pilaPatentes = ElegirOpcionMenu(opcion, pilaPatentes);
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

        static Stack<string> ElegirOpcionMenu(int opcion, Stack<string> pilaPatentes)
        {
            switch (opcion)
            {
                case 1:
                    pilaPatentes = CrearPila(pilaPatentes);
                    break;
                case 2:
                    pilaPatentes = BorrarPila(pilaPatentes);
                    break;
                case 3:
                    pilaPatentes = AgregarPatente(pilaPatentes);
                    break;
                case 4:
                    pilaPatentes = BorrarPatente(pilaPatentes);
                    break;
                case 5:
                    ListarPatentes(pilaPatentes);
                    break;
                case 6:
                    ListarUltimaPatente(pilaPatentes);
                    break;
                case 7:
                    ListarPrimerPatente(pilaPatentes);
                    break;
                case 8:
                    CantidadPatentes(pilaPatentes);
                    break;
                case 9:
                    Opcion1(pilaPatentes);
                    break;
                case 10:
                    Opcion2(pilaPatentes);
                    break;
                case 11:
                    Console.WriteLine("\n-SALIR-");
                    break;
                default:
                    Console.WriteLine("-La opción elegida no es válida-\n");
                    break;
            }
            return pilaPatentes;
        }

        static Stack<string> CrearPila(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 1. Crear Pila");
            if (pilaPatentes == null)
            {
                pilaPatentes = new Stack<string>();
                Console.WriteLine("-La pila fue creada con éxito-");
            }
            else
            {
                Console.WriteLine("-Ya existe una pila creada-");
            }
            return pilaPatentes;
        }

        static Stack<string> BorrarPila(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 2. Borrar Pila");
            if(pilaPatentes == null)
            {
                Console.WriteLine("-No existe una pila para borrar!-");
                return null;
            }
            if (pilaPatentes.Count != 0)
            {
                pilaPatentes.Clear();
                Console.WriteLine("-La pila fue borrada con éxito-");
            }
            else
            {
                Console.WriteLine("-La pila ya esta borrada-");
            }
            return pilaPatentes;
        }

        static Stack<string> AgregarPatente(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 3. Agregar patente");
            if (pilaPatentes == null)
            {
                Console.WriteLine("-No existe una pila para guardar las patentes!-");
                return null;
            }
        }

        static Stack<string> BorrarPatente(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 4. Borrar patente");
            if (pilaPatentes == null)
            {
                Console.WriteLine("-No existe una pila para borrar las patentes!-");
                return null;
            }
        }

        static void ListarPatentes(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 5. Listar todas las patentes");
            if (pilaPatentes == null)
            {
                Console.WriteLine("-No existe una pila para listar patentes!-");
                return;
            }

            int ordenPatente = 1;
            foreach( string patente in pilaPatentes)
            {
                Console.WriteLine(ordenPatente + " - " + patente);
            }
        }

        static void ListarPrimerPatente(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 6. Listar última patente.");
            if (pilaPatentes == null)
            {
                Console.WriteLine("-No existe una pila para listar patentes!-");
                return;
            }
            Console.WriteLine("Ultima patente en la pila: ");
            Console.WriteLine(pilaPatentes.Count + " - " + pilaPatentes.Peek());
        }

        static void ListarUltimaPatente(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 7. Listar primera patente.");
            if (pilaPatentes == null)
            {
                Console.WriteLine("-No existe una pila para listar patentes!-");
                return;
            }
            Console.WriteLine("Primer patente en la pila: ");
            //TODO
        }

        static void CantidadPatentes(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 8. Cantidad de patentes.");
            if (pilaPatentes == null)
            {
                Console.WriteLine("-No existe una pila para listar cantidad de patentes!-");
                return;
            }
            Console.WriteLine("Cantidad de patentes en la pila: " + pilaPatentes.Count);
        }

        static void Opcion1(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 9. Opcion inventada 1.");
        }

        static void Opcion2(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 10. Opcion inventada 2.");
        }
    }
}
