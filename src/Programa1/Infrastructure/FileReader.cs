using System.Globalization;
using LinkedList = Programa1.DataStructures.LinkedList<double>;

namespace Programa1.Infrastructure;

/// <summary>
/// Responsable de leer y validar archivos de datos numéricos.
/// </summary>
public sealed class FileReader
{
    /// <summary>
    /// Lee los números de un archivo de texto y los almacena
    /// en una lista simplemente enlazada.
    /// </summary>
    public LinkedList ReadNumbers(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            throw new ArgumentException(
                "La ruta del archivo no puede estar vacía.",
                nameof(path));
        }

        var numbers = new LinkedList();
        int lineNumber = 0;

        foreach (string line in File.ReadLines(path))
        {
            lineNumber++;

            string content = line.Trim();

            if (!double.TryParse(
                content,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out double number))
            {
                throw new FormatException(
                    $"Valor numérico inválido en la línea {lineNumber}.");
            }

            if (!double.IsFinite(number))
            {
                throw new FormatException(
                    $"Valor no finito en la línea {lineNumber}.");
            }

            numbers.Add(number);
        }

        if (numbers.Count == 0)
        {
            throw new InvalidOperationException(
                "El archivo no contiene datos.");
        }

        return numbers;
    }
}