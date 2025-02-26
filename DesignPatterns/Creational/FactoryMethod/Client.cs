using DesignPatterns.Creational.FactoryMethod.Factories;
using DesignPatterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Creational.FactoryMethod
{
    class Client
    {
        public void StartClient()
        {
            LoggerFactory factory = null;
            ILogger logger = null;

            Dictionary<string, LoggerFactory> factories = new()
            {
                { "console", new ConsoleLoggerFactory()
                },
                { "file", new FileLoggerFactory()
                }
            };

            while (factory == null)
            {
                Console.Clear();
                Console.WriteLine("========== Logger Setup ==========");
                Console.WriteLine("Choose a logger type: \n  - Console\n  - File");
                Console.Write("Enter your choice: ");

                string loggerType = Console.ReadLine()?.Trim().ToLower();

                if (factories.TryGetValue(loggerType, out factory))
                {
                    logger = factory.CreateLogger();
                    Console.WriteLine("\n✅ Logger initialized successfully!\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n❌ Invalid choice! Please enter 'Console' or 'File'.");
                    Console.ResetColor();
                    Console.WriteLine("\nPress any key to try again...");
                    Console.ReadKey();
                }
            }

            while (true)
            {
                Console.WriteLine("\n========== Logging Menu ==========");
                Console.WriteLine("Choose a log type: \n  - Info\n  - Debug\n  - Warning\n  - Error");
                Console.Write("Or type 'exit' to quit: ");

                string logTypeInput = Console.ReadLine()?.Trim().ToLower();

                if (logTypeInput == "exit")
                {
                    Console.WriteLine("\n🔚 Exiting the application...");
                    break;
                }

                if (!Enum.TryParse(typeof(LogType), logTypeInput, true, out object logTypeObj))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n❌ Invalid log type. Please enter Info, Debug, Warning, or Error.");
                    Console.ResetColor();
                    continue;
                }

                LogType logType = (LogType)logTypeObj;

                Console.Write("\n📝 Enter your log message: ");
                string message = Console.ReadLine();

                switch (logType)
                {
                    case LogType.Info:
                        logger.Info(message);
                        break;
                    case LogType.Debug:
                        logger.Debug(message);
                        break;
                    case LogType.Warning:
                        logger.Warning(message);
                        break;
                    case LogType.Error:
                        Console.Write("⚠ Enter error details: ");
                        string errorDetails = Console.ReadLine();
                        logger.Error(message, new Exception(errorDetails));
                        break;
                }
            }
        }
    }
    enum LogType { Info, Debug, Warning, Error }
}
