using DesignPatterns.Creational.FactoryMethod.Factories;
using DesignPatterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Creational.FactoryMethod
{
    class Client
    {
        public void StartClient()
        {
            ILogger logger = null;

            while (logger == null)
            {
                Console.WriteLine("Choose a logger type: Console or File");
                string loggerType = Console.ReadLine()?.Trim().ToLower();

                switch (loggerType)
                {
                    case "console":
                        logger = new ConsoleLoggerFactory().CreateLogger();
                        break;
                    case "file":
                        logger = new FileLoggerFactory().CreateLogger();
                        break;
                }
            }

            while (true)
            {
                Console.WriteLine("\nChoose a log type: Info, Debug, Warning, Error (or type 'exit' to quit)");
                string logType = Console.ReadLine()?.Trim().ToLower();

                if (logType == "exit")
                {
                    Console.WriteLine("Exiting the application...");
                    break;
                }

                Console.Write("Enter your log message: ");
                string message = Console.ReadLine();

                switch (logType)
                {
                    case "info":
                        logger.Info(message);
                        break;
                    case "debug":
                        logger.Debug(message);
                        break;
                    case "warning":
                        logger.Warning(message);
                        break;
                    case "error":
                        Console.Write("Enter error details: ");
                        string errorDetails = Console.ReadLine();
                        logger.Error(message, new Exception(errorDetails));
                        break;
                    default:
                        Console.WriteLine("Invalid log type. Please choose Info, Debug, Warning, or Error.");
                        break;
                }
            }
        }
    }
}
