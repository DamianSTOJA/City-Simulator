namespace CitySimulator.Util;

using System.IO;
public static class Logger {
    private static string logFilePath = "log.txt";

     public static void Log(string message)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"[{System.DateTime.Now}] {message}");
            }
        }
        catch
        {
            // Fail silently to avoid crashing on logging errors
        }
    }

    public static void ClearLog()
    {
        try
        {
            File.WriteAllText(logFilePath, string.Empty);
        }
        catch
        {
            // Fail silently
        }
    }

}