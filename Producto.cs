using System;

namespace TecnoPunto
{
    /// Representa un producto del inventario de la tienda TecnoPunto.
    public class Producto
    {
        // Campos privados: guardan el valor real. Nadie fuera de la clase puede tocarlos.
        private string _codigo;
        private string _nombre;
        private decimal _precio;
        private int _cantidad;

        // Constructor: usa las propiedades (no los campos) para que se ejecuten las validaciones.
        public Producto(string codigo, string nombre, decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public string Codigo
        {
            get { return _codigo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El código no puede estar vacío.");
                _codigo = value.Trim();
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                // Validación: el nombre no puede estar vacío
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                _nombre = value.Trim();
            }
        }

        public decimal Precio
        {
            get { return _precio; }
            set
            {
                // Validación: el precio debe ser mayor que 0
                if (value <= 0)
                    throw new ArgumentException("El precio debe ser mayor que 0.");
                _precio = value;
            }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                // Validación: la cantidad no puede ser negativa (0 sí es válido)
                if (value < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                _cantidad = value;
            }
        }

        // Propiedad de solo lectura (sin set): se calcula sola.
        public decimal ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        // Imprime los datos del producto en consola.
        public void MostrarInfo()
        {
            Console.WriteLine($"Código:       {Codigo}");
            Console.WriteLine($"Nombre:       {Nombre}");
            Console.WriteLine($"Precio:       RD$ {Precio:N2}");
            Console.WriteLine($"Cantidad:     {Cantidad}");
            Console.WriteLine($"Valor total:  RD$ {ValorTotal:N2}");
        }
    }
}