using Xunit;
using Programa1.Services;
using LinkedList = Programa1.DataStructures.LinkedList<double>;

namespace Programa1.Tests;

/// <summary>
/// Pruebas unitarias del servicio de cálculos estadísticos.
/// </summary>
public class StatisticsServiceTests
{
    private readonly StatisticsService _service = new();

    [Fact]
    public void Calculate_ShouldReturnExpectedSizeStatistics()
    {
        var list = CreateList(
            160, 591, 114, 229, 230,
            270, 128, 1657, 624, 1503);

        var result = _service.Calculate(list);

        Assert.Equal(10, result.Count);
        Assert.Equal(550.60, result.Mean, 2);
        Assert.Equal(572.03, result.StandardDeviation, 2);
    }

    [Fact]
    public void Calculate_ShouldReturnExpectedHourStatistics()
    {
        var list = CreateList(
            15.0, 69.9, 6.5, 22.4, 28.4,
            65.9, 19.4, 198.7, 38.8, 138.2);

        var result = _service.Calculate(list);

        Assert.Equal(10, result.Count);
        Assert.Equal(60.32, result.Mean, 2);
        Assert.Equal(62.26, result.StandardDeviation, 2);
    }

    [Fact]
    public void Calculate_ShouldHandleEqualValues()
    {
        var list = CreateList(5, 5, 5);

        var result = _service.Calculate(list);

        Assert.Equal(3, result.Count);
        Assert.Equal(5.0, result.Mean, 10);
        Assert.Equal(0.0, result.StandardDeviation, 10);
    }

    [Fact]
    public void Calculate_ShouldHandleNegativeValues()
    {
        var list = CreateList(-3, -2, -1);

        var result = _service.Calculate(list);

        Assert.Equal(-2.0, result.Mean, 10);
        Assert.Equal(1.0, result.StandardDeviation, 10);
    }

    [Fact]
    public void Calculate_ShouldHandleDecimalValues()
    {
        var list = CreateList(1.5, 2.5, 3.5);

        var result = _service.Calculate(list);

        Assert.Equal(2.5, result.Mean, 10);
        Assert.Equal(1.0, result.StandardDeviation, 10);
    }

    [Fact]
    public void Calculate_ShouldHandleTwoValues()
    {
        var list = CreateList(2, 4);

        var result = _service.Calculate(list);

        Assert.Equal(2, result.Count);
        Assert.Equal(3.0, result.Mean, 10);
        Assert.Equal(
            Math.Sqrt(2),
            result.StandardDeviation,
            10);
    }

    [Fact]
    public void Calculate_ShouldRejectEmptyList()
    {
        var list = new LinkedList();

        Assert.Throws<InvalidOperationException>(
            () => _service.Calculate(list));
    }

    [Fact]
    public void Calculate_ShouldRejectSingleValue()
    {
        var list = CreateList(10);

        Assert.Throws<InvalidOperationException>(
            () => _service.Calculate(list));
    }

    [Theory]
    [InlineData(double.NaN)]
    [InlineData(double.PositiveInfinity)]
    [InlineData(double.NegativeInfinity)]
    public void Calculate_ShouldRejectNonFiniteValues(
        double invalidValue)
    {
        var list = CreateList(10, invalidValue, 30);

        Assert.Throws<ArgumentException>(
            () => _service.Calculate(list));
    }

    [Fact]
    public void Calculate_ShouldRejectNullList()
    {
        Assert.Throws<ArgumentNullException>(
            () => _service.Calculate(null!));
    }

    [Fact]
    public void Calculate_ShouldDetectOverflow()
    {
        var list = CreateList(
            double.MaxValue,
            double.MaxValue);

        Assert.Throws<OverflowException>(
            () => _service.Calculate(list));
    }

    private static LinkedList CreateList(
        params double[] values)
    {
        var list = new LinkedList();

        foreach (double value in values)
        {
            list.Add(value);
        }

        return list;
    }
}