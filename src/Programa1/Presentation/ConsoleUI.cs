using System.Globalization;
using System.Text;
using Programa1.Models;

namespace Programa1.Presentation;

/// <summary>
/// Gestiona la presentación y la interacción con el usuario.
/// </summary>
public sealed class ConsoleUI
{
    private const string Red = "\u001b[38;2;255;0;60m";
    private const string White = "\u001b[38;2;245;245;245m";
    private const string Gray = "\u001b[38;2;128;128;128m";
    private const string Background = "\u001b[48;2;8;8;8m";
    private const string Reset = "\u001b[0m";

    private readonly bool _supportsAnsi;

    public ConsoleUI()
    {
        Console.OutputEncoding = Encoding.UTF8;

        _supportsAnsi =
            !Console.IsOutputRedirected &&
            (
                !string.IsNullOrWhiteSpace(
                    Environment.GetEnvironmentVariable("WT_SESSION"))
                ||
                Environment.GetEnvironmentVariable("TERM_PROGRAM")
                    == "vscode"
            );
    }

    /// <summary>
    /// Presenta el menú principal del sistema.
    /// </summary>
    public void ShowMenu()
    {
        Console.WriteLine();

        ShowSeparator();

        WriteStyled("  PSP_01", Red);
        WriteStyled("  STATISTICAL ENGINE", White);
        WriteStyled("  SYSTEM VERSION 1.0 | PSP0 | .NET 9", Gray);
        WriteStyled("  [ONLINE] SISTEMA OPERATIVO", Red);

        ShowSeparator();

        WriteStyled("  01 // MAIN MENU", Red);

        Console.WriteLine();

        WriteStyled("  [01] Procesar archivo de datos", White);
        WriteStyled("  [02] Salir del sistema", White);

        Console.WriteLine();

        ShowSeparator();
    }

    /// <summary>
    /// Solicita una opción del menú principal.
    /// </summary>
    public string RequestOption()
    {
        WriteStyled("  PSP@ENGINE:~$ ", Red, false);

        return Console.ReadLine()?.Trim() ?? "2";
    }

    /// <summary>
    /// Solicita la ruta del archivo de entrada.
    /// </summary>
    public string? RequestFilePath()
    {
        Console.WriteLine();

        WriteStyled("  02 // DATA INPUT", Red);

        ShowSeparator();

        WriteStyled(
            "  Ingrese la ruta del archivo TXT.", White);

        WriteStyled(
            "  Ejemplo: data/tamanos.txt", Gray);

        Console.WriteLine();

        WriteStyled("  ARCHIVO > ", Red, false);

        return Console.ReadLine()?.Trim().Trim('"');
    }

    /// <summary>
    /// Presenta los resultados del procesamiento.
    /// </summary>
    public void ShowResults(StatisticsResult result)
    {
        string mean = result.Mean.ToString(
            "F2",
            CultureInfo.InvariantCulture);

        string standardDeviation =
            result.StandardDeviation.ToString(
                "F2",
                CultureInfo.InvariantCulture);

        Console.WriteLine();

        ShowSeparator();

        WriteStyled("  03 // ANALYSIS REPORT", Red);
        WriteStyled("  [OK] PROCESS COMPLETED", Red);

        ShowSeparator();

        WriteStyled("  CANTIDAD DE DATOS", Gray);
        WriteStyled($"  {result.Count}", White);

        Console.WriteLine();

        WriteStyled("  MEDIA ARITMETICA", Gray);
        WriteStyled($"  {mean}", Red);

        Console.WriteLine();

        WriteStyled("  DESVIACION ESTANDAR MUESTRAL", Gray);
        WriteStyled($"  {standardDeviation}", Red);

        ShowSeparator();

        WriteStyled(
            "  [OK] Procesamiento completado correctamente.",
            White);
    }

    /// <summary>
    /// Presenta los errores del sistema.
    /// </summary>
    public void ShowError(string message)
    {
        Console.WriteLine();

        ShowSeparator();

        WriteStyled("  [ERROR] SYSTEM ALERT", Red);
        WriteStyled($"  {message}", White);

        ShowSeparator();
    }

    /// <summary>
    /// Dibuja un separador visual.
    /// </summary>
    private void ShowSeparator()
    {
        WriteStyled(new string('=', 55), Red);
    }

    /// <summary>
    /// Escribe texto con colores ANSI o colores tradicionales.
    /// </summary>
    private void WriteStyled(
        string text,
        string color,
        bool newLine = true)
    {
        if (Console.IsOutputRedirected)
        {
            if (newLine)
                Console.WriteLine(text);
            else
                Console.Write(text);

            return;
        }

        if (_supportsAnsi)
        {
            string styledText =
                $"{Background}{color}{text}{Reset}";

            if (newLine)
                Console.WriteLine(styledText);
            else
                Console.Write(styledText);

            return;
        }

        ConsoleColor previousForeground =
            Console.ForegroundColor;

        ConsoleColor previousBackground =
            Console.BackgroundColor;

        try
        {
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ForegroundColor = color switch
            {
                Red => ConsoleColor.Red,
                Gray => ConsoleColor.DarkGray,
                _ => ConsoleColor.White
            };

            if (newLine)
                Console.WriteLine(text);
            else
                Console.Write(text);
        }
        finally
        {
            Console.ForegroundColor = previousForeground;
            Console.BackgroundColor = previousBackground;
        }
    }
}