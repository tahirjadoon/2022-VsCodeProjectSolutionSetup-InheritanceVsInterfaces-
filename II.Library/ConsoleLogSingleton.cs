namespace II.Library;
public sealed class ConsoleLogSingleton
{
    public static readonly Lazy<ConsoleLogSingleton> lazy = new Lazy<ConsoleLogSingleton>(() => new ConsoleLogSingleton());

    public static ConsoleLogSingleton GetInstance => lazy.Value;

    private readonly ConsoleColor _defaultForegroundColor;
    private readonly ConsoleColor _defaultBackgroundColor;

    private ConsoleLogSingleton()
    {
        _defaultForegroundColor = Console.ForegroundColor;
        _defaultBackgroundColor = Console.BackgroundColor;
    }

    public ConsoleColor DefaultForegroupColor => _defaultForegroundColor;
    public ConsoleColor DefaultBackgroundColor => _defaultBackgroundColor;

    /// <summary>
    /// will write empty lines
    /// </summary>
    /// <param name="lines"></param>
    public void WriteLine(int lines = 1)
    {
        var line = 1;
        while (line <= lines)
        {
            Console.WriteLine("");
            line++;
        }
    }

    public void WriteLine(string text)
    {
        Console.WriteLine(text);
    }

    public void WriteLine(string text, bool resetToDefaultColorAfterWrite = true)
    {
        Console.WriteLine(text);
        if (resetToDefaultColorAfterWrite)
            Console.ForegroundColor = DefaultForegroupColor;
    }

    public void WriteLine(string text, ConsoleColor color, bool resetToDefaultColorAfterWrite = true)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        if (resetToDefaultColorAfterWrite)
            Console.ForegroundColor = DefaultForegroupColor;
    }

    public void Write(string text)
    {
        Console.Write(text);
    }

    public void Write(string text, bool resetToDefaultColorAfterWrite = true)
    {
        Console.Write(text);
        if (resetToDefaultColorAfterWrite)
            Console.ForegroundColor = DefaultForegroupColor;
    }

    public void Write(string text, ConsoleColor color, bool resetToDefaultColorAfterWrite = true)
    {
        Console.ForegroundColor = color;
        Console.Write(text);
        if (resetToDefaultColorAfterWrite)
            Console.ForegroundColor = DefaultForegroupColor;
    }


}
