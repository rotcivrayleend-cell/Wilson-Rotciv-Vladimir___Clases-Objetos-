using System;

namespace TecnoPunto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TecnoPunto - Registro de Inventario\n");

            // Tres objetos independientes, sin arreglos ni colecciones
            Producto producto1 = LeerProducto(1);
            Producto producto2 = LeerProducto(2);
            Producto producto3 = LeerProducto(3);

            Console.WriteLine("\nPRODUCTOS REGISTRADOS");
            producto1.MostrarInfo();
            producto2.MostrarInfo();
            producto3.MostrarInfo();

            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }

        /// <summary>
        /// Pide los datos de un producto y repite hasta que sean válidos.
        /// </summary>
        static Producto LeerProducto(int numero)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"Producto {numero}");

                    Console.Write("Código: ");
                    string codigo = Console.ReadLine();

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Precio: ");
                    decimal precio = decimal.Parse(Console.ReadLine().Replace(',', '.'),
                    System.Globalization.CultureInfo.InvariantCulture);

                    Console.Write("Cantidad: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    // Si algún dato es inválido, el constructor lanza ArgumentException
                    return new Producto(codigo, nombre, precio, cantidad);
                }
                catch (ArgumentException ex)
                {
                    // Error de validación de la clase Producto
                    Console.WriteLine($"\nERROR {ex.Message} Intente de nuevo.\n");
                }
                catch (FormatException)
                {
                    // El usuario escribió letras donde iba un número (o lo dejó vacío)
                    Console.WriteLine("\nERROR Debe ingresar un valor numérico válido. Intente de nuevo.\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nERROR El número ingresado es demasiado grande. Intente de nuevo.\n");
                }
            }
        }
    }
}