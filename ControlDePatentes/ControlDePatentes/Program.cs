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
            Console.WriteLine("6. Listar última patente");
            Console.WriteLine("7. Listar primera patente");
            Console.WriteLine("8. Cantidad de patentes");
            Console.WriteLine("9. Cargar lista patentes pregrabadas");
            Console.WriteLine("10. Modificar patente");
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
                    pilaPatentes = OpcionCustom1(pilaPatentes);
                    break;
                case 10:
                    pilaPatentes = OpcionCustom2(pilaPatentes);
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

            string nuevaPatente = "";

            while(nuevaPatente == "")
            {
                try
                {
                    Console.WriteLine("\n* Ingrese las 3 letras de la patente: ");
                    string letras = Convert.ToString(Console.ReadLine());
                    nuevaPatente = letras.ToUpper();

                    if(nuevaPatente.Length != 3)
                    {
                        Console.WriteLine("\n-Por favor solo ingrese 3 letras-\n");
                        nuevaPatente = "";
                    }
                }
                catch
                {
                    Console.WriteLine("\n-Por favor solo ingrese 3 letras-\n");
                }
            }
            while (nuevaPatente.Length != 6)
            {
                try
                {
                    Console.WriteLine("\n* Ingrese los 3 números de la patente: ");
                    int números = Convert.ToInt32(Console.ReadLine());
                    
                    if (números.ToString().Length != 3)
                    {
                        Console.WriteLine("\n-Por favor solo ingrese 3 números-\n");
                    }
                    else
                    {
                        nuevaPatente += números;
                    }
                }
                catch
                {
                    Console.WriteLine("\n-Por favor solo ingrese 3 números-\n");
                }
            }

            pilaPatentes.Push(nuevaPatente);
            return pilaPatentes;
        }

        static Stack<string> BorrarPatente(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 4. Borrar patente");
            if (pilaPatentes == null)
            {
                Console.WriteLine("-No existe una pila para borrar las patentes!-");
                return null;
            }
            string patenteBorrada = pilaPatentes.Pop();
            Console.WriteLine("-Se borro la patente "+ patenteBorrada + " de la pila-");
            return pilaPatentes;
        }

        static void ListarPatentes(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 5. Listar todas las patentes");
            if (pilaPatentes == null || pilaPatentes.Count == 0)
            {
                Console.WriteLine("-No existe una pila para listar patentes!-");
                return;
            }

            int ordenPatente = 1;
            foreach ( string patente in pilaPatentes)
            {
                Console.WriteLine(ordenPatente + " - " + patente);
                ordenPatente++;
            }
        }

        static void ListarPrimerPatente(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 7. Listar primera patente. (Tope de la pila)");
            if (pilaPatentes == null)
            {
                Console.WriteLine("-No existe una pila para listar patentes!-");
                return;
            }
            Console.WriteLine("Primer patente en la pila: ");
            Console.WriteLine("1 - " + pilaPatentes.Peek());
        }

        static void ListarUltimaPatente(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 6. Listar última patente. (Fondo de la pila)");
            if (pilaPatentes == null)
            {
                Console.WriteLine("-No existe una pila para listar patentes!-");
                return;
            }
            Console.WriteLine("Ultima patente en la pila: ");
            Stack<string> aux = new Stack<string>(pilaPatentes);
            Console.WriteLine(pilaPatentes.Count + " - " + aux.Peek());
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

        static Stack<string> OpcionCustom1(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 9. Cargar lista patentes pregrabadas");
            if (pilaPatentes == null)
            {
                Console.WriteLine("-No existe una pila para guardar las patentes!-");
                return null;
            }
            string[] listaPregrabada = new string[] { "ABC123", "HJI458" , "DJS789" , "ABC135" , "HIJ254" , "MUL162" , "RAM645" , "TER562" , "MAO020" };

            foreach(string patente in listaPregrabada)
            {
                pilaPatentes.Push(patente);
            }
            Console.WriteLine("-Se añadieron las patentes pregrabadas a la pila-");
            return pilaPatentes;
        }

        static Stack<string> OpcionCustom2(Stack<string> pilaPatentes)
        {
            Console.WriteLine("- 10. Modificar patente.");
            if (pilaPatentes == null)
            {
                Console.WriteLine("-No existe una pila para modificar las patentes!-");
                return null;
            }

            //Si desea listar primero las patentes en la pila para saber cual modificar
            Console.WriteLine("-Desea primero listar las patentes?: (pulsar -enter- para aceptar)-");
            string opcion = Console.ReadLine().ToLower();
            if(opcion == "")
                ListarPatentes(pilaPatentes);

            //Ahora se le pide al usuario ingrese el numero de orden en la pila de la patente a modificar
            int ordenPatente = 0;
            while(ordenPatente == 0)
            {
                try
                {
                    Console.WriteLine("* Ingrese el número de orden de la patente que desea modificar: ");
                    ordenPatente = Convert.ToInt32(Console.ReadLine());

                    if(ordenPatente>pilaPatentes.Count || ordenPatente <= 0)
                    {
                        ordenPatente = 0;
                        Console.WriteLine("-Ingrese un número de orden válido-");
                    }
                }
                catch
                {
                    Console.WriteLine("-Ingrese un número de orden válido-");
                }
            }

            //Se crea una pila auxiliar para guardar los datos q se iran sacando de la principal
            //hasta llegar al número de orden de la patente a modificar
            Stack<string> aux = new Stack<string>();
            while(aux.Count < ordenPatente-1)
            {
                string aux_patente = pilaPatentes.Pop();
                aux.Push(aux_patente);
            }

            Console.WriteLine("-Modificar la patente " + pilaPatentes.Peek() + " -");
            string nuevaPatente = "";

            while (nuevaPatente == "")
            {
                try
                {
                    Console.WriteLine("\n* Ingrese las 3 letras de la patente: ");
                    string letras = Convert.ToString(Console.ReadLine());
                    nuevaPatente = letras.ToUpper();

                    if (nuevaPatente.Length != 3)
                    {
                        Console.WriteLine("\n-Por favor solo ingrese 3 letras-\n");
                        nuevaPatente = "";
                    }
                }
                catch
                {
                    Console.WriteLine("\n-Por favor solo ingrese 3 letras-\n");
                }
            }
            while (nuevaPatente.Length != 6)
            {
                try
                {
                    Console.WriteLine("\n* Ingrese los 3 números de la patente: ");
                    int números = Convert.ToInt32(Console.ReadLine());

                    if (números.ToString().Length != 3)
                    {
                        Console.WriteLine("\n-Por favor solo ingrese 3 números-\n");
                    }
                    else
                    {
                        nuevaPatente += números;
                    }
                }
                catch
                {
                    Console.WriteLine("\n-Por favor solo ingrese 3 números-\n");
                }
            }

            //Se elimina la patente a modificar y se añade la nueva
            pilaPatentes.Pop();
            pilaPatentes.Push(nuevaPatente);
            Console.WriteLine("\n-La patente fue modificada correctamente-\n");

            //Se reconstruye la pila original
            while(aux.Count != 0)
            {
                pilaPatentes.Push( aux.Pop() );
            }
            return pilaPatentes;
        }
    }
}
