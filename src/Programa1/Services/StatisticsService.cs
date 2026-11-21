using Programa1.Models;
using LinkedList = Programa1.DataStructures.LinkedList<double>;

namespace Programa1.Services;

/// <summary>
/// Servicio responsable de realizar los cálculos estadísticos.
/// </summary>
public sealed class StatisticsService
{
    /// <summary>
    /// Calcula la media y la desviación estándar muestral.
    /// </summary>
    public StatisticsResult Calculate(LinkedList data)
    {
        ArgumentNullException.ThrowIfNull(data);

        if (data.Count == 0)
        {
            throw new InvalidOperationException(
                "El conjunto de datos está vacío.");
        }

        if (data.Count < 2)
        {
            throw new InvalidOperationException(
                "Se requieren al menos dos valores.");
        }

        double mean = CalculateMean(data);
        double standardDeviation = CalculateStdDev(data, mean);

        if (!double.IsFinite(mean) ||
            !double.IsFinite(standardDeviation))
        {
            throw new OverflowException(
                "Los resultados exceden el rango numérico permitido.");
        }

        return new StatisticsResult(
            data.Count,
            mean,
            standardDeviation);
    }

    /// <summary>
    /// Calcula la media aritmética del conjunto de datos.
    /// </summary>
    private double CalculateMean(LinkedList data)
    {
        double sum = 0;

        foreach (double value in data)
        {
            if (!double.IsFinite(value))
            {
                throw new ArgumentException(
                    "El conjunto contiene valores no finitos.",
                    nameof(data));
            }

            sum += value;
        }

        return sum / data.Count;
    }

    /// <summary>
    /// Calcula la desviación estándar muestral.
    /// </summary>
    private double CalculateStdDev(LinkedList data, double mean)
    {
        double sumSquaredDifferences = 0;

        foreach (double value in data)
        {
            double difference = value - mean;

            sumSquaredDifferences += difference * difference;
        }

        double variance = sumSquaredDifferences / (data.Count - 1);

        return Math.Sqrt(variance);
    }
}