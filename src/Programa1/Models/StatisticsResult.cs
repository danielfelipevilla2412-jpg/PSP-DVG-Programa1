namespace Programa1.Models;

/// <summary>
/// Representa los resultados del procesamiento estadístico.
/// </summary>
public sealed class StatisticsResult
{
    public int Count { get; }

    public double Mean { get; }

    public double StandardDeviation { get; }

    public StatisticsResult(
        int count,
        double mean,
        double standardDeviation)
    {
        Count = count;
        Mean = mean;
        StandardDeviation = standardDeviation;
    }
}