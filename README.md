# PSP-DVG-Programa1

## Descripción

Aplicación de consola desarrollada en C# y .NET 9
para calcular la media aritmética y la desviación
estándar muestral mediante una lista enlazada
genérica propia.

Proyecto desarrollado bajo la metodología PSP0.

## Tecnologías

- C#
- .NET 9
- xUnit
- Git y GitHub
- PSP Tracker

## Requisitos de ejecución

- SDK de .NET 9.
- Terminal PowerShell o equivalente.

## Instalación

```powershell
dotnet restore
dotnet build
```

## Ejecución

Desde la raíz del repositorio:

```powershell
dotnet run --project src/Programa1/Programa1.csproj
```

Seleccione la opción 1 e introduzca la ruta
del archivo que desea procesar.

Archivos disponibles:

- data/tamanos.txt
- data/horas.txt

## Formato de entrada

- Archivos de texto TXT.
- Un número real por línea.
- Mínimo dos valores.
- Punto como separador decimal.
- No admite valores no finitos.

## Resultados de referencia

| Datos | Cantidad | Media | Desviación |
|---|---:|---:|---:|
| Tamaños | 10 | 550.60 | 572.03 |
| Horas | 10 | 60.32 | 62.26 |

## Arquitectura

- DataStructures: lista enlazada genérica.
- Infrastructure: lectura y validación.
- Services: cálculos estadísticos.
- Models: representación de resultados.
- Presentation: interfaz de consola.
- Program: coordinación de componentes.

## Pruebas

```powershell
dotnet test
```

Resultados registrados:

- 19 pruebas funcionales aprobadas.
- 32 pruebas unitarias aprobadas.
- 1 defecto conocido corregido y verificado.

## Limitaciones

Los cálculos utilizan double. Los valores extremos
pueden superar el rango numérico representable.

No se verificó la denegación de permisos sobre
un archivo real.

## Documentación

La carpeta docs contiene los requisitos, diseño,
informe de pruebas y registros del proceso PSP0.

## Autor

Daniel Felipe Villamizar Guevara

Análisis y Desarrollo de Software - SENA.

## Entregables PSP0

| Fase | Documentación |
|---|---|
| Planeación | [Requisitos](docs/requisitos.md) |
| Planeación | [Estimación](docs/estimacion.md) |
| Diseño | [Diseño del sistema](docs/diseno.md) |
| Diseño | [Pseudocódigo](docs/pseudocodigo.md) |
| Diseño | [Diagramas](docs/diagramas/) |
| Código | [Estándar de codificación](docs/estandar_codificacion.md) |
| Compilación | [Informe de compilación](docs/informe_compilacion.md) |
| Pruebas | [Casos de prueba](docs/casos_prueba.md) |
| Pruebas | [Informe de pruebas](docs/informe_pruebas.md) |
| Postmortem | [Project Plan Summary](docs/resumen_pps.md) |
| Postmortem | [Process Improvement Proposal](docs/pip.md) |
| Postmortem | [Registro de tiempos](docs/registros/time_log.csv) |
| Postmortem | [Registro de defectos](docs/registros/defect_log.csv) |

## Documentos PDF

- [Requisitos del Programa 1](docs/01_Requisitos_Programa1.pdf).
- [Diseño del Programa 1](docs/02_Diseno_Programa1.pdf).
- [Informe de pruebas del Programa 1](docs/03_Informe_Pruebas_Programa1.pdf).



cat >> README.md <<'EOF'

## Entregables PSP0

| Fase | Documentación |
|---|---|
| Planeación | [Requisitos](docs/requisitos.md) |
| Planeación | [Estimación](docs/estimacion.md) |
| Diseño | [Diseño del sistema](docs/diseno.md) |
| Diseño | [Pseudocódigo](docs/pseudocodigo.md) |
| Diseño | [Diagramas](docs/diagramas/) |
| Código | [Estándar de codificación](docs/estandar_codificacion.md) |
| Compilación | [Informe de compilación](docs/informe_compilacion.md) |
| Pruebas | [Casos de prueba](docs/casos_prueba.md) |
| Pruebas | [Informe de pruebas](docs/informe_pruebas.md) |
| Postmortem | [Project Plan Summary](docs/resumen_pps.md) |
| Postmortem | [Process Improvement Proposal](docs/pip.md) |
| Postmortem | [Registro de tiempos](docs/registros/time_log.csv) |
| Postmortem | [Registro de defectos](docs/registros/defect_log.csv) |

## Documentos PDF

- [Requisitos del Programa 1](docs/01_Requisitos_Programa1.pdf).
- [Diseño del Programa 1](docs/02_Diseno_Programa1.pdf).
- [Informe de pruebas del Programa 1](docs/03_Informe_Pruebas_Programa1.pdf).

## Evidencias de ejecución

- [Compilación](docs/evidencias/compilacion.txt).
- [Pruebas unitarias](docs/evidencias/pruebas_unitarias.txt).
