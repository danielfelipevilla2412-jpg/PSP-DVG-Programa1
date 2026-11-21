# Casos de prueba - Programa 1

## Información general

- Proyecto: PSP-DVG-Programa1.
- Metodología: PSP0.
- Fase: TEST.
- Plataforma: C# y .NET 9.
- Framework: xUnit.

## Pruebas funcionales

| ID | Caso | Resultado esperado |
|---|---|---|
| PF-01 | Inicio del programa | Mostrar menú principal. |
| PF-02 | Lectura de tamaños | Cargar 10 valores. |
| PF-03 | Cálculo de tamaños | Media 550.60 y desviación 572.03. |
| PF-04 | Lectura de horas | Cargar 10 valores. |
| PF-05 | Cálculo de horas | Media 60.32 y desviación 62.26. |
| PF-06 | Finalizar procesamiento | Regresar al menú. |
| PF-07 | Salir del programa | Finalizar correctamente. |
| PF-08 | Archivo vacío | Mostrar error controlado. |
| PF-09 | Un único valor | Rechazar datos insuficientes. |
| PF-10 | Datos inválidos | Identificar línea incorrecta. |
| PF-11 | Archivo inexistente | Mostrar error controlado. |
| PF-12 | Valores iguales | Media 5.00 y desviación 0.00. |
| PF-13 | Valores negativos | Media -2.00 y desviación 1.00. |
| PF-14 | Valores decimales | Media 2.50 y desviación 1.00. |
| PF-15 | Valores no finitos | Rechazar datos inválidos. |
| PF-16 | Ruta vacía | Mostrar error de validación. |
| PF-17 | Opción inválida | Informar opción incorrecta. |
| PF-18 | Ruta de directorio | Mostrar error controlado. |
| PF-19 | Fin de entrada al solicitar ruta | Finalizar sin error. |

## Pruebas unitarias

### Lista enlazada

| ID | Caso |
|---|---|
| PU-01 | Inicialización de lista vacía. |
| PU-02 | Inserción y contador. |
| PU-03 | Orden de los elementos. |
| PU-04 | Elementos duplicados. |
| PU-05 | Valores negativos y decimales. |
| PU-06 | Compatibilidad con tipos genéricos. |

### Servicio estadístico

| ID | Caso |
|---|---|
| PU-07 | Datos oficiales de tamaños. |
| PU-08 | Datos oficiales de horas. |
| PU-09 | Valores iguales. |
| PU-10 | Valores negativos. |
| PU-11 | Valores decimales. |
| PU-12 | Dos valores. |
| PU-13 | Lista vacía. |
| PU-14 | Un único elemento. |
| PU-15 | Valor NaN. |
| PU-16 | Infinito positivo. |
| PU-17 | Infinito negativo. |
| PU-18 | Lista nula. |
| PU-19 | Desbordamiento numérico. |

### Lectura de archivos

| ID | Caso |
|---|---|
| PU-20 | Archivo con números válidos. |
| PU-21 | Archivo con números decimales. |
| PU-22 | Archivo vacío. |
| PU-23 | Archivo inexistente. |
| PU-24 | Ruta vacía. |
| PU-25 | Ruta con espacios únicamente. |
| PU-26 | Texto no numérico. |
| PU-27 | Valor NaN. |
| PU-28 | Infinito positivo. |
| PU-29 | Infinito negativo. |
| PU-30 | Separador decimal incorrecto. |
| PU-31 | Línea vacía dentro del archivo. |
| PU-32 | Lectura de un único valor. |

## Criterios de aprobación

- Coincidencia con resultados estadísticos esperados.
- Manejo controlado de entradas inválidas.
- Ejecución satisfactoria de las pruebas unitarias.
- Ausencia de fallos no controlados en los casos evaluados.

## Documentos relacionados

- [Informe de pruebas](informe_pruebas.md).
- [Informe completo PDF](03_Informe_Pruebas_Programa1.pdf).
- [Evidencia unitaria](evidencias/pruebas_unitarias.txt).
