# TecnoPunto - Clases, Objetos y Propiedades en C#

## Datos del autor
Wilson Alejandro Abreu Santana (2025-2391) 
Vladimir Corrielan Jose (2025-2527) 
Rotciv Rayleend Ozuna (2025-2501)

## Descripción del programa
Aplicación de consola en C# para la tienda TecnoPunto. Registra tres productos validando sus datos mediante propiedades y muestra su información, incluyendo el valor total en existencia de cada uno.

## Datos de entrada
Por cada producto:
- Código (texto)
- Nombre (texto)
- Precio (decimal)
- Cantidad (entero)

## Datos que procesa
- Validación en las propiedades: el nombre no puede estar vacío, el precio debe ser mayor que 0 y la cantidad no puede ser negativa.
- Cálculo del valor total: Precio × Cantidad.

## Datos de salida
Código, nombre, precio, cantidad y valor total de cada producto. Mensajes de error claros cuando un dato es inválido.

## Capturas de ejecución

### 1. Datos válidos
Se ingresan tres productos con datos correctos. El programa los registra y muestra el código, nombre, precio, cantidad y valor total de cada uno.

![Datos válidos](capturas/datos-validos.png)

### 2. Precio negativo
Se ingresa un precio negativo (-100). La propiedad Precio rechaza el valor, el programa muestra un mensaje de error y vuelve a pedir los datos sin cerrarse.

![Precio negativo](capturas/precio-negativo.png)

### 3. Nombre vacío
Se deja el nombre en blanco. La propiedad Nombre rechaza el valor, el programa muestra el mensaje de error y solicita de nuevo los datos del producto.

![Nombre vacío](capturas/nombre-vacio.png)

### 4. Cantidad cero
Se ingresa cantidad 0, que es un valor válido porque no es negativo. El producto se registra y su valor total es RD$ 0,00.

![Cantidad cero](capturas/cantidad-cero.png)
