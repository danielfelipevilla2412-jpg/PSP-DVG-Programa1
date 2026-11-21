# Process Improvement Proposal (PIP)

## Información general

- Proyecto: PSP-DVG-Programa1.
- Metodología: PSP0.
- Fase: Postmortem.

## PIP-01: Control de versiones tardío

### Problema

Los commits no se realizaron oportunamente
al finalizar cada fase del proceso.

### Consecuencia

Fue necesario organizar retrospectivamente
los entregables y publicarlos en GitHub.

### Propuesta de mejora

Realizar y publicar el commit correspondiente
antes de cerrar cada fase PSP.

### Indicador de cumplimiento

Cada fase debe contar con sus entregables
y su commit antes de iniciar la siguiente.

## PIP-02: Manejo del fin de entrada

### Problema

La solicitud de una ruta de archivo no
diferenciaba correctamente una entrada vacía
del fin de entrada de la consola.

### Consecuencia

Se generaba un mensaje de error innecesario.

### Propuesta de mejora

Incorporar validaciones de valores nulos
y escenarios EOF desde la fase de diseño.

### Indicador de cumplimiento

Incluir pruebas de entradas vacías, nulas
y fin de entrada en futuros programas.

## PIP-03: Precisión de las estimaciones

### Problema

Se presentaron diferencias entre los tiempos
estimados y los tiempos reales de desarrollo.

### Propuesta de mejora

Utilizar los datos históricos del Programa 1
como referencia para estimaciones posteriores.

### Indicador de cumplimiento

Comparar sistemáticamente el tiempo planificado
con el tiempo real de cada fase.

## PIP-04: Verificación de permisos

### Problema

No se verificó completamente el escenario
de acceso a archivos con permisos restringidos.

### Propuesta de mejora

Incluir pruebas específicas de permisos
del sistema operativo cuando corresponda.

### Indicador de cumplimiento

Documentar la evidencia de cada criterio
de aceptación y sus limitaciones.

## Aplicación

Las propuestas serán consideradas durante
el desarrollo de los programas 2 y 3.
