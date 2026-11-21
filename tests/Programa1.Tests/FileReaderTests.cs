using Xunit;
using Programa1.Infrastructure;

namespace Programa1.Tests;

/// <summary>
/// Pruebas del componente de lectura y validación
/// de archivos de datos.
/// </summary>
public class FileReaderTests
{
    private readonly FileReader _reader = new();

    [Fact]
    public void ReadNumbers_ShouldReadValidFile()
    {
        string path = CreateTemporaryFile(
            "10", "20", "30");

        try
        {
            var result = _reader.ReadNumbers(path);

            Assert.Equal(3, result.Count);

            Assert.Equal(
                new double[] { 10, 20, 30 },
                result.ToArray());
        }
        finally
        {
            File.Delete(path);
        }
    }

    [Fact]
    public void ReadNumbers_ShouldReadDecimalValues()
    {
        string path = CreateTemporaryFile(
            "1.5", "2.5", "-3.75");

        try
        {
            var result = _reader.ReadNumbers(path);

            Assert.Equal(
                new double[] { 1.5, 2.5, -3.75 },
                result.ToArray());
        }
        finally
        {
            File.Delete(path);
        }
    }

    [Fact]
    public void ReadNumbers_ShouldRejectEmptyFile()
    {
        string path = CreateTemporaryFile();

        try
        {
            Assert.Throws<InvalidOperationException>(
                () => _reader.ReadNumbers(path));
        }
        finally
        {
            File.Delete(path);
        }
    }

    [Fact]
    public void ReadNumbers_ShouldRejectMissingFile()
    {
        string path = Path.Combine(
            Path.GetTempPath(),
            $"{Guid.NewGuid()}.txt");

        Assert.Throws<FileNotFoundException>(
            () => _reader.ReadNumbers(path));
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    public void ReadNumbers_ShouldRejectEmptyPath(
        string path)
    {
        Assert.Throws<ArgumentException>(
            () => _reader.ReadNumbers(path));
    }

    [Theory]
    [InlineData("abc")]
    [InlineData("NaN")]
    [InlineData("Infinity")]
    [InlineData("-Infinity")]
    [InlineData("15,5")]
    public void ReadNumbers_ShouldRejectInvalidValues(
        string invalidValue)
    {
        string path = CreateTemporaryFile(
            "10", invalidValue, "30");

        try
        {
            var exception = Assert.Throws<FormatException>(
                () => _reader.ReadNumbers(path));

            Assert.Contains("línea 2", exception.Message);
        }
        finally
        {
            File.Delete(path);
        }
    }

    [Fact]
    public void ReadNumbers_ShouldRejectEmptyLines()
    {
        string path = CreateTemporaryFile(
            "10", "", "30");

        try
        {
            var exception = Assert.Throws<FormatException>(
                () => _reader.ReadNumbers(path));

            Assert.Contains("línea 2", exception.Message);
        }
        finally
        {
            File.Delete(path);
        }
    }

    [Fact]
    public void ReadNumbers_ShouldReadSingleValidValue()
    {
        string path = CreateTemporaryFile("10");

        try
        {
            var result = _reader.ReadNumbers(path);

            Assert.Equal(1, result.Count);
            Assert.Equal(10.0, result.Single());
        }
        finally
        {
            File.Delete(path);
        }
    }

    /// <summary>
    /// Crea un archivo temporal independiente
    /// para cada caso de prueba.
    /// </summary>
    private static string CreateTemporaryFile(
        params string[] lines)
    {
        string path = Path.Combine(
            Path.GetTempPath(),
            $"{Guid.NewGuid()}.txt");

        File.WriteAllLines(path, lines);

        return path;
    }
}
