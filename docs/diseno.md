# Diseño técnico - Programa 1

## 1. Arquitectura

Aplicación de consola desarrollada en C# y .NET 9,
organizada mediante separación de responsabilidades.

## 2. Componentes

| Componente | Responsabilidad |
|---|---|
| Program | Coordinar la ejecución del programa. |
| ConsoleUI | Gestionar la interacción con el usuario. |
| FileReader | Leer y validar archivos de entrada. |
| StatisticsService | Realizar los cálculos estadísticos. |
| StatisticsResult | Almacenar los resultados. |
| LinkedList<T> | Almacenar y recorrer los datos. |
| Node<T> | Representar cada nodo de la lista. |

## 3. Estructura de datos

Lista simplemente enlazada genérica con referencias
a la cabeza y la cola.

- Inserción al final: O(1).
- Recorrido completo: O(n).
- Almacenamiento: O(n).
- Conservación del orden de entrada.
- Admite valores duplicados.

## 4. Entrada y salida

Entrada:
- Archivo TXT.
- Un número real por línea.
- Separador decimal mediante punto.

Salida:
- Cantidad de elementos.
- Media aritmética.
- Desviación estándar muestral.
- Mensajes de validación y error.

## 5. Diseño visual

Interfaz de consola con estética tecnológica.

| Elemento | Color |
|---|---|
| Rojo principal | #FF003C |
| Rojo secundario | #E60026 |
| Fondo | #080808 |
| Grafito | #161616 |
| Texto principal | #F5F5F5 |
| Texto secundario | #808080 |

La aplicación contempla alternativas para terminales
sin soporte de colores ANSI y salida redirigida.

## 6. Complejidad

El cálculo estadístico utiliza recorridos lineales.
Complejidad temporal O(n) y espacio auxiliar O(1),
sin incluir el almacenamiento de la lista.

## 7. Diagramas

- [Diagrama de clases](diagramas/clases.svg)
- [Diagrama de capas](diagramas/capas.svg)
- [Diagrama de flujo](diagramas/flujo.svg)
- [Diseño de interfaz](diagramas/interfaz.svg)

## 8. Documento de referencia

[Documento completo de diseño](02_Diseno_Programa1.pdf)
