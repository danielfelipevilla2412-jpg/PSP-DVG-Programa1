# Estándar de codificación - Programa 1

## 1. Tecnología

- Lenguaje: C#.
- Plataforma: .NET 9.
- Metodología: PSP0.
- Framework de pruebas: xUnit.

## 2. Convenciones de nombres

| Elemento | Convención | Ejemplo |
|---|---|---|
| Clases | PascalCase | StatisticsService |
| Métodos | PascalCase | ReadNumbers |
| Propiedades | PascalCase | StandardDeviation |
| Variables | camelCase | lineNumber |
| Parámetros | camelCase | path |
| Campos privados | _camelCase | _head |
| Constantes | PascalCase | Red |

## 3. Formato

- Indentación de cuatro espacios.
- Llaves en líneas independientes.
- Nombres descriptivos.
- Archivos en UTF-8.
- Comentarios técnicos cuando sean necesarios.

## 4. Arquitectura

| Directorio | Responsabilidad |
|---|---|
| DataStructures | Lista enlazada y nodos. |
| Models | Representación de resultados. |
| Services | Cálculos estadísticos. |
| Infrastructure | Lectura de archivos. |
| Presentation | Interfaz de consola. |

## 5. Reglas de implementación

- Separar las responsabilidades de cada clase.
- Utilizar una lista enlazada genérica propia.
- Aplicar encapsulamiento.
- Evitar duplicación de código.
- Gestionar excepciones específicas.
- Validar los datos de entrada.

## 6. Precisión numérica

- Utilizar double para los cálculos.
- Rechazar valores no finitos.
- Validar un mínimo de dos elementos.
- No redondear resultados intermedios.
- Mostrar resultados con dos decimales.
- Utilizar InvariantCulture.
- Calcular la desviación muestral con n - 1.

## 7. Control de calidad

- Revisar el código antes de compilar.
- Verificar errores y advertencias.
- Ejecutar pruebas unitarias y funcionales.
- Registrar tiempos y defectos en PSP Tracker.

## 8. Control de versiones

- Utilizar Git y GitHub.
- Organizar commits por fase PSP0.
- Utilizar mensajes descriptivos.
- Excluir bin, obj y archivos temporales.
