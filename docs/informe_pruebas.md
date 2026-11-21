# Informe de pruebas - Programa 1

## 1. Información general

- Proyecto: PSP-DVG-Programa1.
- Metodología: PSP0.
- Fase: TEST.
- Framework: xUnit.
- Plataforma: .NET 9.

## 2. Resultados consolidados

| Tipo de prueba | Ejecutadas | Aprobadas | Fallidas |
|---|---:|---:|---:|
| Funcionales | 19 | 19 | 0 |
| Unitarias | 32 | 32 | 0 |
| Total | 51 | 51 | 0 |

Porcentaje de aprobación de casos ejecutados: 100 %.

Este porcentaje no representa cobertura de código.

## 3. Validación estadística

| Dataset | Cantidad | Media | Desviación estándar |
|---|---:|---:|---:|
| Tamaños | 10 | 550.60 | 572.03 |
| Horas | 10 | 60.32 | 62.26 |
| Valores iguales | 3 | 5.00 | 0.00 |
| Valores negativos | 3 | -2.00 | 1.00 |
| Valores decimales | 3 | 2.50 | 1.00 |

## 4. Resultados por componente

| Componente | Pruebas | Aprobadas |
|---|---:|---:|
| LinkedList | 6 | 6 |
| StatisticsService | 13 | 13 |
| FileReader | 13 | 13 |

## 5. Registro PSP0

- Tiempo objetivo: 60 minutos.
- Tiempo máximo estimado: 90 minutos.
- Tiempo real de la fase original: 15 minutos.
- Defectos nuevos durante las pruebas: 0.

La ejecución adicional de cierre permite conservar
evidencia de la versión publicada.

## 6. Verificación de defectos

El defecto DEF-001 fue detectado y corregido durante
la revisión de código.

La prueba PF-19 verificó su corrección mediante
el fin de entrada al solicitar la ruta del archivo.

## 7. Limitaciones

El criterio CA-04 tiene verificación parcial.

Se comprobó el manejo de archivos inexistentes y
rutas correspondientes a directorios, pero no se
realizó una prueba específica con permisos de archivo
restringidos mediante el sistema operativo.

## 8. Evidencias

- [Casos de prueba](casos_prueba.md).
- [Resultado de pruebas unitarias](evidencias/pruebas_unitarias.txt).
- [Informe completo PDF](03_Informe_Pruebas_Programa1.pdf).

## 9. Conclusión

El programa satisface los resultados estadísticos
esperados y supera los 51 casos de prueba ejecutados.

Se encuentra en condiciones de continuar hacia
la fase de postmortem, dejando documentada la
limitación de verificación indicada.
