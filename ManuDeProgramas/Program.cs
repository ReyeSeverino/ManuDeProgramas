using System;
using System.Threading;

namespace ManuDeProgramas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            Orddemaniemto ojt = new Orddemaniemto();
            ojt.ordenamiento();
            Thread.Sleep(15000);

            void mostrarMenu() {
                Console.WriteLine("**********  Menu De Opcines  **********");
                Console.WriteLine("1. Opcion ");
                Console.WriteLine("2. Opcion ");
                Console.WriteLine("3. Opcion ");
                Console.WriteLine("4. Opcion ");
                Console.WriteLine("5. Opcion ");
                Console.WriteLine("6. Opcion ");
                Console.WriteLine("7. Opcion ");
                Console.WriteLine("8. Opcion ");
                Console.WriteLine("9. Opcion ");
            }

            //Llamamos a la funcion para ingresar una cantidad de numeros
            void IngresarNumeros()
            {
                Console.Write("¿Cuantos numeros desea ingresar? ");
                int cantidad, longitud, MaxElementos;
                while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
                {
                    Console.WriteLine("Por favor, ingrese un numero valido mayor a 0.");
                    Console.Write("¿Cuantos numeros desea ingresar? ");

                    
                }
                //Dentro de la estructura condicional if, mostramos la logitud y cantidad de elementos
                if(longitud + cantidad > MaxElementos)
                {
                    // Si el mensaje da error volvemos a intentarlo hasta que nos funcione correctamentex
                    Console.WriteLine($"Error: No hay espacio suficiente en el arreglo. Espacio disponible: {MaxElementos - longitud}");
                    return;
                }
                // Ingresa los numeros para luego declararlos dentro de las estructuras repetitivas for y while
                Console.WriteLine("Ingrese los numeros:");
                for(int i = 0; i < cantidad; i++)
                {
                    int arreglo;
                    Console.Write($"Numero {i + 1}: ");
                    while(!int.TryParse(Console.ReadLine(), out arreglo[longitud + i]))
                    {
                        Console.WriteLine("Por favor, ingrese un numero valido.");
                        Console.Write($"Numero{i + 1}: ");
                    }
                }
                longitud += cantidad;
            }
            
            void Calcularpromedio()
            {
                if(longitud==0)
                {
                    Console.WriteLine("El arreglo esta vacio");
                    return;
                }

                double suma = 0;
                for(int i = 0; i < longitud; i++)
                {
                    suma += arreglo [i];
                }

                double promedio = suma / longitud;
                Console.WriteLine($"El promedio es: {promedio:}");
            }


            void OrdenarMatriz()
            {
                Console.Clear();
                int[,] numeros = new int[5, 5];

                for (int fila = 0; fila < 5; fila++)
                {
                    for (int columna = 0; columna < 5; columna++)
                    {
                        Console.WriteLine("Ingrese un número entero: ");
                        numeros[fila, columna] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Datos de la Matriz:");
                for (int fila = 0; fila < 5; fila++)
                {
                    for (int columna = 0; columna < 5; columna++)
                    {
                        Console.Write($"{numeros[fila, columna]}");
                    }
                    Console.WriteLine();
                }
            }

            while (salir != false)
            {
                mostrarMenu();
                Console.WriteLine("Seleccione una opcion");
                string opcio = Console.ReadLine();

                switch (opcio)
                {
                    case "1":
                        OrdenarMatriz();
                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    case "5":

                        break;

                    case "6":

                        break;

                    case "7":

                        break;

                    case "8":

                        break;

                    case "9":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida, introduce una opcion valida");
                        break;
                }
            }

            //******************
            //Arreglo con valores iniciales
            int[]areglo = {10,25,3,88,5,12,42,9};
            Console.Write(IngresarNumeros);
            int buscar = int.Parse(Console.ReadLine());
            Console.WriteLine($"EL VALOR QUE SE INTRODUJO Es:{buscar}");
            bool encotrado = false;
                for(int indice = 0; indice< arreglo.length; indice++) { 

                    //ESTA FUNCION ESTA VASIA NO HACE NADA AQUI

                }
                if (arreglo[indice] == buscar) {

                    encotrado = true;
                    Break;// Salimos del bucle si encontramos el numero
                }
                if(encontrado) 
                {
                    Console.WriteLine("Numero encontrado!");
                }
                else 
                {
                    Console.WriteLine("Numero no encontrado. Lista de Numeros:");
                }


                Console.WriteLine("/N Presione Enter Para salir.");
                Console.ReadLine();
        }    
    }
}

