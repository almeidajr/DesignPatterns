using Spectre.Console;

namespace DesignPatterns.Creational.Singleton;

public class DatabaseContext
{
    private static DatabaseContext? _instance;
    private static readonly Mutex Mutex = new();

    private DatabaseContext()
    {
    }

    public static DatabaseContext GetInstance()
    {
        if (_instance == null)
        {
            Mutex.WaitOne();
            _instance ??= new DatabaseContext();
            Mutex.ReleaseMutex();
        }

        AnsiConsole.WriteLine($"Getting {nameof(DatabaseContext)} instance");
        return _instance;
    }
}