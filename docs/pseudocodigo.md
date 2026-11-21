# Pseudocódigo - Programa 1

## 1. Algoritmo principal

INICIO
    Crear interfaz de consola
    Crear lector de archivos
    Crear servicio estadístico

    REPETIR
        Mostrar menú
        Leer opción

        SEGÚN opción HACER
            CASO 1:
                Solicitar ruta del archivo
                SI fin de entrada ENTONCES
                    Finalizar programa
                FIN SI

                INTENTAR
                    Leer números del archivo
                    Almacenar números en lista enlazada
                    Calcular estadísticas
                    Mostrar resultados
                CAPTURAR errores previstos
                    Mostrar mensaje de error
                FIN INTENTAR

            CASO 2:
                Finalizar programa

            OTRO CASO:
                Mostrar opción inválida
        FIN SEGÚN
    HASTA finalizar
FIN

## 2. Lectura del archivo

INICIO LeerNumeros(ruta)
    Validar ruta
    Crear lista enlazada vacía

    PARA CADA línea del archivo
        Eliminar espacios externos
        Convertir línea a número real

        SI conversión inválida O valor no finito
            Generar error
        FIN SI

        Agregar número a la lista
    FIN PARA

    SI lista vacía
        Generar error
    FIN SI

    RETORNAR lista
FIN

## 3. Lista enlazada

INICIO Agregar(valor)
    Crear nodo con valor

    SI lista vacía
        cabeza = nuevoNodo
        cola = nuevoNodo
    SINO
        cola.siguiente = nuevoNodo
        cola = nuevoNodo
    FIN SI

    Incrementar cantidad
FIN

## 4. Media aritmética

INICIO CalcularMedia(lista)
    suma = 0

    PARA CADA valor EN lista
        Validar que el valor sea finito
        suma = suma + valor
    FIN PARA

    RETORNAR suma / cantidad
FIN

## 5. Desviación estándar muestral

INICIO CalcularDesviacion(lista, media)
    sumaCuadrados = 0

    PARA CADA valor EN lista
        diferencia = valor - media
        sumaCuadrados += diferencia * diferencia
    FIN PARA

    RETORNAR raiz(sumaCuadrados / (cantidad - 1))
FIN

## 6. Validaciones estadísticas

- La lista debe contener al menos dos elementos.
- Los valores deben ser números reales finitos.
- No se redondean los cálculos intermedios.
- Se comprueba que los resultados sean finitos.
- Los resultados se presentan con dos decimales.

## 7. Prueba de escritorio

Datos de entrada: 2, 4, 6.

Cantidad: 3.
Suma: 12.
Media: 12 / 3 = 4.

| Valor | Diferencia | Diferencia al cuadrado |
|---:|---:|---:|
| 2 | -2 | 4 |
| 4 | 0 | 0 |
| 6 | 2 | 4 |
| Total | | 8 |

Varianza muestral: 8 / (3 - 1) = 4.
Desviación estándar: raíz de 4 = 2.

Resultado esperado:
- Cantidad: 3.
- Media: 4.00.
- Desviación estándar: 2.00.
