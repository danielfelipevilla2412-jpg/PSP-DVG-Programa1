using Programa1.Infrastructure;
using Programa1.Presentation;
using Programa1.Services;

namespace Programa1;

/// <summary>
/// Punto de entrada de la aplicación estadística.
/// Coordina los componentes del sistema.
/// </summary>
internal static class Program
{
    private static void Main()
    {
        var ui = new ConsoleUI();
        var fileReader = new FileReader();
        var statisticsService = new StatisticsService();

        while (true)
        {
            ui.ShowMenu();

            string option = ui.RequestOption();

            switch (option)
            {
                case "1":
                case "01":
                    string? path = ui.RequestFilePath();

                    if (path is null)
                    {
                        Console.WriteLine(
                            "\n[OFFLINE] Sistema finalizado.");
                        return;
                    }

                    ProcessFile(
                        ui,
                        fileReader,
                        statisticsService,
                        path);
                    break;

                case "2":
                case "02":
                    Console.WriteLine(
                        "\n[OFFLINE] Sistema finalizado.");
                    return;

                default:
                    ui.ShowError(
                        "Opción inválida. Seleccione 1 o 2.");
                    break;
            }
        }
    }

    /// <summary>
    /// Coordina la lectura, el cálculo y la presentación
    /// de los resultados estadísticos.
    /// </summary>
    private static void ProcessFile(
        ConsoleUI ui,
        FileReader fileReader,
        StatisticsService statisticsService,
        string path)
    {
        try
        {
            var numbers = fileReader.ReadNumbers(path);

            var result = statisticsService.Calculate(numbers);

            ui.ShowResults(result);
        }
        catch (FileNotFoundException)
        {
            ui.ShowError("El archivo indicado no existe.");
        }
        catch (DirectoryNotFoundException)
        {
            ui.ShowError("El directorio indicado no existe.");
        }
        catch (UnauthorizedAccessException)
        {
            ui.ShowError(
                "No tiene permisos para acceder al archivo.");
        }
        catch (FormatException ex)
        {
            ui.ShowError(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            ui.ShowError(ex.Message);
        }
        catch (OverflowException ex)
        {
            ui.ShowError(ex.Message);
        }
        catch (ArgumentException ex)
        {
            ui.ShowError(ex.Message);
        }
        catch (NotSupportedException)
        {
            ui.ShowError(
                "El formato de la ruta no es compatible.");
        }
        catch (IOException)
        {
            ui.ShowError(
                "Ocurrió un error durante la lectura del archivo.");
        }
    }
}