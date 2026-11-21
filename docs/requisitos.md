# Programa 1 - Requisitos

## Objetivo general

Desarrollar una aplicación de consola en C# y .NET 9
que calcule la media aritmética y la desviación estándar
muestral mediante una lista enlazada propia, siguiendo PSP0.

## Requisitos funcionales

| ID | Requisito | Prioridad |
|---|---|---|
| RF-01 | Leer números reales desde archivos TXT. | Alta |
| RF-02 | Almacenar datos en una lista enlazada propia. | Alta |
| RF-03 | Contabilizar los elementos almacenados. | Alta |
| RF-04 | Calcular la media aritmética. | Alta |
| RF-05 | Calcular la desviación estándar muestral. | Alta |
| RF-06 | Presentar los resultados en consola. | Alta |
| RF-07 | Validar un mínimo de dos valores numéricos finitos. | Alta |
| RF-08 | Gestionar archivos inexistentes o inaccesibles. | Alta |
| RF-09 | Permitir seleccionar el archivo de entrada. | Media |

## Requisitos no funcionales

| ID | Categoría | Requisito |
|---|---|---|
| RNF-01 | Tecnología | C# y .NET 9. |
| RNF-02 | Mantenibilidad | Separación de responsabilidades. |
| RNF-03 | Usabilidad | Interfaz de consola clara. |
| RNF-04 | Precisión | Utilizar double y redondear únicamente la presentación. |
| RNF-05 | Reutilización | Lista enlazada genérica propia. |
| RNF-06 | Calidad | Pruebas unitarias con xUnit. |
| RNF-07 | Trazabilidad | Registro de tiempos y defectos en PSP Tracker. |

## Criterios de aceptación

| ID | Escenario | Resultado esperado |
|---|---|---|
| CA-01 | Datos oficiales de tamaños | Media 550.60 y desviación 572.03. |
| CA-02 | Datos oficiales de horas | Media 60.32 y desviación 62.26. |
| CA-03 | Archivo vacío | Informar ausencia de datos. |
| CA-04 | Archivo inexistente o inaccesible | Informar error de lectura. |
| CA-05 | Datos inválidos o no finitos | Rechazar el archivo. |
| CA-06 | Un único valor | Informar que se requieren dos valores. |
| CA-07 | Valores 5, 5, 5 | Media 5.00 y desviación 0.00. |
| CA-08 | Valores -3, -2, -1 | Media -2.00 y desviación 1.00. |
| CA-09 | Valores 1.5, 2.5, 3.5 | Media 2.50 y desviación 1.00. |
| CA-10 | Seleccionar una ruta válida | Procesar el archivo indicado. |

## Alcance

Incluye lectura de archivos, listas enlazadas, cálculos
estadísticos, validaciones, pruebas y registros PSP0.

Excluye bases de datos, aplicaciones web, autenticación,
conteo automatizado de LOC y regresión lineal.

## Documento de referencia

[Documento completo de requisitos](01_Requisitos_Programa1.pdf)

cat > docs/requisitos.md <<'EOF'
# Programa 1 - Requisitos

## Objetivo general

Desarrollar una aplicación de consola en C# y .NET 9
que calcule la media aritmética y la desviación estándar
muestral mediante una lista enlazada propia, siguiendo PSP0.

## Requisitos funcionales

| ID | Requisito | Prioridad |
|---|---|---|
| RF-01 | Leer números reales desde archivos TXT. | Alta |
| RF-02 | Almacenar datos en una lista enlazada propia. | Alta |
| RF-03 | Contabilizar los elementos almacenados. | Alta |
| RF-04 | Calcular la media aritmética. | Alta |
| RF-05 | Calcular la desviación estándar muestral. | Alta |
| RF-06 | Presentar los resultados en consola. | Alta |
| RF-07 | Validar un mínimo de dos valores numéricos finitos. | Alta |
| RF-08 | Gestionar archivos inexistentes o inaccesibles. | Alta |
| RF-09 | Permitir seleccionar el archivo de entrada. | Media |

## Requisitos no funcionales

| ID | Categoría | Requisito |
|---|---|---|
| RNF-01 | Tecnología | C# y .NET 9. |
| RNF-02 | Mantenibilidad | Separación de responsabilidades. |
| RNF-03 | Usabilidad | Interfaz de consola clara. |
| RNF-04 | Precisión | Utilizar double y redondear únicamente la presentación. |
| RNF-05 | Reutilización | Lista enlazada genérica propia. |
| RNF-06 | Calidad | Pruebas unitarias con xUnit. |
| RNF-07 | Trazabilidad | Registro de tiempos y defectos en PSP Tracker. |

## Criterios de aceptación

| ID | Escenario | Resultado esperado |
|---|---|---|
| CA-01 | Datos oficiales de tamaños | Media 550.60 y desviación 572.03. |
| CA-02 | Datos oficiales de horas | Media 60.32 y desviación 62.26. |
| CA-03 | Archivo vacío | Informar ausencia de datos. |
| CA-04 | Archivo inexistente o inaccesible | Informar error de lectura. |
| CA-05 | Datos inválidos o no finitos | Rechazar el archivo. |
| CA-06 | Un único valor | Informar que se requieren dos valores. |
| CA-07 | Valores 5, 5, 5 | Media 5.00 y desviación 0.00. |
| CA-08 | Valores -3, -2, -1 | Media -2.00 y desviación 1.00. |
| CA-09 | Valores 1.5, 2.5, 3.5 | Media 2.50 y desviación 1.00. |
| CA-10 | Seleccionar una ruta válida | Procesar el archivo indicado. |

## Alcance

Incluye lectura de archivos, listas enlazadas, cálculos
estadísticos, validaciones, pruebas y registros PSP0.

Excluye bases de datos, aplicaciones web, autenticación,
conteo automatizado de LOC y regresión lineal.

## Documento de referencia

[Documento completo de requisitos](01_Requisitos_Programa1.pdf)
